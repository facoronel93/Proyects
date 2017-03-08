using System;


namespace num_invertido
{
    class Program
    {
        static string cargaDatos()
        {
            int numero= 0;
            string numberstring;
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
           numberstring= Convert.ToString(numero);

            return numberstring;
        }

        static void devolverinvertido(string numero)
        {
            char[] charArray = numero.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);       
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
            string numero;
            bool confirmar;
            do
            {
                numero = cargaDatos();
                 devolverinvertido(numero);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
        }

       
    }
}
