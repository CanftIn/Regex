using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Regex
{
    public class MatchChar : IMatch
    {
        public readonly char matchChar;

        public MatchChar(char c)
        {
            this.matchChar = c;
        }

        public bool Match(MatchContext context)
        {
            if (context.offset >= context.length) return false;
            bool result = (context.curr == matchChar);
            if (result) context.offset++;
            return result;
        }

        public bool MatchNext(MatchContext context)
        {
            context.offset++;
            return false;
        }
    }
}
