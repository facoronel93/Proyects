using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Program
    {
        static int cargaDatos()
        {
            int numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {
                    Console.WriteLine("ingrese numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("numero: " + numero);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return numero;
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
                    {
                        Console.WriteLine("los datos ingresados no son correctos");
                    };
                }

            } while (string.Compare(confirma, "no") != 0 && string.Compare(confirma, "si") != 0);
            return true;
        }
        static void ordenarNumeros(int cantidad)
        {
            int [] numeros = new int[cantidad];
            for (int i=0;i<cantidad; i++)
            {
                numeros[i] = cargaDatos();
            }
             Array.Sort(numeros, (x, y) => y.CompareTo(x));
            // var shorted =numeros.OrderBy(i => i);
            Console.WriteLine("numeros ordenados: ");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(+numeros[i]);
            }
        }

        static void Main()
        {
            int cantidad;
            double nota;
            do
            {
                Console.WriteLine("ingrese cantidad de numeros");
                cantidad = Convert.ToInt32(Console.ReadLine());
                ordenarNumeros(cantidad);
              
            } while (confirmaNuevo());
        }
    }
}
