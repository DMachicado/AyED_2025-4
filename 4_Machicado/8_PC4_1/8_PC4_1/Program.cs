using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n = 0, j = 1, a = 0, pos = 0;
            Console.WriteLine("ingrese el numero de la serie fibonacci: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (a <= num)
            {
                a = n + j;
                Console.Write(n + ",");
                j = n;
                n = a;
                pos++;
            }
            Console.WriteLine();
            Console.WriteLine("la posicion en la serie es: " + pos);
            Console.ReadKey();
        }
    }
}
