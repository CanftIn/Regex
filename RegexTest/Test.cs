using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Regex;

namespace RegexTest
{
    class Test
    {
        public static void MatchChar_MatchSingleCharacter()
        {
            var context = new MatchContext("aaa");
            var item = new MatchChar('a');

            Console.WriteLine(context);

            while(item.Match(context))
            {
                Console.WriteLine("match success");
                Console.WriteLine(context);
            };
            Console.WriteLine("match over");
        }

        static void Main(string[] args)
        {
            MatchChar_MatchSingleCharacter();

            Console.ReadKey();

        }
    }
}
