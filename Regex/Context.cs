using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public class Context
    {
        public readonly string matchString;
        public int offset = 0;

        public Context(string matchString)
        {
            this.matchString = matchString;
        }

        public int length => matchString.Length;

        public override string ToString()
        {
            string str = matchString + '\n' + (new string('-', offset)) + '^';
            return str;
        }

    }
}
