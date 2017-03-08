using System;

/*
 Hora actual: 11
Cantidad de horas: 43
En 43 horas, el reloj marcara las 6

*/


namespace hora
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

                    Console.WriteLine("ingrese cantidad de horas");
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
            double cantidad;
            DateTime hora;
            bool confirmar;

            do
            {
                hora = DateTime.Now;
                Console.WriteLine("hora actual: " + hora);
                cantidad = cargaDatos();
                hora = hora.AddHours(cantidad);
                Console.WriteLine("la hora es: " + hora);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
   
        }
    }
}
