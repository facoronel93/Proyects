using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaDeCollatz
{
    class Program
    {
        static void secuencia(int numero,int nroEjercicio)
        {
           
            int result;
            string datosEnPantalla;
            if (nroEjercicio == 1)
            {
                datosEnPantalla = Convert.ToString(numero);
            }
            else
            {
                datosEnPantalla = "*";
            }
            do
            {
                Math.DivRem(numero, 2, out result);
                if (result == 0)
                {
                    numero = numero / 2;
                    Console.WriteLine(datosEnPantalla);
                }
                else
                {
                    numero = (numero * 3) + 1;
                    Console.WriteLine(datosEnPantalla);
                };
            } while (numero != 1);           
        }

        static void secuenciaDeCaracteres(int numero,int ejercicio)
        {
            for(int i = 1; 1 <= numero; i++)
            {
                secuencia(numero, ejercicio);
            }

        }


        static void Main(string[] args)
        {
            int numero,ejercicio;
            Console.WriteLine("ejercicio 1 o 2");
            ejercicio= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero");
            numero =Convert.ToInt32(Console.ReadLine());
            if (ejercicio == 1)
            {
                secuencia(numero, ejercicio);
            }
            else
            {
                secuenciaDeCaracteres(numero, ejercicio);
            }
            Console.ReadKey();
        }
    }
}
