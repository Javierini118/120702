using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_JAVIERRUANO_1207022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apellidos = "";
            string nombres = "";
            int dia = 0;
            int mes = 0;
            int anio = 0;
            bool casado = true;

            int dpi = 0;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Bienvenido a la aplicacion de identidad ");
            Console.WriteLine("por favor intese sus apellidos");
            apellidos = Console.ReadLine();

            Console.WriteLine("por favor ingrese sus nombres");
            nombres = Console.ReadLine();

            Console.WriteLine("Por favor ingrese el dia de su nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Porfavor ingrese su mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("porfavor ingrese su año de nacimiento");
            anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("porfavor ingresar |si| sí esta casado");
            casado= Convert.ToInt32(Console.ReadLine()); 





        }
    }
}
