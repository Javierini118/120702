using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_JR_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {// inicio de la clase

            Console.WriteLine("Hola Mundo");
            Console.ReadKey();

            Console.WriteLine("Dime tu nomre");
            string NOMBRE = Console.ReadLine();

            Console.WriteLine("su nombre es "+ NOMBRE);

            Console.ReadKey();
            Console.Clear();

            // Ejercicio No.1 
            Console.WriteLine("------------------------------------------"); 
            Console.WriteLine("ejercicio 1: operaciones aritméticas");
            Console.WriteLine("Por favor "+ NOMBRE+ " ingrese un número"); 
            int Número1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese un segundo número");
            int Número2 = Convert.ToInt32(Console.ReadLine());
          

            int suma = Número1 + Número2; 
            Console.WriteLine("El resultado de su suma es de:");
            Console.WriteLine(Número1+"+"+ Número2+"="+ suma);


            int resta = Número1 - Número2;
            Console.WriteLine("El resultado de su resta es de:");
            Console.WriteLine(Número1 + "-" + Número2 + "=" + resta);

            int multiplicacion = Número1 * Número2;
            Console.WriteLine("El resultado de su multiplicacion es de:");
            Console.WriteLine(Número1 + "*" + Número2 + "=" + multiplicacion);

            int division = Número1 / Número2;
            Console.WriteLine("El resultado de su division es de:");
            Console.WriteLine(Número1 + "/" + Número2 + "=" + division);

            int mod= Número1 % Número2;
            Console.WriteLine("El resultado de su resta es de:");
            Console.WriteLine(Número1 + "%" + Número2 + "=" + mod);
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();



            Console.Clear();
            // ejercicio No.2 

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ejercicio 2: operaciones booleanas");
            Console.WriteLine("------------------------------------------");


            // Ejercicio No.3 
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");

            int problema1, problema2, problema3, problema4;

            int num1problema3, num2problema2, num3problema3; 
            Console.WriteLine("Por favor " + NOMBRE + " ingrese un número");
            num1problema3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese un segundo número");
            num2problema2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese un tercer número");
            num3problema3 = Convert.ToInt32(Console.ReadLine());

            // problemas

            problema1 = num1problema3 * num2problema2 + num3problema3;
            problema2 = num1problema3 * (num2problema2 + num3problema3);
            problema3 = num1problema3 / (num2problema2 * num3problema3);
            problema4 = (num1problema3*3 + (2* num2problema2  / (num3problema3* num3problema3)));


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("el problema 1 es  de: a * b + c =  "+ problema1);
            Console.WriteLine("el problema 2 es de 𝑎 ∗ (𝑏 + 𝑐)"+ problema2);
            Console.WriteLine("el problema 2 es de 𝑎/𝑏*c"+ problema3);
            Console.WriteLine("el problema 4 es de  3𝑎+2𝑏 / c2 ");
            Console.WriteLine("------------------------------------------");

            Console.ReadKey(); 



        }// fin 
    }
}
