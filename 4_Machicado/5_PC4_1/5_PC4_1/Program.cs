using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int año, num, dia, mes, dia2, rest, dia_2, mes_2, año_2;
            bool bisiesto;
            Console.WriteLine("ingrese el numero de dia de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero de mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el año de nacimiento");
            año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero de dia actual");
            dia_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero de mes actual");
            mes_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el año actual");
            año_2 = Convert.ToInt32(Console.ReadLine());
            num = 0;
            while (año != año_2 || mes != mes_2 || dia != dia_2)
            {
                num = num + 1;
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
                    dia2 = dia + 1;
                    rest = dia2 % 31;
                    if (dia2 > 31)
                    {
                        mes = mes + 1;
                        dia = rest;
                    }
                    else
                    {
                        dia = dia + 1;
                    }

                }
                else
                {
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        dia2 = dia + 1;
                        rest = dia2 % 30;
                        if (dia2 > 30)
                        {
                            mes = mes + 1;
                            dia = rest;
                        }
                        else
                        {
                            dia = dia + 1;
                        }
                    }
                    else
                    {
                        if (mes == 2)
                        {
                            if (bisiesto == true)
                            {
                                dia2 = dia + 1;
                                rest = dia2 % 29;
                                if (dia2 > 29)
                                {
                                    mes = mes + 1;
                                    dia = rest;
                                }
                                else
                                {
                                    dia = dia + 1;
                                }
                            }
                            if (bisiesto == false)
                            {
                                dia2 = dia + 1;
                                rest = dia2 % 28;
                                if (dia2 > 28)
                                {
                                    mes = mes + 1;
                                    dia = rest;
                                }
                                else
                                {
                                    dia = dia + 1;
                                }
                            }
                        }
                    }
                }

                if (mes > 12)
                {
                    año = año + 1;
                    mes = 1;
                }
            }
            Console.Write("pasaron: ");
            Console.Write(num);
            Console.Write(" dias");
            Console.ReadKey();

        }
    }
}
