using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_JR_1207022_TAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {// inicio
            Console.WriteLine("hola me llamo Javier - 1207022");
            Console.WriteLine(" Ingrese un numero entre 0 y 999.99");

            double numero = double.Parse(Console.ReadLine());

            int resultado = (int)(numero / 100);
            numero = numero % 100;

            Console.WriteLine("billetes de 100 " + resultado);
        
            resultado = (int)(numero / 50);
            numero = numero % 100;

            Console.WriteLine(" billetes de 50 "+ numero);

            resultado = (int)(numero / 20);
            numero = numero % 100;

            Console.WriteLine("billetes de 20 " + numero);

            resultado = (int)(numero / 10);
            numero = numero % 100;

            Console.WriteLine("billetes de 10 "+ numero);

            resultado = (int)(numero / 5);
            numero = numero % 100;

            Console.WriteLine("billetes de 5 ");

            resultado = (int)(numero / 1);
            numero = numero % 100;

            Console.WriteLine("billetes de 1 ");

            Console.ReadKey(); 



        }// fin 
    }
}
