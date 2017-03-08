using System;

namespace conversion
{
    class Program
    {
        /* Escriba un programa que convierta de centímetros a pulgadas. Una pulgada es igual a 2.54 centímetros.

Ingrese longitud: 45
45 cm = 17.7165 in
*/
        static double cargaDatos()
        {
            double numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine("ingrese valor en cm");
                    numero = Convert.ToDouble(Console.ReadLine());
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

        static void devolverConvertido(double numero)
        {
            double resultado;
            resultado= numero / 2.54;
            Console.WriteLine("{0} cm = {1} in", numero, resultado);

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


        static void Main()
        {
            double numero;
            bool confirmar;
            do
            {
                numero = cargaDatos();
                devolverConvertido(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);




        }
    }
}
