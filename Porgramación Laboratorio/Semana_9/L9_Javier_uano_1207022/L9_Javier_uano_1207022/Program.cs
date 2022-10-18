using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_Javier_uano_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.WriteLine("Que numero fibonacci desea");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1)
            {
                Console.WriteLine(0);
            }
            else if (numero == 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int resultado = 0;
                int numeroAnterior1 = 0;
                int numeroAnterior2 = 0;
                for (int i = 3; i <= numero; i++)
                {
                    resultado = numeroAnterior1 + numeroAnterior2;
                    numeroAnterior1 = numeroAnterior2;
                    numeroAnterior2 = resultado;
                }

                Console.WriteLine(resultado);
                Console.ReadKey();
            }
        }
    }
}
