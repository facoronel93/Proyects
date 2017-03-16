using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cachipun
{
   
    class Program
    {
        static string cargaDatos()
        {
            string jugada;
            bool verifica;
            do
            {
                verifica = false;
                jugada = Console.ReadLine();
                if (jugada != "piedra" && jugada != "papel" && jugada != "tijera")
                {
                    Console.WriteLine("Datos Incorrectos");
                    verifica = true;

                }
            } while (verifica);
            return jugada; 
        
        }

        public static string getWinner(string jugadorA, string jugadorB, string gana)
        {
            if (jugadorA.Equals(jugadorB))
            {
                return "empate";
            }
            else
            {
                if (jugadorB == gana)
                {
                    return "jugadorB";
                }
                else
                    return "jugadorA";
            }
        }

        static void Main()
        {
            string jugadorA=string.Empty, jugadorB=string.Empty, ganador=string.Empty;
            int puntosA = 0, puntosB = 0;
            
           
            do
            {
                Console.WriteLine("jugador 1 ingrese piedra papel o tijera");
                jugadorA = cargaDatos(); 
                Console.WriteLine("Jugador 2 ingrese piedra papel o tijera");
                jugadorB = cargaDatos();

                switch (jugadorA)
                {
                    case "tijera":
                        ganador = getWinner(jugadorA, jugadorB, "piedra");
                        Console.WriteLine(ganador);
                        break;
                    case "papel":
                        ganador = getWinner(jugadorA, jugadorB, "tijera");
                        Console.WriteLine(ganador);
                        break;
                    case "piedra":
                        ganador = getWinner(jugadorA, jugadorB, "papel");
                        Console.WriteLine(ganador);
                        break;
                }
                //suma de puntos
                if (ganador == "jugadorA")
                {
                    puntosA++;
                    Console.WriteLine($"Puntos A:{puntosA} ");
                }
                else
                    if (ganador == "jugadorB")
                {
                    puntosB++;
                    Console.WriteLine($"puntos B:{puntosB}");
                }
                //validacion de ganador
                if (puntosA == 3)
                {
                    Console.WriteLine("ganador Jugador A");
                }
                if (puntosB == 3)
                {
                    Console.WriteLine("ganador Jugador B");
                }

            } while ((puntosA != 3) || (puntosA != 3));

            Console.ReadLine();
        }
    }
}
