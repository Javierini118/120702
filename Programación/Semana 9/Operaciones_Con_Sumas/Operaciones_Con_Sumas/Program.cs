using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Con_Sumas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("suma de 5 + 10/////"+ suma(5,10));
            Console.WriteLine("Resta de 5 - 10/////" + resta(5, 10));
            Console.WriteLine("Potencia de 5 * 10/////"+ potencia(5,10));
            Console.WriteLine("Multiplicacion de 5 * 10/////"+ multiplicación(5,10));
            Console.ReadKey(); 
        }

        static int suma(int numero1, int numero2)
        {
            int acumulador = 0;

           acumulador = numero1 + numero2;


            return acumulador;
        }

        static int potencia(int _base, int exponente)
        {
            int numero = 1;

            numero = _base ^ exponente; 

            return numero;
        }







        static int resta(int sumando, int restando)
        {
            int numero = 0;

            numero = sumando - restando; 


            return numero; 
        }

        static int multiplicación(int sumando, int restando)
        {
            int numero = 0;

            numero = sumando * restando;


            return numero;
        }
    }



}
