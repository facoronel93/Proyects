using System;


namespace Que_Nota_Necesito
{

    class Program
    {
        static Double cargaDatos(string text)
        {
            double nota = 0;
            Boolean existeError;

            do
            {
                existeError = false;

                try
                {

                    Console.WriteLine(text);
                    nota = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("nota " + nota);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }

            } while (existeError == true);
            return nota;
        }

        static void getNota(double nota1, double nota2, double notaLab)
        {
            double resParcial;
            resParcial = (((60 - notaLab * 0.3) / 0.7) * 3) - nota1 - nota2;
            Console.WriteLine("nota necesaria: " + resParcial);
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
                    { Console.WriteLine("los datos ingresados no son correctos"); };
                }

            } while (string.Compare(confirma, "no") != 0 && string.Compare(confirma, "si") != 0);
            return true;

        }
        public static void Main()
        {

            bool confirmar;
            double nota1, nota2, notaLab;
            do
            {

                confirmar = false;
                nota1 = cargaDatos("ingrese 1ª nota de certamen");
                nota2 = cargaDatos("ingrese 2ª nota de certamen");
                notaLab = cargaDatos("ingrese nota de laboratorio");
                getNota(nota1, nota2, notaLab);
                confirmar = confirmaNuevo();
            } while (confirmar == true);
        }

    }
}
