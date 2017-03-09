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
        static void showDiferenciaEntrePalabras(string palabra1, string palabra2)
        {
            int diferencia;
            diferencia = (palabra1.Length - palabra2.Length);
            if(palabra1.Length > palabra2.Length)
            {
                Console.WriteLine($"la palabra {palabra1} tiene {diferencia} letras mas que {palabra2}");
            }
            else
                Console.WriteLine($"la palabra {palabra2} tiene {diferencia} letras mas que {palabra1}");
        }
        static void Main(string[] args)
        {
            string palabra1=null, palabra2=null;
            cargaDatos(palabra1, palabra2);
            showDiferenciaEntrePalabras(palabra1, palabra2);
            Console.ReadKey();
        }
    }
}
