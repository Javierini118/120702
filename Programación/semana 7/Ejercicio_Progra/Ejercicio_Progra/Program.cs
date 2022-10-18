using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Progra
{
    internal class Program
    {
        static void Main(string[] args)
        {// Inicio


            int CantidadTotalDeBilletes; 







            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Buenos dias por favor ingrese una cantidad 4 dígitos");
            CantidadTotalDeBilletes = Convert.ToInt32(Console.ReadLine());



            int billetes200 = CantidadTotalDeBilletes / 200;
             CantidadTotalDeBilletes = CantidadTotalDeBilletes  % 200;

            Console.WriteLine(CantidadTotalDeBilletes);

            Console.WriteLine(" El resultado total de la cantidad de billetes es de ");


            Console.ReadKey(); 



        }// fin 

    }
}
