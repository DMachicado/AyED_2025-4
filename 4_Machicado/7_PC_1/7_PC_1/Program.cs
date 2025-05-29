using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_PC_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version recursiva
            Console.WriteLine("version recursiva");
            int fct, resultado;
            Console.WriteLine("ingresa un numero");
            fct = Convert.ToInt32(Console.ReadLine());
            resultado = factorial(fct);
            Console.WriteLine("el factorial es " + resultado);

            //Version iterativa
            Console.WriteLine("version Iterativa");
            int fct2;
            Console.WriteLine("ingresa un numero");
            fct2 = Convert.ToInt32(Console.ReadLine());
            for (int i = fct2 - 1; i > 1; i--)
            {
                fct2 = fct2 * i;
            }
            Console.WriteLine("el factorial es " + fct2);
            Console.ReadKey();
        }
        public static int factorial(int n)
        {
            for (int i = n - 1; i > 1; i--)
            {
                n = n * i;
            }
            return n;
        }

    }
}
