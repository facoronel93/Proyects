using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escriba un programa que entregue todos los divisores del número entero ingresado:

Ingrese numero: 200
1 2 4 5 8 10 20 25 40 50 100 200*/
namespace Divisores
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
                    { Console.WriteLine("los datos ingresados no son correctos"); };
                }

            } while (string.Compare(confirma, "no") != 0 && string.Compare(confirma, "si") != 0);
            return true;

        }
        static bool asd()
        {

        }
        
        static void showDivisores(int numero)
        {
            int restoDiv;
            Console.WriteLine("divisores: ");
            for (int i = 1; i <= numero; i++) 
            {
                Math.DivRem(numero, i, out restoDiv);
         
                    if (restoDiv == 0)
                    {
                        Console.WriteLine($"{i}");

                    }
            }

            for (int i = 1; i >= numero; i++)
            {
                Math.DivRem(numero, i, out restoDiv);

                if (restoDiv == 0)
                {
                    Console.WriteLine($"{i}");

                }
            }

        }


        public static void Main()
        {

            bool confirmar;
            int numero;
            do
            {

                confirmar = false;
                numero = cargaDatos();
                showDivisores(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);



            Console.ReadKey();

        }
    }
}
