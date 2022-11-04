using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laab11_jr_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero mayor a 10");
            int N = int.Parse(Console.ReadLine());

            int[] elementos = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ingrese el numero que desee guardar");
                int numero = int.Parse(Console.ReadLine());
                elementos[i] = numero;
            }

            Console.WriteLine("Ingrese X: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Y: ");
            int Y = int.Parse(Console.ReadLine());

            int[,] table = new int[X, Y];
            table[0, 1] = 1239;

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    table[x, y] = 1;
                }
            }

            Console.ReadKey();
        }
    }
}
