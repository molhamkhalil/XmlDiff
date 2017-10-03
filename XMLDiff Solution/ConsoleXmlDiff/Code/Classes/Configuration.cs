using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace ConsoleXmlDiff.Code.Classes
{
    public static class Configuration
    {
        public static string NewToken { get; set; }
        public static string ReferenceToken { get; set; }
        public static string DiffToken { get; set; }
        public static string SummaryToken { get; set; }
        public static string MasterToken { get; set; }
        public static string DiffFileName { get; set; }
        public static string DiffFileExtension { get; set; }
        public static char[] Delimiter { get; set; }

        public static string NewDirectory { get; internal set; }
        public static string ReferenceDirectory { get; internal set; }
        public static string DiffDirectory { get; internal set; }

        internal static string TempToken { get { return "_TEMP"; } }
        internal static string SearchPattern { get; private set; }

        public static void Get()
        {
            try
            {
                XmlDocument config = new XmlDocument();
                config.Load(@"..\..\..\ConsoleXmlDiff\Configurations\ApplicationConfiguration.config");
                XmlNode configurationNode = config.DocumentElement.SelectSingleNode("/configuration");

                DiffFileExtension = configurationNode["DiffFileExtension"].InnerText;
                NewToken = configurationNode["NewToken"].InnerText + DiffFileExtension;
                ReferenceToken = configurationNode["ReferenceToken"].InnerText + DiffFileExtension;
                DiffToken = configurationNode["DiffToken"].InnerText + DiffFileExtension;
                SearchPattern = "*" + DiffFileExtension;
                SummaryToken = configurationNode["SummaryToken"].InnerText;
                MasterToken = configurationNode["MasterToken"].InnerText;
                DiffFileName = configurationNode["DiffFileName"].InnerText;
                Delimiter = configurationNode["Separator"].InnerText.ToCharArray();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        public static void Write()
        {
            XmlDocument configDocument = new XmlDocument();
            XmlDeclaration xmlDecleration = configDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            configDocument.AppendChild(xmlDecleration);
            XmlNode configRoot = configDocument.CreateNode("element", "configuration", "");

            XmlNode configNode;
            configNode = configDocument.CreateNode("element", "NewToken", "");
            configNode.InnerText = NewToken;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "ReferenceToken", "");
            configNode.InnerText = ReferenceToken;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "DiffToken", "");
            configNode.InnerText = DiffToken;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "SummaryToken", "");
            configNode.InnerText = SummaryToken;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "MasterToken", "");
            configNode.InnerText = MasterToken;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "DiffFileName", "");
            configNode.InnerText = DiffFileName;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "DiffFileExtension", "");
            configNode.InnerText = DiffFileExtension;
            configRoot.AppendChild(configNode);

            configNode = configDocument.CreateNode("element", "Separator", "");
            configNode.InnerText = new string (Delimiter);
            configRoot.AppendChild(configNode);

            configDocument.InsertAfter(configRoot, xmlDecleration);

            try
            {
                if (File.Exists(@"..\..\..\ConsoleXmlDiff\Configurations\ApplicationConfiguration.config"))
                    File.Delete(@"..\..\..\ConsoleXmlDiff\Configurations\ApplicationConfiguration.config");

                configDocument.Save(@"..\..\..\ConsoleXmlDiff\Configurations\ApplicationConfiguration.config");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
