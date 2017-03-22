using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dibujosAsteriscos
{
    class Program
    {
        static void draw(int altura, int ancho)
        {
            for(int i = 1; i <= altura;i++)
            {
                for(int j = 1; j <= ancho; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            draw(4, 4);
            Console.ReadKey();
        }
    }
}
