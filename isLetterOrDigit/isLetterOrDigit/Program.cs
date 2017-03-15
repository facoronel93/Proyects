using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isLetterOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char valor =Convert.ToChar( Console.ReadLine());
            Console.WriteLine(char.IsLetterOrDigit(valor));
            Console.ReadKey();
        }
    }
}
