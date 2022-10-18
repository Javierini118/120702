using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_De_Billetes
{
    internal class Program
    {
        static void Main(string[] args)
        {// inicio

            
            
            int NumeroDecenas= 10; 
            int NumeroCentenas= 100;
            int NumeroUnidades= 1;

            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Ingrese cuantos billetes y monedas se utilizaran se necesitaran para 1987 quetzales");

            
            // asignación de valores ya que la computadora no entiende por su porpia cuenta


            Console.WriteLine("Se necesitara un total de 19 billetes de 100  =  " +NumeroCentenas * 19);
            Console.WriteLine("Se necesitara un total de 8 billetes de 10   = " + NumeroDecenas * 8);
            Console.WriteLine("Se necesitara un total de 7 billetes de 1   =" + NumeroUnidades * 7);

            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine(" tendremos un total de = 19 + 8 + 7 =  24 billetes" );
            Console.WriteLine("Tendremos un total de 1987 quetzales");

            Console.ReadKey(); 




        }// fin 

    }
}
