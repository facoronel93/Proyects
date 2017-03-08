using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ingrese un número: 4
Su número es par
Ingrese un número: 3
Su número es impar
*/

namespace DeterminarPar
{
    class Program
    {
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

        static int cargaNumero()
        {
            bool existeError;
            int numero=0;

            do
            {
                existeError = false;

                try
                {
                    Console.WriteLine("ingrese un numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception )
                {
                    Console.WriteLine("error al ingresar los datos, debe ser un numero entero");
                    existeError = true;
                }
            } while (existeError == true);

            return numero;
        }

        static void getTipoNumero(int numero)
        {
            int remainder=0;
                Math.DivRem(numero, 2, out remainder);
          
            if (remainder == 0)
                Console.WriteLine("el numero es par");
            else
                Console.WriteLine("el numero es impar");
        }
        static void Main(string[] args)
        {
            int numero;
            bool confirmar;
            do
            {
                numero = cargaNumero();
                getTipoNumero(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
          
        }
    }
}
