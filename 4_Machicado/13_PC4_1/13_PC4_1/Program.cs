using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola bienvenido");
            impar();
            par();
            num();
            numrev();
            multi3();
            multi3y2();
            Console.ReadKey();
        }
        static void impar()
        {
            Console.WriteLine("los numeros impares son: ");
            for (int j = 1; j <= 100; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(j + ", ");
                }
                if (j == 100)
                {
                    Console.WriteLine();
                }
            }
        }
        static void par()
        {
            Console.WriteLine("los numeros pares son: ");
            for (int j = 1; j <= 100; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(j + ", ");
                }
                if (j == 100)
                {
                    Console.WriteLine();
                }
            }
        }
        static void num()
        {
            Console.WriteLine("los numeros del 1 al 100: ");
            for (int j = 1; j <= 100; j++)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
        }
        static void numrev()
        {
            Console.WriteLine("los numeros del 100 al 1: ");
            for (int j = 100; j >= 1; j--)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
        }
        static void multi3()
        {
            Console.WriteLine("los numeros multiplos de 3 son: ");
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0)
                {
                    Console.Write(j + ", ");
                }
                if (j == 100)
                {
                    Console.WriteLine();
                }
            }
        }
        static void multi3y2()
        {
            Console.WriteLine("los numeros multiplos de 3 y 2 son: ");
            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 2 == 0)
                {
                    Console.Write(j + ", ");
                }

                if (j == 100)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
