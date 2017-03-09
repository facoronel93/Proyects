using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraMasLarga
{
    class Program
    {
        static void cargaDatos(string palabra1, string palabra2)
        {
            
            Console.WriteLine("ingrese palabra 1");
            palabra1 = Console.ReadLine();
            Console.WriteLine("ingrese palabra 2");
            palabra2 = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string palabra1=null, palabra2=null;
            cargaDatos(palabra1, palabra2);
        }
    }
}
