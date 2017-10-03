using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleXmlDiff.Code.Classes
{
    public static class DataStorage
    {
        internal static string[] NewFiles { get; set; }
        internal static string[] DiffFiles { get; set; }
        internal static List<string> MissedReferenceFiles { get; set; }
        internal static List<string> ChangedFiles { get; set; }

        internal static void LoadNewFiles()
        {
            NewFiles = Directory.GetFiles(Configuration.NewDirectory, Configuration.SearchPattern);
            for (int i = 0; i < NewFiles.Length; i++)
                NewFiles[i] = Path.GetFileName(NewFiles[i]);

            foreach (string file in NewFiles)
                if (!(file.Contains(Configuration.NewToken)))
                    NewFiles = NewFiles.Where(tempfile => tempfile != file).ToArray();

            for (int i = 0; i < NewFiles.Length; i++)
                if (NewFiles[i].Contains(Configuration.NewToken))
                    NewFiles[i] = NewFiles[i].Remove(NewFiles[i].Length - Configuration.NewToken.Length);
        }

        internal static void LoadDiffFiles()
        {
            DiffFiles = Directory.GetFiles(Configuration.DiffDirectory, Configuration.SearchPattern);
            for (int i = 0; i < DiffFiles.Length; i++)
                DiffFiles[i] = Path.GetFileName(DiffFiles[i]);

            foreach (string file in DiffFiles)
                if (!(file.Contains(Configuration.DiffToken)) || file.Contains(Configuration.SummaryToken) || file.Contains(Configuration.MasterToken))
                    DiffFiles = DiffFiles.Where(tempFile => tempFile != file).ToArray();

            for (int i = 0; i < DiffFiles.Length; i++)
                if (DiffFiles[i].Contains(Configuration.DiffToken))
                    DiffFiles[i] = DiffFiles[i].Remove(DiffFiles[i].Length - Configuration.DiffToken.Length);
        }

        internal static void LoadMissedReferenceFiles()
        {
            string referenceFile;
            bool missedReferenceFileFound = false;

            foreach (string file in DataStorage.NewFiles)
            {
                referenceFile = Path.Combine(Configuration.ReferenceDirectory, file + Configuration.ReferenceToken);
                if (!File.Exists(referenceFile))
                {
                    if (!missedReferenceFileFound)
                    {
                        MissedReferenceFiles = new List<string>();
                        missedReferenceFileFound = true;
                    }
                    MissedReferenceFiles.Add(file);
                }
            }
        }

        internal static void Nullify()
        {
            if (NewFiles != null)
                NewFiles = null;

            if (DiffFiles != null)
                DiffFiles = null;

            if (MissedReferenceFiles != null)
                MissedReferenceFiles = null;

            if (ChangedFiles != null)
                ChangedFiles = null;
        }
    }
}
