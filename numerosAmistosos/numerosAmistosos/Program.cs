using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosAmistosos
{
    
    class Program
    {
        static int getSumaDivisores(int numero)
        {
            int resto,sumaDivisores=0;

            for (int i = 1; i < numero; i++)
            {
                Math.DivRem(numero, i, out resto);
                if (resto == 0)
                {
                    sumaDivisores = sumaDivisores + i;
                }

            }
            return sumaDivisores;
        }

        static void getNumerosAmistosos()
        {
            int suma1, suma2;
            for (int i = 1; i < 1000; i++)
             {
                suma1 = getSumaDivisores(i);
                suma2 = getSumaDivisores(suma1);
                   if(i == suma2 && i!= suma1)
                      {
                          Console.WriteLine($"Numeros Amistosos: {i}, {suma1}");
                      }
             }

        }

        static void Main(string[] args)
        {
            getNumerosAmistosos();
            Console.ReadKey();
        }
    }
}
