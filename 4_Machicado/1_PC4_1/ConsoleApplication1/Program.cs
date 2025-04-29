using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal c, f;
            Console.WriteLine("ingrese la cantidad de celsius");
            c = Convert.ToDecimal(Console.ReadLine());
            f = (c * 9 / 5) + 32;
            Console.WriteLine("el cambio a farenheit es: " + f + "°");
            Console.ReadKey();
        }
    }
}
