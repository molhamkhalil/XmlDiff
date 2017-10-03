using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VisualXmlDiff.Classes
{
    internal class Directoris : IDisposable
    {
        private XmlDocument xmlFile;
        private XmlDeclaration xmlDecleration;
        private XmlNode root;
        private XmlNode dateTime;
        private XmlNode newDirectory;
        private XmlNode referenceDirectory;
        private XmlNode diffDirectory;

        internal Directoris(string newDirectory, string referenceDirectory, string diffDirectory)
        {
            xmlFile = new XmlDocument();
            xmlDecleration = xmlFile.CreateXmlDeclaration("1.0", "UTF-8", null);
            root = xmlFile.CreateNode("element", "Directories", "");
            xmlFile.AppendChild(root);
            xmlFile.InsertBefore(xmlDecleration, root);

            XmlNode information = xmlFile.CreateNode("element", "Information", "");
            this.dateTime = xmlFile.CreateNode("element", "DateTime", "");
            this.dateTime.InnerText = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            information.AppendChild(this.dateTime);
            root.AppendChild(information);

            this.newDirectory = xmlFile.CreateNode("element", "Directory", "");
            XmlAttribute attribute = xmlFile.CreateAttribute("Name");
            attribute.Value = "Out";
            this.newDirectory.Attributes.Append(attribute);
            this.newDirectory.InnerText = newDirectory;

            this.referenceDirectory = xmlFile.CreateNode("element", "Directory", "");
            attribute = xmlFile.CreateAttribute("Name");
            attribute.Value = "Ok";
            this.referenceDirectory.Attributes.Append(attribute);
            this.referenceDirectory.InnerText = referenceDirectory;

            this.diffDirectory = xmlFile.CreateNode("element", "Directory", "");
            attribute = xmlFile.CreateAttribute("Name");
            attribute.Value = "Diff";
            this.diffDirectory.Attributes.Append(attribute);
            this.diffDirectory.InnerText = diffDirectory;

            root.AppendChild(this.newDirectory);
            root.AppendChild(this.referenceDirectory);
            root.AppendChild(this.diffDirectory);
        }

        internal void Save(string path)
        {
            xmlFile.Save(path);
        }

        public void Dispose() { }
    }
}
