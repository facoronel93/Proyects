using System;
/*
Primera nota: 55
Segunda nota: 71
Tercera nota: 46
Cuarta nota: 87
El promedio es: 64.75
    */

class promedio
{
    static double resultado(int cantidad)
    {

        double result;
        double num = 0;
        double x=0;
        string [] array = new string[cantidad];

        for(int i=0;i < cantidad; i++)
        {
            Console.WriteLine("ingrese {0}° valor", i+1);
            array[i] = Console.ReadLine();
            x = x + double.Parse(array[i]);
            num++;
        };
        result = x / num;
        return result;
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


    public static void Main()
    {
        bool confirmar;
        string cantidad;
        double nota;
        do
        {
            Console.WriteLine("ingrese cantidad de notas");
            cantidad = Console.ReadLine();
            nota = resultado(Int32.Parse(cantidad));
            Console.WriteLine("el primedio de las notas es: " + nota);
            confirmar = confirmaNuevo();
        } while (confirmar == true);
        
   


    }
}