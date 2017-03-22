using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice
{
    class Program
    {
        static double cargaDatos(string datos)
        {
            double numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine($"{datos}");
                    numero = Convert.ToDouble(Console.ReadLine());
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

        static double indiceMasaCorporal(double altura, double peso)
        {
            return altura / Math.Pow(peso, 2);
        }
        static void tipoDeRiesgo()
        {
            
        }

        static void Main(string[] args)
        {
            double altura, peso,edad;
            edad = cargaDatos("ingrese edad");
            altura = cargaDatos("ingrese altura en metros");
            peso = cargaDatos("ingrese peso en kilogramos");

            if (edad >= 45)
            {
                if (indiceMasaCorporal(altura, peso) < 22.0)
                {
                    Console.WriteLine("tipo de riesgo BAJO");
                }
                else
                {
                    Console.WriteLine("tipo de riesgo MEDIO");
                }
            }
            else
            {
                if (indiceMasaCorporal(altura, peso) < 22.0)
                {
                    Console.WriteLine("tipo de riesgo MEDIO");
                }
                else
                {
                    Console.WriteLine("tipo de riesgo ALTO");
                }
            }
            Console.Read(); 
            }


        }
    }

