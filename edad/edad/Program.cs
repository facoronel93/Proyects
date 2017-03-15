using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad
{
   
    class Program
    {
        static int cargaDatos(string a)
        {
            Console.WriteLine(a);
            return Convert.ToInt32(Console.ReadLine());
        }
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
        static void Main(string[] args)
        {

            DateTime fecha = new DateTime(cargaDatos("ingrese año"), cargaDatos("ingrese mes"), cargaDatos("ingrese dia"));
            var timeToday = DateTime.Today;
            showAge(timeToday, fecha);
          


            Console.Read(); 

        }
    }
}
