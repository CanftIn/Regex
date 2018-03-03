using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    interface IMatch
    {
        bool Match(MatchContext context);
        bool MatchNext(MatchContext context);
    }
}
