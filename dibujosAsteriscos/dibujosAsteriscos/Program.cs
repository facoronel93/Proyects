using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dibujosAsteriscos
{
    class Program
    {
        static void draw(int altura, int ancho)
        {
            for(int i = 1; i <= altura;i++)
            {
                for(int j = 1; j <= ancho; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void altura(int altura)
        {
            for(int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }


        static void exagono(int lado)
        {
            //  int contador = 0, contadorIzquierda = 4, contadorDerecha = 7;
            int contador = 4, contadorIzquierda = lado, contadorDerecha = lado*2;

            //  for (int i = 1; i <= 7; i++)
            for (int i = 1; i <= (lado*2)-1; i++)
            {
                contador++;
                for (int j = 1; j <= lado*3; j++)
                {

                    if (j >= contadorIzquierda && j <= contadorDerecha)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }

                if (i < lado)
                {
                    contadorIzquierda--;
                    contadorDerecha++;
                    Console.WriteLine();
                }
                else
                {
                    contadorIzquierda++;
                    contadorDerecha--;
                    Console.WriteLine();
                }
            }
        }

        static int cargaDatos(string datos)
        {
            int numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;
                try
                {
                    Console.WriteLine(datos);
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dato Ingresado: "+numero);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }
            } while (existeError);
            return numero;
        }


        static bool confirmaNuevo()
        {

            string confirma = "";
            do
            {
                Console.WriteLine("si desea ingresa otro numero ingrese 'si' de lo contrario 'no'");
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
            do
            {
                Console.WriteLine("ingrese 1 para dibujo con altura y ancho, 2 altura,3 exagono");
                switch (cargaDatos("ingrese opcion"))
                {
                    case 1:
                        draw(cargaDatos("ingrese altura"),cargaDatos("ingrese ancho"));
                        break;
                    case 2:
                        altura(cargaDatos("ingrese altura"));
                        break;
                    case 3:
                        exagono(cargaDatos("ingrese lado"));
                        break;
                    default:
                        Console.WriteLine("numero invalido");
                        break;
                }
            } while (confirmaNuevo());

        }
    }
}
