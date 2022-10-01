using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_JavierRuano_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ejercicio No.1 ");
            Console.WriteLine("Ingrese el numero de mes ");
            Console.WriteLine("------------------------------------------------------");
            int NumMes = Convert.ToInt32(Console.ReadLine());



            if(NumMes <1 || NumMes >12)
            {
                Console.WriteLine("El numero a ingresar no debe estar contenido entre 1 y 12"); 
            }

            else
            {
                switch(NumMes)
                {
                    case 1:
                        Console.WriteLine(" Su mes es de Enero"); 
                        break;

                    case 2:
                        Console.WriteLine(" Su mes es de febrero");
                        break;
                    case 3:
                        Console.WriteLine(" Su mes es de marzo");
                        break;
                    case 4:
                        Console.WriteLine(" Su mes es de abril");
                        break;
                    case 5:
                        Console.WriteLine(" Su mes es de mayo");
                        break;
                    case 6:
                        Console.WriteLine(" Su mes es de Junio");
                        break;
                    case 7:
                        Console.WriteLine(" Su mes es de Julio");
                        break;
                    case 8:
                        Console.WriteLine(" Su mes es de Agosto");
                        break;
                    case 9:
                        Console.WriteLine(" Su mes es de septiembre");
                        break;
                    case 10:
                        Console.WriteLine(" Su mes es de octubre");
                        break;
                    case 11:
                        Console.WriteLine(" Su mes es de Noviembre");
                        break;
                    case 12:
                        Console.WriteLine(" Su mes es de diciembre");
                        break;

                   

                }

                Console.ReadKey(); 
            }




            
        }
    }
}
