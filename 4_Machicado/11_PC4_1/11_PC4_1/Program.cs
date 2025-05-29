using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            //Pies
            Console.WriteLine("Ingresa la longitud");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1;
            num1 = pies(num1);
            Console.WriteLine("Su medida en pies es: " + num1);
            //Pulgadas
            num2 = pulgadas(num2);
            Console.WriteLine("Su medida en pulgadas es: " + num2);
            Console.ReadKey();
        }
        public static double pies(double n)
        {

            n = n / 30.48;
            return n;
        }
        public static double pulgadas(double n)
        {
            n = n / 2.54;
            return n;
        }

    }
}
