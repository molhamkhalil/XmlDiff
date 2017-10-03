using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleXmlDiff.Code.Classes;
using VisualXmlDiff.Forms;

namespace VisualXmlDiff
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog FolderBrowseDialogue = null;
        string newDirectory = "", referenceDirectory = "", diffDirectory = "";
        ResultForm resultBrowser = null;

        public MainForm()
        {
            InitializeComponent();
            setTips();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FolderBrowseDialogue = new FolderBrowserDialog();
            FolderBrowseDialogue.ShowNewFolderButton = false;
            Compare_Button.Enabled = false;
            Save_Button.Enabled = false;
            ExcludeNodes_CheckBox.Checked = false;
            XPath_TextBox.Enabled = false;
        }

        private void NewFolder_TextBox_TextChanged(object sender, EventArgs e)
        {
            newDirectory = NewFolder_TextBox.Text;
            if (newDirectory != "" && referenceDirectory != "" && diffDirectory != "")
            {
                Compare_Button.Enabled = true;
                Save_Button.Enabled = true;
            }
            else
            {
                Compare_Button.Enabled = false;
                Save_Button.Enabled = false;
            }
        }

        private void ReferenceFolder_TextBox_TextChanged(object sender, EventArgs e)
        {
            referenceDirectory = ReferenceFolder_TextBox.Text;
            if (newDirectory != "" && referenceDirectory != "" && diffDirectory != "")
            {
                Compare_Button.Enabled = true;
                Save_Button.Enabled = true;
            }
            else
            {
                Compare_Button.Enabled = false;
                Save_Button.Enabled = false;
            }
        }

        private void XmlDiffFolder_TextBox_TextChanged(object sender, EventArgs e)
        {
            diffDirectory = XmlDiffFolder_TextBox.Text;
            if (newDirectory != "" && referenceDirectory != "" && diffDirectory != "")
            {
                Compare_Button.Enabled = true;
                Save_Button.Enabled = true;
            }
            else
            {
                Compare_Button.Enabled = false;
                Save_Button.Enabled = false;
            }
        }

        private void NewFolder_Button_Click(object sender, EventArgs e)
        {
            FolderBrowseDialogue.Description = "Choose the Directory of New Files";
            if (FolderBrowseDialogue.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
            {
                NewFolder_TextBox.Text = FolderBrowseDialogue.SelectedPath;
                newDirectory = FolderBrowseDialogue.SelectedPath;
                Console.WriteLine("New directory set");
            }
        }

        private void ReferenceFolder_Button_Click(object sender, EventArgs e)
        {
            FolderBrowseDialogue.Description = "Choose the Directory of Reference Files";
            if (FolderBrowseDialogue.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
            {
                ReferenceFolder_TextBox.Text = FolderBrowseDialogue.SelectedPath;
                referenceDirectory = FolderBrowseDialogue.SelectedPath;
                Console.WriteLine("Reference directory set");
            }
        }

        private void XmlDiffFolder_Button_Click(object sender, EventArgs e)
        {
            FolderBrowseDialogue.Description = "Choose a directory to write " + Configuration.DiffFileName + Configuration.DiffFileExtension;
            if (FolderBrowseDialogue.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
            {
                XmlDiffFolder_TextBox.Text = FolderBrowseDialogue.SelectedPath;
                diffDirectory = FolderBrowseDialogue.SelectedPath;
                Console.WriteLine("Diff directory set");
            }
        }

        private void Compare_Button_Click(object sender, EventArgs e)
        {
            string[] args = null;
            if (ExcludeNodes_CheckBox.Checked && XPath_TextBox.Text.Length > 0)
            {
                if (newDirectory != "" && referenceDirectory != "" && diffDirectory != "")
                {
                    args = new string[4];
                    args[0] = newDirectory;
                    args[1] = referenceDirectory;
                    args[2] = diffDirectory;
                    args[3] = XPath_TextBox.Text;
                }
                else
                {
                    args = new string[1];
                    args[0] = XPath_TextBox.Text;
                }
            }
            else
            {
                if (newDirectory != "" && referenceDirectory != "" && diffDirectory != "")
                {
                    args = new string[3];
                    args[0] = newDirectory;
                    args[1] = referenceDirectory;
                    args[2] = diffDirectory;
                }
            }

            try
            {
                ConsoleXmlDiff.Code.Program.Main(args);
                resultBrowser = new ResultForm(Configuration.DiffDirectory, Configuration.DiffFileName);
                resultBrowser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePathsDialogue = new SaveFileDialog();
            savePathsDialogue.CheckPathExists = true;
            savePathsDialogue.ValidateNames = true;
            savePathsDialogue.RestoreDirectory = true;
            savePathsDialogue.Filter = "Directory (*.dir)| *.dir";
            savePathsDialogue.Title = "Choose a path to save the directories:";

            if (savePathsDialogue.ShowDialog() == DialogResult.OK)
                using (VisualXmlDiff.Classes.Directoris newDirectories = new Classes.Directoris(newDirectory, referenceDirectory, diffDirectory))
                {
                    newDirectories.Save(savePathsDialogue.FileName);
                    Console.WriteLine("Directories saved");
                }

        }

        private void Brwose_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog directoryFileDialogue = new OpenFileDialog();
            directoryFileDialogue.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            directoryFileDialogue.RestoreDirectory = true;
            directoryFileDialogue.Filter = "Directory (*.dir)| *.dir";
            if (directoryFileDialogue.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (directoryFileDialogue.OpenFile() != null)
                    {
                        XmlDocument newDocument;
                        FileStream reader = new FileStream(directoryFileDialogue.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                        using (reader)
                        {
                            newDocument = new XmlDocument();
                            newDocument.Load(reader);

                            DateTime_Label.Text = "These settings saved on: " + newDocument.GetElementsByTagName("DateTime")[0].InnerText;

                            XmlNodeList categories = newDocument.GetElementsByTagName("Directory");
                            NewFolder_TextBox.Text = categories[0].InnerText;
                            ReferenceFolder_TextBox.Text = categories[1].InnerText;
                            XmlDiffFolder_TextBox.Text = categories[2].InnerText;
                        }
                        reader.Close();
                        reader.Dispose();
                        Console.WriteLine("Directories loaded");
                    }
                    directoryFileDialogue.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read selected file. Original error message:" + ex.Message);
                    Console.WriteLine("Error: Could not read selected file. Original error message:" + ex.Message);
                }
            }
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialogue = new OpenFileDialog();
            if (fileDialogue.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialogue.FileName;
                string fileName = Path.GetFileName(filePath);
                filePath = filePath.Replace("\\" + Path.GetFileName(filePath), string.Empty);

                if (fileName.Contains(Configuration.DiffFileExtension))
                    fileName = fileName.Replace(Configuration.DiffFileExtension, string.Empty);

                if (fileName.Contains(Configuration.MasterToken))
                    fileName = fileName.Replace(Configuration.MasterToken, string.Empty);
                else if (fileName.Contains(Configuration.SummaryToken))
                    fileName = fileName.Replace(Configuration.SummaryToken, string.Empty);

                Console.WriteLine("Results loaded");

                resultBrowser = new ResultForm(filePath, fileName);
                resultBrowser.ShowDialog();
            }
        }

        private void setTips()
        {
            ToolTip compareTip = new ToolTip();
            compareTip.SetToolTip(Compare_Button, "Compare");

            ToolTip saveTip = new ToolTip();
            saveTip.SetToolTip(Save_Button, "Save Directories");

            ToolTip browseTip = new ToolTip();
            browseTip.SetToolTip(Browse_Button, "Browse for a directories file");

            ToolTip openTip = new ToolTip();
            openTip.SetToolTip(Open_Button, "Open a saved comparison");

            ToolTip newTip = new ToolTip();
            newTip.SetToolTip(NewFolder_Button, "Browse to select the New directory");

            ToolTip referenceTip = new ToolTip();
            referenceTip.SetToolTip(ReferenceFolder_Button, "Browse to select the Reference directory");

            ToolTip diffTip = new ToolTip();
            diffTip.SetToolTip(XmlDiffFolder_Button, "Browse to select the Diff directory");

            ToolTip diffOptionsTip = new ToolTip();
            diffOptionsTip.SetToolTip(DiffOptions_Button, "Set XML Diff options");

            ToolTip appConfigTip = new ToolTip();
            appConfigTip.SetToolTip(AppConfig_Button, "Set App Configurations");
        }

        private void XPath_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExcludeNodes_CheckBox.Checked)
                XPath_TextBox.Enabled = true;
            else
            {
                XPath_TextBox.Enabled = false;
                XPath_TextBox.Text = "";
            }
        }

        private void DiffOptions_Button_Click(object sender, EventArgs e)
        {
            DiffOptionsForm optionsForm = new DiffOptionsForm();
            optionsForm.ShowDialog();
        }

        private void AppConfig_Button_Click(object sender, EventArgs e)
        {
            AppConfigForm appConfigForm = new AppConfigForm();
            appConfigForm.ShowDialog();
        }
    }
}
