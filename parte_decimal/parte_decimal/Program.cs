using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ingrese un numero: 4.5
0.5
Ingrese un numero: -1.19
0.19

    double cat1, cat2;
            double resultado;
            cat1= Convert.ToInt32(Console.WriteLine("ingrese 1º cateto"));
*/

namespace parte_decimal
{
    class Program
    {
        static double cargaDatos()
        {
            double numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine("ingrese numero");
                    numero = Convert.ToDouble(Console.ReadLine());
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

        static void calcula(double numero)
        {
            double entero;
            entero = Math.Truncate(numero);
            numero = numero - entero;
            Console.WriteLine("resultado: {0} ", Math.Abs(numero));
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
            double numero;
            bool confirmar;
            do
            {
                numero = cargaDatos();
                calcula(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);




        }
       
        
    }
}
