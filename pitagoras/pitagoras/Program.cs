using System;


namespace pitagoras
{
    class Program
    {
        static double cargaDatos()
        {
            double cateto = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine("ingrese cateto");
                    cateto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("numero: " + cateto);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return cateto;
        }

        static void getResultadoPitagoras(double cateto1, double cateto2 )
        {
            double resultado;
            resultado = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
            Console.WriteLine("el resultado es:" + resultado);

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
            double cateto1,cateto2;
            bool confirmar;
            do
            {
                cateto1 = cargaDatos();
                cateto2 = cargaDatos();
                getResultadoPitagoras(cateto1, cateto2);
                confirmar = confirmaNuevo();
            } while (confirmar == true);

        }
  
    }
}
