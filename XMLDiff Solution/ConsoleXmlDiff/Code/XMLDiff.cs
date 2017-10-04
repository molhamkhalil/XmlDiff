using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using Microsoft.XmlDiffPatch;
using ConsoleXmlDiff.Code.Classes;
using System.Xml.XPath;

namespace ConsoleXmlDiff.Code
{
    internal class XMLDiff
    {
        private string[] xPaths = null;

        internal XMLDiff(string xPathsString)
        {
            if (xPathsString != null && xPathsString.Length > 1)
            {
                this.xPaths = xPathsString.Split(new string[] { new string(Configuration.Delimiter).Replace("\\n", "\n") }, StringSplitOptions.None);
                Console.WriteLine("Set to remove the following node(s):");
                foreach (string nodeToremove in xPaths)
                {
                    nodeToremove.Trim();
                    Console.WriteLine(nodeToremove);
                }
            }

            ShowDirectoriesDialogues();
        }

        internal XMLDiff(string NewFolder, string referenceFolder, string xmlDiffFolder, string xPathsString)
        {
            if (xPathsString != null && xPathsString.Length > 1)
            {
                this.xPaths = xPathsString.Split(new string[] { new string(Configuration.Delimiter).Replace("\\n", "\n") }, StringSplitOptions.None);
                Console.WriteLine("Set to remove the following node(s):");
                foreach (string nodeToremove in xPaths)
                {
                    nodeToremove.Trim();
                    Console.WriteLine(nodeToremove);
                }
            }

            Configuration.NewDirectory = NewFolder;
            Configuration.ReferenceDirectory = referenceFolder;
            Configuration.DiffDirectory = xmlDiffFolder;
        }

        public void Compare()
        {
            DataStorage.Nullify();
            DataStorage.LoadNewFiles();
            DataStorage.LoadMissedReferenceFiles();
            CompareFiles();
            CreateMasterDiffFile();
            CreateSummaryFile();
            WriteOnConsole();
        }

        private void CompareFiles()
        {
            Console.WriteLine("Comparison began");

            #region variables
            XmlDiff diff = new XmlDiff(DiffOptions.Set());
            XmlWriter diffWriter;
            bool isIdentical;
            string referenceFile, newFile, diffFile;
            #endregion

            #region Comparing
            foreach (string file in DataStorage.NewFiles)
            {
                //excludingNodesLamps[0] = referenceFile
                //excludingNodesLamps[1] = newFile
                bool[] excludingNodesLamps = { false, false };

                #region preparing reference, new, and diff directories
                referenceFile = Path.Combine(Configuration.ReferenceDirectory, file + Configuration.ReferenceToken + Configuration.DiffFileExtension);
                newFile = Path.Combine(Configuration.NewDirectory, file + Configuration.NewToken + Configuration.DiffFileExtension);
                diffFile = Path.Combine(Configuration.DiffDirectory, file + Configuration.DiffToken + Configuration.DiffFileExtension);
                #endregion

                if (DataStorage.MissedReferenceFiles != null && DataStorage.MissedReferenceFiles.Contains(file))
                    continue;
                else
                {
                    if (this.xPaths != null)
                        excludingNodesLamps = ExcludeNodes(ref referenceFile, ref newFile);
                    try
                    {
                        isIdentical = diff.Compare(referenceFile, newFile, false);

                        #region writing diff file if not identical
                        if (!isIdentical)
                        {
                            if (DataStorage.ChangedFiles == null)
                                DataStorage.ChangedFiles = new List<string>();

                            DataStorage.ChangedFiles.Add(file);
                            diffWriter = XmlWriter.Create(diffFile);
                            diff.Compare(referenceFile, newFile, false, diffWriter);
                            diffWriter.Close();
                        }
                        #endregion

                        #region deleting the temp files created during excluding the nodes
                        if (excludingNodesLamps[0])
                            File.Delete(referenceFile);
                        if (excludingNodesLamps[1])
                            File.Delete(newFile);
                        #endregion
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error occurred while comparing:" + referenceFile + " and " + newFile);
                        throw ex;
                    }
                }
            }
            #endregion
        }

        private bool[] ExcludeNodes(ref string referenceFile, ref string newFile)
        {
            bool[] result = { false, false };

            #region variables
            XmlDocument tempReferenceFile = new XmlDocument();
            XmlDocument tempNewFile = new XmlDocument();
            XmlNode tempReferenceRoot, tempNewRoot, nodeToRemoveParent;
            XmlNodeList nodesToRemoveList;
            string tempFileName;
            #endregion

            #region reading the reference file
            try
            {
                tempReferenceFile.Load(referenceFile);
                tempReferenceRoot = tempReferenceFile.DocumentElement;
            }
            catch (IOException ex)
            {
                MessageBox.Show("The programme could not read " + referenceFile);
                throw ex;
            }
            #endregion

            #region reading the new file
            try
            {
                tempNewFile.Load(newFile);
                tempNewRoot = tempNewFile.DocumentElement;
            }
            catch (IOException ex)
            {
                MessageBox.Show("The programme could not read " + newFile);
                throw ex;
            }
            #endregion

            XmlNamespaceManager referenceFileNsmgr = new XmlNamespaceManager(tempReferenceFile.NameTable);
            referenceFileNsmgr.AddNamespace(tempReferenceRoot.GetPrefixOfNamespace(tempReferenceRoot.NamespaceURI), tempReferenceRoot.NamespaceURI);

            XmlNamespaceManager newFileNsmgr = new XmlNamespaceManager(tempNewFile.NameTable);
            newFileNsmgr.AddNamespace(tempNewRoot.GetPrefixOfNamespace(tempNewRoot.NamespaceURI), tempNewRoot.NamespaceURI);

            foreach (XmlNode barn in tempReferenceRoot)
            {
                referenceFileNsmgr.AddNamespace(barn.GetPrefixOfNamespace(barn.NamespaceURI), barn.NamespaceURI);
                if (barn.HasChildNodes)
                    foreach (XmlNode barnbarn in barn)
                        referenceFileNsmgr.AddNamespace(barnbarn.GetPrefixOfNamespace(barnbarn.NamespaceURI), barnbarn.NamespaceURI);
            }

            foreach (XmlNode barn in tempNewRoot)
            {
                newFileNsmgr.AddNamespace(barn.GetPrefixOfNamespace(barn.NamespaceURI), barn.NamespaceURI);
                if (barn.HasChildNodes)
                    foreach (XmlNode barnbarn in barn)
                        newFileNsmgr.AddNamespace(barnbarn.GetPrefixOfNamespace(barnbarn.NamespaceURI), barnbarn.NamespaceURI);
            }

            foreach (string xPath in this.xPaths)
            {
                #region excluding all nodes to remove from the reference file
                nodesToRemoveList = tempReferenceRoot.SelectNodes(xPath, referenceFileNsmgr);
                foreach (XmlNode nodeToRemove in nodesToRemoveList)
                {
                    nodeToRemoveParent = nodeToRemove.ParentNode;
                    nodeToRemoveParent.RemoveChild(nodeToRemove);
                    result[0] = true;
                }
                #endregion

                #region excluding all nodes to remove from the new file
                nodesToRemoveList = tempNewRoot.SelectNodes(xPath, newFileNsmgr);
                foreach (XmlNode nodeToRemove in nodesToRemoveList)
                {
                    nodeToRemoveParent = nodeToRemove.ParentNode;
                    nodeToRemoveParent.RemoveChild(nodeToRemove);
                    result[1] = true;
                }
                #endregion
            }

            #region saving and refreshing the reference and new files.
            try
            {
                tempFileName = Guid.NewGuid().ToString();
                if (result[0])
                {
                    tempReferenceFile.Save(Path.Combine(Configuration.ReferenceDirectory, tempFileName + Configuration.DiffFileExtension));
                    referenceFile = Path.Combine(Configuration.ReferenceDirectory, tempFileName + Configuration.DiffFileExtension);
                }
                if (result[1])
                {
                    tempNewFile.Save(Path.Combine(Configuration.NewDirectory, tempFileName + Configuration.DiffFileExtension));
                    newFile = Path.Combine(Configuration.NewDirectory, tempFileName + Configuration.DiffFileExtension);
                }
                return result;
            }
            catch (IOException ex)
            {
                MessageBox.Show("The programme has encountered an error");
                throw ex;
            }
            #endregion
        }

        private static void CreateMasterDiffFile()
        {
            DataStorage.LoadDiffFiles();

            if (DataStorage.DiffFiles.Length > 0 || DataStorage.MissedReferenceFiles != null)
            {
                #region preparing Xml Decleration, Root node, and TestCases node for the master xml document
                XmlDocument masterDocument = new XmlDocument();
                XmlDeclaration xmlDecleration = masterDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode masterRoot = masterDocument.CreateNode("element", "XmlDiff", "");
                masterDocument.AppendChild(masterRoot);
                masterDocument.InsertBefore(xmlDecleration, masterRoot);
                XmlNode testCases = masterDocument.CreateNode("element", "TestCases", "");
                masterRoot.AppendChild(testCases);
                #endregion

                #region master xml document variables
                string testCaseName = "";
                XmlElement tempTestCase, tempRoot;
                XmlNode newTestCase;
                XmlDocument newDocument;
                #endregion

                #region adding missed reference Files as first test cases to the master xml document
                if (DataStorage.MissedReferenceFiles != null)
                    foreach (string file in DataStorage.MissedReferenceFiles)
                    {
                        tempTestCase = masterDocument.CreateElement("TestCase");
                        tempTestCase.SetAttribute("Name", file);
                        tempTestCase.SetAttribute("Missed", "true");
                        testCases.AppendChild(tempTestCase);
                    }
                #endregion

                #region extracting all nodes from each xmldiff file, adding 2 new attributes, and adding them to the master xml document. ends by deleting the xmldiff file
                foreach (string currentXmlDiffFile in DataStorage.DiffFiles)
                {
                    testCaseName = currentXmlDiffFile;

                    newDocument = new XmlDocument();
                    newDocument.Load(Path.Combine(Configuration.DiffDirectory, currentXmlDiffFile + Configuration.DiffToken + Configuration.DiffFileExtension));

                    tempRoot = newDocument.DocumentElement;
                    tempTestCase = newDocument.CreateElement("TestCase");
                    tempTestCase.SetAttribute("Name", testCaseName);
                    tempTestCase.SetAttribute("Missed", "false");

                    foreach (XmlNode node in tempRoot.ChildNodes)
                        tempTestCase.AppendChild(node.CloneNode(true));

                    tempRoot.ParentNode.ReplaceChild(tempTestCase, tempRoot);
                    newTestCase = masterDocument.ImportNode(tempTestCase, true);
                    testCases.AppendChild(newTestCase);

                    File.Delete(Path.Combine(Configuration.DiffDirectory, currentXmlDiffFile + Configuration.DiffToken + Configuration.DiffFileExtension));
                }
                #endregion

                try
                {
                    masterDocument.Save(Path.Combine(Configuration.DiffDirectory, Configuration.MasterToken + Configuration.DiffFileName + Configuration.DiffFileExtension));
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error occurred while creating the master file to: " + Path.Combine(Configuration.DiffDirectory, Configuration.MasterToken + Configuration.DiffFileName + Configuration.DiffFileExtension));
                    throw ex;
                }
            }
        }

        private static void CreateSummaryFile()
        {
            #region Preparing xmlDecleration and root
            XmlDocument summaryFile = new XmlDocument();
            XmlDeclaration xmlDecleration = summaryFile.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlNode root = summaryFile.CreateNode("element", "DiffSummary", "");
            summaryFile.AppendChild(root);
            summaryFile.InsertBefore(xmlDecleration, root);
            #endregion

            #region adding Information Node
            XmlNode informationNode = summaryFile.CreateNode("element", "Information", "");
            XmlNode dateTimeNode = summaryFile.CreateNode("element", "DateTime", "");
            dateTimeNode.InnerText = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            informationNode.AppendChild(dateTimeNode);
            root.AppendChild(informationNode);
            #endregion

            #region adding the test cases
            XmlNode testCases = summaryFile.CreateNode("element", "TestCases", "");
            XmlNode testCase;
            XmlAttribute name, missed;
            foreach (string file in DataStorage.NewFiles)
            {
                testCase = summaryFile.CreateNode("element", "TestCase", "");
                name = summaryFile.CreateAttribute("Name");
                missed = summaryFile.CreateAttribute("Missed");
                name.Value = file;
                if (DataStorage.MissedReferenceFiles != null && DataStorage.MissedReferenceFiles.Contains(file))
                {
                    missed.Value = "true";
                    testCase.InnerText = "failed";
                }
                else if (DataStorage.ChangedFiles != null && DataStorage.ChangedFiles.Contains(file))
                {
                    missed.Value = "false";
                    testCase.InnerText = "failed";
                }
                else
                {
                    missed.Value = "false";
                    testCase.InnerText = "passed";
                }

                testCase.Attributes.Append(name);
                testCase.Attributes.Append(missed);
                testCases.AppendChild(testCase);
            }
            root.AppendChild(testCases);
            #endregion

            try
            {
                summaryFile.Save(Path.Combine(Configuration.DiffDirectory, Configuration.SummaryToken + Configuration.DiffFileName + Configuration.DiffFileExtension));
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error occurred while creating the summary file to: " + Path.Combine(Configuration.DiffDirectory, Configuration.SummaryToken + Configuration.DiffFileName + Configuration.DiffFileExtension));
                throw ex;
            }
        }

        private void WriteOnConsole()
        {
            string result = "Comaprision dona!\nMaster file has been written to:\n" + Path.Combine(Configuration.DiffDirectory, Configuration.MasterToken + Configuration.DiffFileName + Configuration.DiffFileExtension)
                + "\nSummary file has been written to:\n" + Path.Combine(Configuration.DiffDirectory, Configuration.SummaryToken + Configuration.DiffFileName + Configuration.DiffFileExtension);

            result += "\n------------------------------------------------\n";

            if (DataStorage.MissedReferenceFiles != null && DataStorage.MissedReferenceFiles.Count > 0)
            {
                result += "Some reference files are missed:\n";
                foreach (string file in DataStorage.MissedReferenceFiles)
                    result += "\t" + file + "\n";
            }

            if (DataStorage.ChangedFiles != null && DataStorage.ChangedFiles.Count > 0)
            {
                result += "Difference located in the following file(s):\n";
                foreach (string file in DataStorage.ChangedFiles)
                    result += "\t" + file + "\n";
            }
            else
                result += "The files compared are identical";

            Console.WriteLine(result);
        }

        private void ShowDirectoriesDialogues()
        {
            using (var FolderBrowseDialogue = new FolderBrowserDialog())
            {
                FolderBrowseDialogue.ShowNewFolderButton = true;
                FolderBrowseDialogue.Description = "Choose the Directory of New Files";
                DialogResult result = FolderBrowseDialogue.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
                    Configuration.NewDirectory = FolderBrowseDialogue.SelectedPath;

                FolderBrowseDialogue.Description = "Choose the Directory of Reference Files";
                result = FolderBrowseDialogue.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
                    Configuration.ReferenceDirectory = FolderBrowseDialogue.SelectedPath;

                FolderBrowseDialogue.Description = "Choose a directory to write " + Configuration.DiffFileName + Configuration.DiffFileExtension;
                result = FolderBrowseDialogue.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowseDialogue.SelectedPath))
                    Configuration.DiffDirectory = FolderBrowseDialogue.SelectedPath;
            }
        }
    }
}
