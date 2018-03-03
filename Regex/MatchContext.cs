using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public class MatchContext
    {
        public readonly string matchString;
        public int offset = 0;

        public MatchContext(string matchString)
        {
            this.matchString = matchString;
        }

        public char curr => matchString[offset];

        public int length => matchString.Length;

        public override string ToString()
        {
            string str = matchString + '\n' + (new string('-', offset)) + '^';
            return str;
        }

    }
}
