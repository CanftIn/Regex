using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class MatchList : MatchManyBase
    {
        public MatchList(IMatch[] matchList) : base(matchList) { }

        public override bool Match(MatchContext context)
        {
            int index = 0;

            while(index < Length)
            {
                if(matchList[index].Match(context))
                {
                    index++;
                }
                else
                {
                    index--;
                    while (index >= 0 && matchList[index].MatchNext(context))
                        index--;
                    if (index < 0)
                        return false;
                    index++;
                }
            }
            return true;
        }

        public override bool MatchNext(MatchContext context)
        {
            int index = Length - 1;
            while (index >= 0 && !matchList[index].MatchNext(context))
                index--;
            if (index < 0) return false;
            index++;
            return true;
        }
    }
}
