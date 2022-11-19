using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L89_JavierRuano_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            while(numero>18 && numero <100)
            {
                Console.WriteLine("Aun estas a salvo");
                Console.WriteLine("Ingesa otro numero ");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Veamos.....");

               
            }

            Console.WriteLine("ya no estas a salvo ");
            Console.ReadKey();


            do
            {
                Console.WriteLine("Estoy mostrando el Dowhile 1 vez");
                Console.ReadKey();

            }
            while(true);
            {
                Console.WriteLine("Tambien estoy ensseñando el do while 1 vez");
                Console.ReadKey();
            }
        }
    }
}
