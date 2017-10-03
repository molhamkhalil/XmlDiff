using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleXmlDiff.Code.Classes;

namespace ConsoleXmlDiff.Code
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                DiffOptions.Get();
                Configuration.Get();
                XMLDiff diff;

                if (args == null || args.Length == 0)
                    diff = new XMLDiff(null);
                else if (args.Length == 1)
                    diff = new XMLDiff(args[0]);
                else if (args.Length == 3)
                    diff = new XMLDiff(args[0], args[1], args[2], null);
                else
                    diff = new XMLDiff(args[0], args[1], args[2], args[3]);

                diff.Compare();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
