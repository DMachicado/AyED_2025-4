using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cil, pist, sec, cantsec, totalb, totalkb, totalmb, totalgb;
            cantsec = 512;
            totalkb = 0;
            totalmb = 0;
            totalgb = 0;
            Console.WriteLine("ingrese la cantidad de cilindros");
            cil = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de pistas");
            pist = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de sectores");
            sec = Convert.ToInt32(Console.ReadLine());
            totalb = cil * pist * sec * cantsec;
            if (totalb > 1024)
            {
                totalkb = totalb / 1024;
            }
            if (totalkb > 1024)
            {
                totalmb = totalkb / 1024;
            }
            if (totalmb > 1024)
            {
                totalgb = totalmb / 1024;
            }
            Console.WriteLine(totalb + "b " + totalkb + "kb " + totalmb + "mb " + totalgb + "gb ");
            Console.ReadKey();
        }
    }
}
