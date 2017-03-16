using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad
{
   
    class Program
    {
   
        static void showAge(DateTime timeToday,DateTime fecha)
        {
            if (timeToday.Month == fecha.Month)
            {
                if (timeToday.Day == fecha.Day)
                    Console.WriteLine($"edad: {timeToday.Year - fecha.Year}");
                else
                    if (timeToday.Day > fecha.Day)
                {
                    Console.WriteLine($"edad: {timeToday.Year - fecha.Year}");
                }
                else
                {
                    Console.WriteLine($"edad: {timeToday.Year - 1 - fecha.Year}");
                }
            }

            else
            {
                if (timeToday.Month > fecha.Month)
                {
                    Console.WriteLine($"edad: {timeToday.Year - fecha.Year}");
                }
                else
                {
                    Console.WriteLine($"edad: {timeToday.Year - 1 - fecha.Year}");
                }

            }
        }


        static int cargaDatos(string a)
        {
            int numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine(a);
                    numero = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("si desea volver a ingresar datos, ingrese 'si' de lo contrario 'no'");
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


        static void Main(string[] args)
        {
            do
            {
                DateTime fecha = new DateTime(cargaDatos("ingrese año"), cargaDatos("ingrese mes"), cargaDatos("ingrese dia"));
                var timeToday = DateTime.Today;
                showAge(timeToday, fecha);
            } while (confirmaNuevo());
        }
    }
}
