using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_1207022_JavierRuano
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Ejercicio no.1 y 2 (ambos son el mismo) -------------------------------------------------------------------------


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Bienvenido a tu aplicacion de ecuaciones por favor ingrese su numero para evaluar las ecuaciones");
            int numero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Su numero es de " + numero);
            Console.ReadKey();
            Console.Clear();

            double y1 = (3 * (numero ^ 3)) - (numero ^ (1 / 3)) + (4 * (numero ^ 2));
            double y2 = (4 * (numero ^ 3)) - (3 * (numero ^ 2)) + (2 * (numero)) - 5;
            double y3 = (5 * (numero ^ (1 / 3))) + (4 * (numero ^ 2)) + 6;


            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("El resultado de sus ecuaciones es, precione enter para sseguir avanzando");
            Console.WriteLine("  (3*(numero ^3)) -(numero ^(1/3)) + (4* (numero ^ 2))");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Resultado:" + y1);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("  (4*(numero ^ 3)) - (3*(numero ^2 ))  + (2 *(numero)) -5");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Resultado:" + y2);
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("  (5 * (numero ^ (1 / 3))) + (4* (numero ^ 2)) + 6 ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Resultado:" + y3);
            Console.WriteLine("-------------------------------------------------------------");

            Console.ReadKey();



            // Ejercicio No.2 ---------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("Bienvenido a su aplicacion de gastos, Ingrese el monto anual total de la empresa");
            double costosEmpresa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Presione enter para seguir avanzando");
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("El 50 % va dirigido a recursos humanos");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(costosEmpresa * 0.50);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("El 25 % va dirigido a manufactura ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(costosEmpresa * 0.25);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("El 15 % va dirigido a recursos humanos");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(costosEmpresa * 0.15);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("El 10 % va dirigido a publicidad");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(costosEmpresa * 0.10);

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.ReadKey();





            // Ejercicio no.3 ------------------------------------------------------------------------------------------------

            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Hola bienvenido a su aplicacion de salario neto ");
            Console.WriteLine("Por favor ingrese el salario de su trabajador");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            double salarioTrabajador = Convert.ToDouble(Console.ReadLine());

      
            double cantidadMenosDescuento1 = salarioTrabajador * 0.09;
            double cantidadMenosDescuento2 = salarioTrabajador * 0.07;
            double cantidadMenosDescuento3 = salarioTrabajador * 0.10;


            double descuentoFinal1 = cantidadMenosDescuento1 + cantidadMenosDescuento2 + cantidadMenosDescuento3;

            double descuentofinal2 = salarioTrabajador - descuentoFinal1;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Su salario total es de " + salarioTrabajador);
            Console.WriteLine("- "+ cantidadMenosDescuento1);
            Console.WriteLine("- " + cantidadMenosDescuento2);
            Console.WriteLine("- " + cantidadMenosDescuento3);
            Console.WriteLine("Su cantidad "+ salarioTrabajador + " restando sus descuentos es de " + "||" + descuentofinal2 + "||");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.ReadKey();






            // Ejercicio no.4 ----------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenido a su aplicacion de calculador, por favor ingresar su primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("por favor ingresar su segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("por favor ingrese el numero de la opcion que desee");

            Console.WriteLine("1) suma");
            Console.WriteLine("2) resta");
            Console.WriteLine("3) multiplicacion");
            Console.WriteLine("4) division");
            Console.WriteLine("5) mod");
            int numeroAEligir = Convert.ToInt32(Console.ReadLine()) ;

            switch (numeroAEligir)
            {
                case 1:
                    int numeroFinal = numero1 + numero2;
                    Console.WriteLine("su numero es " + numeroFinal);
                    break;

                case 2:
                    numeroFinal = numero1 - numero2;
                    Console.WriteLine("su numero es " + numeroFinal);
                    break;

                case 3:
                   numeroFinal = numero1 * numero2;
                    Console.WriteLine("su numero es " + numeroFinal);
                    break;

                case 4:
                     numeroFinal = numero1 / numero2;
                    Console.WriteLine("su numero es " + numeroFinal);
                    break;

                case 5:
                    numeroFinal = numero1 % numero2;
                    Console.WriteLine("su numero es " + numeroFinal);
                    break;

            }

            Console.ReadKey();





            // ultimos 2 ejercicios, perdon ingeniero no supe como hacerlos mil disculpas, el sabado 15 que veremos clase te











        }



    }
}
