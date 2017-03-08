using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos
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
            int resultado=0;
            for(int i = 1;i <11; i++)
                {
                    resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero,i, resultado);
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
                    { Console.WriteLine("los datos ingresados no son correctos"); };
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
                confirmar=confirmaNuevo();
            } while (confirmar == true);

        }
    }
}
