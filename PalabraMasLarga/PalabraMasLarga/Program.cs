using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraMasLarga
{
    class Program
    {
        static string cargaDatos()
        {
            Console.WriteLine("ingrese palabra");
            string palabra = Console.ReadLine();
            Console.WriteLine("palabra:" + palabra);
            return palabra;
           
        }
        static void showDiferenciaEntrePalabras(string palabraMayor,string palabraMenor)
        {
            int diferencia=0;
            diferencia = ((palabraMayor.Length) - (palabraMenor.Length));
            Console.WriteLine($"la palabra {palabraMayor} tiene {diferencia} letras mas que {palabraMenor}");
            
        }
        static void DiferenciaEntrePalabras(string palabra1, string palabra2)
        { 
            if (palabra1.Length > palabra2.Length)
            {
                showDiferenciaEntrePalabras(palabra1, palabra2);
            }
            else
                showDiferenciaEntrePalabras(palabra2, palabra1);
        }
        static void Main()
        {
            string palabra1=string.Empty, palabra2=string.Empty;
            palabra1 = cargaDatos();
            palabra2 = cargaDatos();
            DiferenciaEntrePalabras(palabra1, palabra2);
            Console.ReadKey();
        }
    }
}
