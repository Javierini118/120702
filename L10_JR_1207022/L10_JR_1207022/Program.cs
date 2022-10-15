using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_JR_1207022
{




    
    internal class Motocicleta



       
    {
        private int Modelo = 2019;
        private double Precio = 1000;
        private string Marca = "";
        private double Iva = 0.12;

        public string mostrarDatos()
        {
            string datos = "Modelo"; +Modelo + "\n" +
                "precio" + Precio + "\n" +
                "Marca" + Marca + "\n";

            return datos;
        }

        public void DefinirPrecio(double precio)
        {
            Precio = precio; 

        }

        public void DefinirIva (double iva)
        {

            if(iva >0 && iva <1)
            {
                Iva = iva;
            }
           
        }

        public double PrecioSinIva()
        {
            return Precio;
        }

        public double PrecioConIva()
        {
            return Precio + DevolverIva();
        }


        public double DevolverIva()
        {
            return Precio * Iva; 
        }


        
        
    }
}
