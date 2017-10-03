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
    public partial class DiffOptionsForm : Form
    {
        public DiffOptionsForm()
        {
            InitializeComponent();
        }

        private void DiffOptionsForm_Load(object sender, EventArgs e)
        {
            DiffOptions.Get();
            ChildOrder_CheckBox.Checked = DiffOptions.IgnoreChildOrder;
            Comments_CheckBox.Checked = DiffOptions.IgnoreComments;
            Dtd_CheckBox.Checked = DiffOptions.IgnoreDtd;
            Namespaces_CheckBox.Checked = DiffOptions.IgnoreNamespaces;
            Pi_CheckBox.Checked = DiffOptions.IgnorePI;
            Prefixes_CheckBox.Checked = DiffOptions.IgnorePrefixes;
            Whitespace_CheckBox.Checked = DiffOptions.IgnoreWhitespace;
            XmlDecleration_CheckBox.Checked = DiffOptions.IgnoreXmlDecl;
            None_CheckBox.Checked = DiffOptions.None;
        }

        private void DiffOptionsCancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiffOptionsOk_Button_Click(object sender, EventArgs e)
        {
            DiffOptions.IgnoreChildOrder = ChildOrder_CheckBox.Checked;
            DiffOptions.IgnoreComments = Comments_CheckBox.Checked;
            DiffOptions.IgnoreDtd = Dtd_CheckBox.Checked;
            DiffOptions.IgnoreNamespaces = Namespaces_CheckBox.Checked;
            DiffOptions.IgnorePI = Pi_CheckBox.Checked;
            DiffOptions.IgnorePrefixes = Prefixes_CheckBox.Checked;
            DiffOptions.IgnoreWhitespace = Whitespace_CheckBox.Checked;
            DiffOptions.IgnoreXmlDecl = XmlDecleration_CheckBox.Checked;
            DiffOptions.None = None_CheckBox.Checked;
            DiffOptions.Write();
            Console.WriteLine("XML Diff options have been modified");
            this.Close();
        }

        private void None_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (None_CheckBox.Checked)
            {
                ChildOrder_CheckBox.Checked = false;
                Comments_CheckBox.Checked = false;
                Dtd_CheckBox.Checked = false;
                Namespaces_CheckBox.Checked = false;
                Pi_CheckBox.Checked = false;
                Prefixes_CheckBox.Checked = false;
                Whitespace_CheckBox.Checked = false;
                XmlDecleration_CheckBox.Checked = false;
            }
        }

        private void Comments_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Comments_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void ChildOrder_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChildOrder_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void Dtd_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Dtd_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void Namespaces_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Dtd_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void Pi_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Pi_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void Prefixes_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Prefixes_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void Whitespace_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Whitespace_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }

        private void XmlDecleration_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (XmlDecleration_CheckBox.Checked)
                None_CheckBox.Checked = false;
        }
    }
}
