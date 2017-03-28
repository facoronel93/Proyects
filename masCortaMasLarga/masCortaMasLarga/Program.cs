using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masCortaMasLarga
{
    class Program
    {
        static string[] cargaArray(int cantidad, string [] palabras)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese palabra");
                palabras[i] = Console.ReadLine();
            }

            return palabras;
        }

        static void getPalabraMaximaMinima(int cantidad, string[] palabras)
        {
            string aux;

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (palabras[i].Length > palabras[j].Length)
                    {
                        aux = palabras[i];
                        palabras[i] = palabras[j];
                        palabras[j] = aux;
                    }
                }
            }
            if (palabras[0].Length == palabras[cantidad - 1].Length)
            {
                Console.WriteLine("las palabras tienen cantidades iguales de letras");
            }
            else
            {
                Console.WriteLine($"palabra mas corta: {palabras[0]}, palabra mas larga: {palabras[cantidad - 1]}");
            }
           
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


        static int cargaDatos(string datos)
        {
            int numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;
                try
                {
                    Console.WriteLine(datos);
                    numero = Convert.ToInt32(Console.ReadLine());
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


        static void Main(string[] args)
        {
            do
            {
                var cantidad = cargaDatos("ingrese cantidad");
                string[] palabras = new string[cantidad];
                getPalabraMaximaMinima(cantidad, cargaArray(cantidad, palabras));

            } while (confirmaNuevo());


           
        }
    }
}
