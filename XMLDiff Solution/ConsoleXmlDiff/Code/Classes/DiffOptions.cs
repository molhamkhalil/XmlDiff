using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.XmlDiffPatch;
using System.Xml;
using System.IO;

namespace ConsoleXmlDiff.Code.Classes
{
    public static class DiffOptions
    {
        public static bool IgnoreChildOrder { get; set; }
        public static bool IgnoreComments { get; set; }
        public static bool IgnoreDtd { get; set; }
        public static bool IgnoreNamespaces { get; set; }
        public static bool IgnorePI { get; set; }
        public static bool IgnorePrefixes { get; set; }
        public static bool IgnoreWhitespace { get; set; }
        public static bool IgnoreXmlDecl { get; set; }
        public static bool None { get; set; }

        public static void Get()
        {
            XmlDocument options = new XmlDocument();
            options.Load(@"..\..\..\ConsoleXmlDiff\Configurations\XmlDiffOptions.config");
            XmlNode configurationNode = options.DocumentElement.SelectSingleNode("/configuration/Options");

            IgnoreChildOrder = Convert.ToBoolean(configurationNode.ChildNodes[0].InnerText);
            IgnoreComments = Convert.ToBoolean(configurationNode.ChildNodes[1].InnerText);
            IgnoreDtd = Convert.ToBoolean(configurationNode.ChildNodes[2].InnerText);
            IgnoreNamespaces = Convert.ToBoolean(configurationNode.ChildNodes[3].InnerText);
            IgnorePI = Convert.ToBoolean(configurationNode.ChildNodes[4].InnerText);
            IgnorePrefixes = Convert.ToBoolean(configurationNode.ChildNodes[5].InnerText);
            IgnoreWhitespace = Convert.ToBoolean(configurationNode.ChildNodes[6].InnerText);
            IgnoreXmlDecl = Convert.ToBoolean(configurationNode.ChildNodes[7].InnerText);
            None = Convert.ToBoolean(configurationNode.ChildNodes[8].InnerText);
        }

        internal static XmlDiffOptions Set()
        {
            XmlDiffOptions result = 0;

            if (None)
                result = XmlDiffOptions.None;
            else
            {
                if (IgnoreChildOrder)
                    result |= XmlDiffOptions.IgnoreChildOrder;
                if (IgnoreComments)
                    result |= XmlDiffOptions.IgnoreComments;
                if (IgnoreDtd)
                    result |= XmlDiffOptions.IgnoreDtd;
                if (IgnoreNamespaces)
                    result |= XmlDiffOptions.IgnoreNamespaces;
                if (IgnorePI)
                    result |= XmlDiffOptions.IgnorePI;
                if (IgnorePrefixes)
                    result |= XmlDiffOptions.IgnorePrefixes;
                if (IgnoreWhitespace)
                    result |= XmlDiffOptions.IgnoreWhitespace;
                if (IgnoreXmlDecl)
                    result |= XmlDiffOptions.IgnoreXmlDecl;
            }
            return result;
        }

        public static void Write()
        {
            XmlDocument optionsDocument = new XmlDocument();
            XmlDeclaration xmlDecleration = optionsDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            optionsDocument.AppendChild(xmlDecleration);
            XmlNode optionsRoot = optionsDocument.CreateNode("element", "configuration", "");

            optionsRoot.AppendChild(FillIn(optionsDocument));
            optionsDocument.InsertAfter(optionsRoot, xmlDecleration);

            try
            {
                if (File.Exists(@"..\..\..\ConsoleXmlDiff\Configurations\XmlDiffOptions.config"))
                    File.Delete(@"..\..\..\ConsoleXmlDiff\Configurations\XmlDiffOptions.config");

                optionsDocument.Save(@"..\..\..\ConsoleXmlDiff\Configurations\XmlDiffOptions.config");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static XmlNode FillIn(XmlDocument optionsDocument)
        {
            XmlNode result = optionsDocument.CreateNode("element", "Options", "");
            XmlNode option;
            XmlAttribute name;

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreChildOrder";
            option.Attributes.Append(name);
            option.InnerText = IgnoreChildOrder.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreComments";
            option.Attributes.Append(name);
            option.InnerText = IgnoreComments.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreDtd";
            option.Attributes.Append(name);
            option.InnerText = IgnoreDtd.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreNamespaces";
            option.Attributes.Append(name);
            option.InnerText = IgnoreNamespaces.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnorePI";
            option.Attributes.Append(name);
            option.InnerText = IgnorePI.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnorePrefixes";
            option.Attributes.Append(name);
            option.InnerText = IgnorePrefixes.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreWhitespace";
            option.Attributes.Append(name);
            option.InnerText = IgnoreWhitespace.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "IgnoreXmlDecl";
            option.Attributes.Append(name);
            option.InnerText = IgnoreXmlDecl.ToString().ToLower();
            result.AppendChild(option);

            option = optionsDocument.CreateNode("element", "Option", "");
            name = optionsDocument.CreateAttribute("Name");
            name.Value = "None";
            option.Attributes.Append(name);
            option.InnerText = None.ToString().ToLower();
            result.AppendChild(option);

            return result;
        }
    }
}
