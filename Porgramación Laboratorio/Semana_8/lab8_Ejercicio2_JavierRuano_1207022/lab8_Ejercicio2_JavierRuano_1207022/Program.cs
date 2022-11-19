using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_Ejercicio2_JavierRuano_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Bienvenido al separadador de numero por favor igrese sus numeros:");
            Console.WriteLine("Ingrese su primer numero");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Ingrese su segundo numero");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Ingrese su tercer numero");
            int Numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine(" sus numeros son " + Numero1+"  "+ + Numero2+"  " + Numero3);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadKey();
            Console.Clear();

            if (Numero1 > Numero2)
            {
                if (Numero1 > Numero3)
                {
                    Console.WriteLine("A es el mayor");
                }
                else
                {
                    if (Numero1 == Numero3)
                    {
                        Console.WriteLine("A y C son los mayores");
                    }
                    else
                    {
                        Console.WriteLine("C es el mayor");
                    }
                }
            }

            else
            {
                if (Numero1 == Numero2)
                {
                    if (Numero1 > Numero3)
                    {
                        Console.WriteLine("A es el mayor");

                    }
                    else
                    {
                        if (Numero1 == Numero3)
                        {
                            Console.WriteLine("A y C son los mauores");
                        }
                        else
                        {
                            Console.WriteLine("C es el mayor");
                        }
                    }

                }
                else
                {
                    if (Numero2 > Numero3)
                    {
                        Console.WriteLine("B es el mayor");
                    }
                    else
                    {
                        if (Numero2 == Numero3)
                        {
                            Console.WriteLine("B y c son los mayores");
                        }
                        else
                        {
                            Console.WriteLine("C es el mayor");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
