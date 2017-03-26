using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaDeCollatz
{
    class Program
    {
        static void secuencia(int numero,int nroEjercicio)
        {
           
            int result;

            if (nroEjercicio == 1 && numero == 1)
            {
                Console.Write(numero);
            }
            else
            {
                Console.Write("*");
            }

            while (numero != 1)
            {
       
                Math.DivRem(numero, 2, out result);
                if (result == 0)
                {
                    numero = numero / 2;

                    if (nroEjercicio == 1)
                    {
                        Console.Write(numero);
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                else
                {
                    numero = (numero * 3) + 1;
                    if (nroEjercicio == 1)
                    {
                        Console.Write(numero);
                    }

                    else
                    {
                        Console.Write("*");
                    }

                }
            }
             
                
                   
        }

        static void secuenciaDeCaracteres(int numero,int ejercicio)
        {
            for(int i = 1; i <= numero; i++)
            {
                secuencia(i, ejercicio);
                Console.WriteLine();
            }

        }

        static int cargaDatos(string datos)
        {
            int numero = 0;
            Boolean existeError;

            do
            {
                existeError = false;
                try
                {
                    Console.WriteLine(datos);
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dato Ingresado: " + numero);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    existeError = true;
                }
            } while (existeError);
            return numero;
        }


        static bool confirmaNuevo()
        {

            string confirma =string.Empty;
            do
            {
                Console.WriteLine("si desea ingresa otro numero ingrese 'si' de lo contrario 'no'");
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


        static void Main(string[] args)
        {
            

            int numero,ejercicio;
            do
            {
                ejercicio = cargaDatos("ingese 1 para ejercicio de secuencia numeria, 2 para secuencia en caracteres");
                switch (ejercicio)
                {
                    case 1:
                        numero = cargaDatos("ingrese Numero");
                        secuencia(numero, ejercicio);
                        break;
                    case 2:
                        numero = cargaDatos("ingrese Numero");
                        secuenciaDeCaracteres(numero, ejercicio);
                        break;
                    default:
                        Console.WriteLine("Numero de Ejercicio equivocado");
                        break;
                }
            } while (confirmaNuevo());   
            
          
        }
    }
}
