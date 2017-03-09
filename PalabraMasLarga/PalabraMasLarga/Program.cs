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

        static bool confirmaNuevo()
        {

            string confirma = "";
            do
            {
                Console.WriteLine("si desea ingresa otro radio ingrese 'si' de lo contrario 'no'");
                confirma = Console.ReadLine();
                if (string.Compare(confirma, "si") != 0)
                {
                    if (string.Compare(confirma, "no") == 0)
                        return false;
                    else
                    { Console.WriteLine("los datos ingresados no son correctos"); };
                }

            } while (string.Compare(confirma, "no") != 0 && string.Compare(confirma, "si") != 0);
            return true;
        }

        static void Main()
        {
            do
            {
                string palabra1 = string.Empty, palabra2 = string.Empty;
                palabra1 = cargaDatos();
                palabra2 = cargaDatos();
                DiferenciaEntrePalabras(palabra1, palabra2);
            } while (confirmaNuevo());
            
        }
    }
}
