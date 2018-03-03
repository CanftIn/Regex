using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    abstract class MatchManyBase : IMatch
    {
        public readonly IMatch[] matchList;
        public int Length => matchList.Length;

        public MatchManyBase(IMatch[] matchList)
        {
            this.matchList = matchList;
        }


        public abstract bool Match(MatchContext context);

        public abstract bool MatchNext(MatchContext context);
    }
}
