using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleXmlDiff.Code.Classes;

namespace VisualXmlDiff.Forms
{
    public partial class AppConfigForm : Form
    {
        public AppConfigForm()
        {
            InitializeComponent();
        }

        private void AppConfigForm_Load(object sender, EventArgs e)
        {
            Configuration.Get();
            NewFilesToken_TextBox.Text = Configuration.NewToken.Replace(Configuration.DiffFileExtension, string.Empty);
            ReferenceFilesToken_TextBox.Text = Configuration.ReferenceToken.Replace(Configuration.DiffFileExtension, string.Empty);
            DiffFilesToken_TextBox.Text = Configuration.DiffToken.Replace(Configuration.DiffFileExtension, string.Empty);
            MasterFileToken_TextBox.Text = Configuration.MasterToken;
            SummaryFileToken_TextBox.Text = Configuration.SummaryToken;
            DiffFileName_TextBox.Text = Configuration.DiffFileName;
            FileExtension_TextBox.Text = Configuration.DiffFileExtension;
            Delimiter_TextBox.Text = new string(Configuration.Delimiter);
        }

        private void AppConfigCancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppConfigOk_Button_Click(object sender, EventArgs e)
        {
            Configuration.NewToken = NewFilesToken_TextBox.Text;
            Configuration.ReferenceToken = ReferenceFilesToken_TextBox.Text;
            Configuration.DiffToken = DiffFilesToken_TextBox.Text;
            Configuration.MasterToken = MasterFileToken_TextBox.Text;
            Configuration.SummaryToken = SummaryFileToken_TextBox.Text;
            Configuration.DiffFileName = DiffFileName_TextBox.Text;
            Configuration.DiffFileExtension = FileExtension_TextBox.Text;
            Configuration.Delimiter = Delimiter_TextBox.Text.ToCharArray();
            Configuration.Write();
            Console.WriteLine("App Configuration have been modified");
            this.Close();
        }
    }
}
