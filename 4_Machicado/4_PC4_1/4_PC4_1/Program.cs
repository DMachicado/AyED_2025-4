using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bisiesto;
            int año, dia, mes, dia2, rest;
            //aca va el año de la fecha|
            Console.WriteLine("ingrese el numero de dia");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero de mes");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el año");
            año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0 || año % 400 == 0 && año % 100 != 0)
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                dia2 = dia + 30;
                rest = dia2 % 31;
                if (dia2 > 31)
                {
                    mes = mes + 1;
                    dia = rest;
                }
            }
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dia2 = dia + 30;
                rest = dia2 % 31;
                if (dia2 > 31)
                {
                    mes = mes + 1;
                    dia = rest;
                }
            }
            if (mes == 2)
            {
                if (bisiesto == true)
                {
                    dia2 = dia + 30;
                    rest = dia2 % 29;
                    if (dia2 > 29)
                    {
                        mes = mes + 1;
                        dia = rest;
                    }
                }
                else
                {
                    dia2 = dia + 30;
                    rest = dia2 % 28;
                    if (dia2 > 28)
                    {
                        mes = mes + 1;
                        dia = rest;
                    }
                }
            }
            if (mes > 12)
            {
                año = año + 1;
                mes = 1;
            }
            Console.Write("la nueva fecha es: ");
            Console.Write(dia);
            Console.Write("/");
            Console.Write(mes);
            Console.Write("/");
            Console.Write(año);
            Console.ReadKey();
        }
    }

}
    
