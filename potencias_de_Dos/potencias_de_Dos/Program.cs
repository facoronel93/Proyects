using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencias_de_Dos
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

        static void devolverMultiplos(int numero)
        {
            double resultado = 0;
            for (int i = 1; i < numero+1; i++)
            {
               resultado = Math.Pow( 2 , Convert.ToDouble(i)) ;
                Console.WriteLine(+ Math.Truncate(resultado));
            }
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
                int numero;
                bool confirmar;
                do
                {
                    numero = cargaDatos();
                    devolverMultiplos(numero);
                    confirmar = confirmaNuevo();
                } while (confirmar == true);
         }
    }
}
