using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string plb;
            Console.WriteLine("ingrese una palabra/frase");
            plb = Console.ReadLine();
            int i = 0;
            foreach (char letra in plb)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    i++;
                }
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    i++;
                }
            }
            Console.WriteLine("La palabra/frase contiene " + i + " vocales");
            Console.ReadKey();
        }
    }
}
