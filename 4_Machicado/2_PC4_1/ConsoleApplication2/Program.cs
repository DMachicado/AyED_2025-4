using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string mes;
            Console.WriteLine("ingrese el mes(sin mayusculas ni espacios)");
            mes = Console.ReadLine();
            num1 = 0;
            switch (mes)
            {
                case "enero": num1 = 1; break;
                case "febrero": num1 = 2; break;
                case "marzo": num1 = 3; break;
                case "abril": num1 = 4; break;
                case "mayo": num1 = 5; break;
                case "junio": num1 = 6; break;
                case "julio": num1 = 7; break;
                case "agosto": num1 = 8; break;
                case "septiembre": num1 = 9; break;
                case "octubre": num1 = 10; break;
                case "noviembre": num1 = 11; break;
                case "diciembre": num1 = 12; break;
                default:
                    Console.WriteLine("ERROR ingrese un valor valido");
                    break;
            }
            if (num1 != 0)
            {
                Console.WriteLine("el numero de mes es: " + num1);
            }

            Console.ReadKey();
        }
    }
}
