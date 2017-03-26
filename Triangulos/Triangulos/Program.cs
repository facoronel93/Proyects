using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {
        static double cargaDatos()
        {
            double numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {
                    Console.WriteLine("ingrese valor de lado");
                    numero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("valor: " + numero);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return numero;
        }
        static bool confirmarDesigualdadTriangular(double ladoA,double ladoB,double ladoC)
        {
            if (ladoA < (ladoB + ladoC))
            {
                if (ladoB < (ladoA + ladoC))
                {
                    if (ladoC < (ladoA + ladoB))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
                
      }
        static void verificatipoTriangulo(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("es equilatero");
            }
            else
            {
                if (ladoA == ladoB && ladoB != ladoC)
                {
                    Console.WriteLine("es isoceles");
                }
                else
                {
                    if(ladoC==ladoA && ladoC != ladoB)
                    {
                        Console.WriteLine("es isoceles");
                    }
                    else
                    {
                        if(ladoB==ladoC && ladoB != ladoA)
                        {
                            Console.WriteLine("es isoceles");
                        }
                        else
                        {
                            Console.WriteLine("es es escaleno");
                        }
                      
                    }
                }

            }
           
    
        }
        static bool confirmaNuevo()
        {

            string confirma = string.Empty;
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
            double ladoA, ladoB, ladoC;
            do
            {
                ladoA = cargaDatos();
                ladoB = cargaDatos();
                ladoC = cargaDatos();
                if (confirmarDesigualdadTriangular(ladoA, ladoB, ladoC)== true)
                {
                    verificatipoTriangulo(ladoA, ladoB, ladoC);
                }
                else
                {
                    Console.WriteLine("no es un triangulo valido");
                }

            } while (confirmaNuevo());
           
        }
    }
}
