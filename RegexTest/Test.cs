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
        static void Main(string[] args)
        {
            var c = new Context("abcde");

            Console.WriteLine(c);

            c.offset = 2;
            Console.WriteLine(c);

        }
    }
}
