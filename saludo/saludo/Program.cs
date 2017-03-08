using System;


namespace saludo
{
    class Program
    {
        /*Escriba un programa que pida al usuario que escriba su nombre, y lo salude llamándolo por su nombre.

Ingrese su nombre: Perico
Hola, Perico
*/

        static void Main()
        {
            string nombre;
            Console.WriteLine("ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("hola {0}", nombre);
            Console.ReadLine();

        }
    }
}
