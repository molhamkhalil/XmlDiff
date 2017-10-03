using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualXmlDiff.Classes
{
    internal class Summary
    {
        internal string DateTime { get; set; }
        internal TestCase[] TestCases { get; set; }

        internal Summary(int testCasesCount)
        {
            TestCases = new TestCase[testCasesCount];
        }
    }
}
