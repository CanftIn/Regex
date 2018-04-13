using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public static class MatchTest
    {
        public static void MatchCharTest1()
        {
            var context = new MatchContext("aaa");
            var item = new MatchChar('a');

            ExecTest(item, context);
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

            ExecTest(list, context);
        }

        public static void ExecTest(IMatch token, MatchContext context)
        {
            if (token.Match(context))
            {
                Console.WriteLine("Match Success");
                Console.WriteLine(context);

                while (token.MatchNext(context))
                {
                    Console.WriteLine("MatchNext Success");
                    Console.WriteLine(context);
                }

                Console.WriteLine("MatchNext Failed");
                Console.WriteLine(context);
            }
            else
            {
                Console.WriteLine("Match Failed");
                Console.WriteLine(context);
            }
        }
    }

    
}
