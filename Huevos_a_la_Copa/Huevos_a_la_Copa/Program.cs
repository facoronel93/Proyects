using System;


namespace Huevos_a_la_Copa
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

        static double cargaDatos()
        {
            double temperatura = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine("ingrese temperatura del huevo");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperatura: " + temperatura);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return temperatura;
        }

        static double division()
        {
            double dividendo, divisor,resultado;
            dividendo = (Math.Pow(47, 2.0 / 3.0) * Math.Pow((3.7 * 1.038),( 1.0 / 3.0))); 
            divisor=(0.054 * Math.Pow(Math.PI, 2.0) * Math.Pow(((4 * Math.PI) / 3), 2.0 / 3.0));
            resultado = dividendo / divisor;
            return resultado;
        }
        static double logaritmo(double temperatura)
        {
            double resultado;
            resultado = Math.Log(0.76 * ((temperatura - 100) / (70 - 100)));
            return resultado;
        }
        static void getTiempo(double temperatura)
        {
            double resultadoFinal,formula1,formula2;
            formula1 = division();
            formula2 = logaritmo(temperatura);
            resultadoFinal = division() * logaritmo(temperatura);
            Console.WriteLine("el tiempo necesario es: " + resultadoFinal);
        }

        static void Main()
        {
            bool confirmar;
            double temperatura;
            do
            {
                temperatura = cargaDatos();
                getTiempo(temperatura);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
           
        }
    }
}
