using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCSharpFeatures
{
    internal class RelationalAndTypePatterns
    {
        public static bool IsLetter(char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsNull(object o) =>
            o is null;
    }
}
