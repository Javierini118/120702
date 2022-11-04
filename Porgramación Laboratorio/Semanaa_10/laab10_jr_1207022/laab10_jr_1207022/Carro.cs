using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laab10_jr_1207022
{
    internal class Carro
    {
        private string Marca = "";
        private int Modelo = 0;
        private double  Precio = 0;
        private string Descripcion = "";
        private double Iva = 0;
        private double PrecioConIva = 0;
        private int calculo = 0; 
        


        public void setMarca(string marca)
        {
            if (marca != "")
            {
                this.Marca = marca;
            }
        }
        public void setModelo(int modelo)
        {
           this.Modelo=modelo;
        }
        public void setPrecio(double precio) 
        {
            this.Precio = precio;
        }
        public void setDescripcion(string descripcion)
        {
            this.Descripcion = descripcion; 
        }

        public void SetPrecioFinal(double precioConIva)
        {
            this.PrecioConIva = precioConIva; 
        }

      
       

        public string leermarca()
        {
            return Marca; 
        }

        public int leermodelo()
        {
            return this.Modelo; 
        }

        public double LeerPrecio()
        {
            return this.Precio;
        }

        public string leerDescripcion()
        {
            return this.Descripcion; 
        }

        public double CalcularIva(double IvaActual)
        {
            PrecioConIva = Precio + (Precio * (IvaActual / 100));
            return PrecioConIva;

                
        }

        public void calcularletras(int calcular)
        {
            this.calculo = calcular;
        }

        public int LeerLenght ()
        {
            return this.calculo; 
        }

        public double leerPrecioFinal()
        {
            return this.PrecioConIva; 
        }


       

    }
}
