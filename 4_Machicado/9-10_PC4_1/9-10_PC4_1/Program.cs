using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, j;
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            j = 0;
            for (int i = altura; i > j;)
            {
                j++;
                for (int t = 0; t <= j; t++)
                {
                    if (t != j)
                    {
                        Console.Write("*");
                    }
                    if (t == j)
                    {
                        if (i != j)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
