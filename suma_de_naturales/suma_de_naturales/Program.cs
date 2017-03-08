using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_Multiplos
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

        static void devolverNoMultiplos(int numero)
        {
            int suma1=0,suma2=0;


            for (int i = 1; i < numero + 1; i++)
            {
                suma1 = suma1 + i;
            }
            Console.WriteLine("s1 = "+suma1);

            suma2 = ((numero * (numero + 1)) / 2);
            Console.WriteLine("s2 = " + suma2);
            if (suma1 == suma2)
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("no son iguales");
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
                devolverNoMultiplos(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
        }
    }
}

