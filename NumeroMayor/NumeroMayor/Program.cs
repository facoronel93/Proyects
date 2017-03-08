using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escriba un programa que permita determinar el número mayor perteneciente a un conjunto de n números,
//donde tanto el valor de n como el de los números deben ser ingresados por el usuario.

//Ingrese n: 4
//Ingrese número: 23
//Ingrese número: -34
//Ingrese número: 0
//Ingrese número: 1
//El mayor es 23

namespace NumeroMayor
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
            } while (existeError);
            return numero;
        }
        static int getNumeroMayor(int[] numeros)
        {
           return numeros.Max();//obtener numero mayor del array
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

        static void Main()
        {
                bool confirmar;
                int cantidad;
                
            do
                {
                    Console.WriteLine("ingrese cantidad de notas");
                    cantidad= Convert.ToInt32(Console.ReadLine());
                    int[] numeros = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    numeros[i] = cargaDatos();
                }
                Console.WriteLine("asd");
                Console.WriteLine($"el numero mayor es: {getNumeroMayor(numeros)}");


                    confirmar = confirmaNuevo();
                } while (confirmar);
            }
    }
}
