using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace añosBisiestos
{
    class Program
    {
        static int cargaDatos()
        {
            int año = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine("ingrese año");
                    año = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("año: " + año);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return año;
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

        static void getTipoAño(int año)
        {
            int remainder=0;
            int tipoDivisor;
            if (año > 100)
            {
                Math.DivRem(año, 100, out remainder);
                if (remainder == 0)
                    tipoDivisor = 400;
                else
                    tipoDivisor = 4;
            }
            else
                tipoDivisor = 4;

            Math.DivRem(año, tipoDivisor, out remainder);
            if (remainder == 0)
                Console.WriteLine("Es año bisiesto");
            else
                Console.WriteLine("no es año bisiesto");

        }

      

        static void Main(string[] args)
        {
            int año;
            bool confirmar;
            do
            {
                año = cargaDatos();
                getTipoAño(año);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
           


        }
    }
}
