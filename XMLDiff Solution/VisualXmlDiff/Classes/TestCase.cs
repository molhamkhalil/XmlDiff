using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualXmlDiff.Classes
{
    internal class TestCase
    {
        internal string Name { get; set; }
        internal bool Passed { get; set; }
        internal bool Missed { get; set; }

        internal TestCase() { }
    }
}
