using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Validacion = true; 
            
            while(Validacion)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido a tu calculadora virtual por favor ingrese la opcion que desee realizar");
                Console.WriteLine("1) suma");
                Console.WriteLine("2) resta");
                Console.WriteLine("3) multiplicacion");
                Console.WriteLine("4) division");
                Console.WriteLine("5) salir");
                Console.WriteLine("----------------------------------------------------------------------------");
                double Numero = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Numero = Convert.ToInt32(Console.ReadLine());   
                    
                }
                catch
                {
                    Console.WriteLine("Ingrese un numero bobi");
                    Console.ReadLine();
                    Console.Clear();
                }

                switch(Validacion)
                {
                    case 1:
                        Console.WriteLine(" Hola mundo "); 
                        break; 


                }
               
              
            }
        }
    }
}
