using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosAmistosos
{
  
    class Program
    {
        static List<int> getSumaDivisores(int numero)
        {
            int resto;
            List<int> divisores = new List<int>();

            for (int i = 0; i <= numero; i++)
            {
                Math.DivRem(numero, i, out resto);
                if (resto == 0)
                {
                    divisores.Add(numero);
                }
            }
            return divisores;
        }

        static void Main(string[] args)
        {
            int numero1, numero2,cantCoincidencias=0;
            List<int> lista1,lista2 = new List<int>();

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            lista1= getSumaDivisores(numero1);
            lista2= getSumaDivisores(numero2);
            numero1.CompareTo(numero2);



        }
    }
}
