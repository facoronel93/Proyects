using System;
/*
Escriba un programa que reciba como entrada el radio de un círculo y entregue como salida su perímetro y su área:

Ingrese el radio: 5
Perimetro: 31.4
Área: 78.5rtererre
2*pi*radio sacsdf
    */

class circulo
{
    static double cargaDatos()
    {
        double radio = 0;
        Boolean existeError;
      
        do
        {
            existeError = false;

            try
            {

                Console.WriteLine("ingrese radio");
                radio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("radio: " + radio);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);   
                existeError = true;
            }
            
        } while (existeError == true);
        return radio;
    }

    static double getPerimetro(double radio)
    {
        double perimetro = 2 * Math.PI * radio;
        return perimetro;
    }

    static double getArea (double Radio)
    {
        double area = Math.PI * Math.Pow(Radio, 2);
        return area;
    }


    static bool confirmaNuevo()
    {

        string confirma = "" ;
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
        double perimetro, area, radio;
        do
        {

            confirmar = false;
            radio = cargaDatos();
            perimetro = getPerimetro(radio);
            Console.WriteLine("el perimetro es: " + perimetro);
            area = getArea(radio);
            Console.WriteLine("el area es: " + area);
            confirmar = confirmaNuevo();     
        } while ( confirmar == true );



        Console.ReadKey();

    }
}

/*
        do
        {
            try
            {
                Console.WriteLine("si desea ingresa otro radio ingrese 'si' de lo contrario 'no'");
                confirma = Console.ReadLine();
                if (string.Compare(confirma, "si") == 0)

                    confirmar = true;
                else
                {
                    if (string.Compare(confirma, "no") == 0)
                        confirmar = false;
                    else
                        Console.WriteLine("los datos ingresados no son correctos");
                }
            }


            catch (Exception error)
            {
                Console.WriteLine(error.Data);
            }

        } while (string.Compare(confirma, "no") != 0 && string.Compare(confirma, "si") != 0);
        */
