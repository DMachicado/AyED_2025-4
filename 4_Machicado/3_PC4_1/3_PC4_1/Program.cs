using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("ingrese un año");
            año = Convert.ToInt32(Console.ReadLine());
            bisiesto(año);
            Console.ReadKey();
        }
        static void bisiesto(int año)
        {
            if (año % 4 == 0 || año % 400 == 0)
            {
                Console.WriteLine("el año es bisiesto");
            }
            else
            {
                Console.WriteLine("el año no es bisiesto");
            }
        }
    }
}
