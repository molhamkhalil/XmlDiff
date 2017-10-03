using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using ConsoleXmlDiff.Code.Classes;
using VisualXmlDiff.Classes;

namespace VisualXmlDiff.Forms
{
    public partial class ResultForm : Form
    {
        private string fileName, filePath;
        public ResultForm(string filePath, string filename)
        {
            InitializeComponent();
            this.fileName = filename;
            this.filePath = filePath;
        }

        private void Details_TabPage_Enter(object sender, EventArgs e)
        {
            Result_Browser.Navigate(Path.Combine(filePath, Configuration.MasterToken + fileName + Configuration.DiffFileExtension));
        }

        private void Summary_TabPage_Enter(object sender, EventArgs e)
        {
            if (Summary_GridView.Rows.Count != 0)
                Summary_GridView.Rows.Clear();

            Image passedImage = Image.FromFile(@"..\..\Resources\StatusAnnotations_Complete_and_ok_32xLG_color.png");
            Image failedImage = Image.FromFile(@"..\..\Resources\StatusAnnotations_Critical_32xLG_color.png");

            Summary dataSource = readSummaryData(Path.Combine(filePath, Configuration.SummaryToken + fileName + Configuration.DiffFileExtension));
            SummaryDataTime_Label.Text = "These results created on: " + dataSource.DateTime;

            foreach (TestCase testCase in dataSource.TestCases)
            {
                if (testCase.Passed)
                    Summary_GridView.Rows.Add(testCase.Name, passedImage, string.Empty);
                else
                    Summary_GridView.Rows.Add(testCase.Name, failedImage, testCase.Missed.ToString());
            }
        }

        private Summary readSummaryData(string path)
        {
            XmlDocument summaryDocument = new XmlDocument();
            summaryDocument.Load(path);

            XmlNodeList testCases = summaryDocument.GetElementsByTagName("TestCase");
            Summary result = new Summary(testCases.Count);
            result.DateTime = summaryDocument.GetElementsByTagName("DateTime")[0].InnerText;

            for (int i = 0; i < testCases.Count; i++)
            {
                result.TestCases[i] = new TestCase();
                result.TestCases[i].Name = testCases[i].Attributes["Name"].Value;
                result.TestCases[i].Passed = (testCases[i].InnerText) == "passed" ? true : false;
                result.TestCases[i].Missed = Convert.ToBoolean(testCases[i].Attributes["Missed"].Value);
            }
            return result;
        }
    }
}
