using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public static class MatchTest
    {
        public static void MatchChar_MatchSingleCharacter()
        {
            var context = new MatchContext("aaa");
            var item = new MatchChar('a');

            Console.WriteLine(context);

            while (item.Match(context))
            {
                Console.WriteLine("match success");
                Console.WriteLine(context);
            };
            Console.WriteLine("match over");
        }

        public static void MatchListTest1()
        {
            var context = new MatchContext("abc");
            var list = new MatchList(
                new[]
                {
                    new MatchChar('a'),
                    new MatchChar('b'),
                    new MatchChar('c')
                });
            Console.WriteLine(context);

            if (list.Match(context))
            {
                Console.WriteLine("Match Success");
            }
            else
            {
                Console.WriteLine("Match Failed");
            }

            Console.WriteLine(context);
        }

    }
}
