using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rango
{
    class Program
    {
        static void mostrarRango(double[] numeros)
        {
            Console.WriteLine($"Rango de valores:{numeros.Max() - numeros.Min()}");
        }


        static bool confirmaNuevo()
        {

            string confirma = string.Empty;
            do
            {
                Console.WriteLine("si desea ingresa otro numero ingrese 'si' de lo contrario 'no'");
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


        static double cargaDatos(string datos)
        {
            double numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;
                try
                {
                    Console.WriteLine(datos);
                    numero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dato Ingresado: " + numero);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }
            } while (existeError);
            return numero;
        }
        
        static double[] cargaArray(double[] numeros,int cantidad)
        {
            for(int i = 0; i < cantidad; i++)
            {
                numeros[i] = cargaDatos("ingrese numero: ");
            }
            
            return numeros;
        }

        static void Main(string[] args)
        {
            int cantidad;
            do
            {
                cantidad = Convert.ToInt32(cargaDatos("ingrese cantidad de numeros"));
                double[] numeros = new double[cantidad];
                mostrarRango(cargaArray(numeros, cantidad));
            } while (confirmaNuevo());
           

        }
    }
}
