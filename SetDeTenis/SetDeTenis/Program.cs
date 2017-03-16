using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetDeTenis
{
    class Program
    {

        static void showSolution(int jugadorA, int jugadorB, string jugador)
        {
            if (jugadorA == 6 && jugadorB <= 4)
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
                    if (jugadorA == 7 && jugadorB == 5)
                    {
                        Console.WriteLine($"gano {jugador}");
                    }
                    else
                    {
                        if (jugadorA < 6 && jugadorB < 6)
                        {
                            Console.WriteLine("aun no termina");
                        }
                        else
                        {
                            if (jugadorA == 7 && jugadorB < 5)
                            {
                                Console.WriteLine("datos invalidos");
                            }
                        }
                    }
                }
            }
        }

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
                Console.WriteLine("si desea volver a ingresar datos, ingrese 'si' de lo contrario 'no'");
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


        static void Main(string[] args)
        {
            int jugadorA, jugadorB;
            string jugador;
            do
            {
                jugadorA = cargaDatos();
                jugadorB = cargaDatos();

                if (jugadorA >= jugadorB)
                {
                    jugador = "A";
                    showSolution(jugadorA, jugadorB, jugador);

                }
                else
                {
                    jugador = "B";
                    showSolution(jugadorB, jugadorA, jugador);
                }

            } while (confirmaNuevo());
        }
    }
}
