using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetDeTenis
{
    class Program
    {
        static void showSolution(int jugadorA, int jugadorB,string jugador)
        {
            if(jugadorA==6 && jugadorB <= 4)
            {
                Console.WriteLine($"Ganó {jugador}");
            }
            else
            {
                if (jugadorA == 6 && jugadorB == 5)
                    {
                    Console.WriteLine("aun no termina");
                }
                else
                {
                    if(jugadorA==7 && jugadorB == 5)
                    {
                        Console.WriteLine($"gano {jugador}");
                    }
                    else
                    {
                        if (jugadorA < 6 && jugadorB < 6)
                        {
                            Console.WriteLine("aun no termina");
                        }
                    }
                }
            }
        }

        

        static void Main(string[] args)
        {
            int jugadorA, jugadorB;
            string jugador;
            jugadorA = Convert.ToInt32(Console.ReadLine());
            jugadorB = Convert.ToInt32(Console.ReadLine());

            if (jugadorA>= jugadorB)
            {
                jugador = "A";
                showSolution(jugadorA, jugadorB,jugador);
                
            }
            else
            {
                jugador = "B";
                showSolution(jugadorB, jugadorA,jugador);
            }

            Console.ReadKey();
        }
    }
}
