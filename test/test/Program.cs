using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rob";
            string s2 = s1;
            s2 = "different";
            Console.WriteLine(s1 + " " + s2);            Console.ReadKey();
        }
    }
}
