using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laab10_jr_1207022
{

    public partial class Form1 : Form
    {
        Carro nuevoCarro = new Carro();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void outputMarca_Click(object sender, EventArgs e)
        {
            

                
        }

        private void BotonCargarDatos_Click(object sender, EventArgs e)
        {
           

            string marca = ImputMarca.Text;
            int modelo = (int)imputModelo.Value;
            double precio = (double) inputPrecio.Value;
            string descripcion = InputDescripcion.Text;
            int calculo = 0;

            calculo = marca.Length;
            if (marca == "")
            {
                MessageBox.Show("No puede estar vacia la marca", "No dejar en blanco");
            }

            else
            {
                if(nuevoCarro.LeerLenght()==0)
                {

                    nuevoCarro.setMarca(marca);
                    nuevoCarro.setPrecio(precio);
                    nuevoCarro.setDescripcion(descripcion);
                    nuevoCarro.setModelo(modelo);
                    nuevoCarro.setModelo(modelo);
                    imputModelo.Value = 2007; 
                }

                else if(calculo == nuevoCarro.LeerLenght())

                {
                    nuevoCarro.setMarca(marca);
                    nuevoCarro.setPrecio(precio);
                    nuevoCarro.setDescripcion(descripcion);
                    nuevoCarro.setModelo(modelo);
                    nuevoCarro.setModelo(modelo);
                    imputModelo.Value = 2007;

                }

                else
                {
                    MessageBox.Show("no se puede estar vacio sin su precio, debe llenarlo"); 
                }
            }
            if (precio == 0)
            {
                MessageBox.Show("no se puede estar vacio sin su precio, debe llenarlo");
            }
            else
            {
                if (nuevoCarro.LeerPrecio() == 0)
                {
                    nuevoCarro.setPrecio(precio);
                }

                else if (precio <= nuevoCarro.LeerPrecio())
                {
                    nuevoCarro.setPrecio(precio);
                }
                else 
                {
                    MessageBox.Show("no se puede superar al precio anterior, precio no valido");
                }
            }



         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            outputMarca.Text = nuevoCarro.leermarca();
            outputDescripcion.Text = nuevoCarro.leerDescripcion();
            outputPrecio.Text = nuevoCarro.LeerPrecio().ToString();
            OutputModelo.Text = nuevoCarro.leermodelo().ToString();
          

        }

        private void inputPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ivaIngresado = (double)inputIVA.Value;
            nuevoCarro.CalcularIva(ivaIngresado);


            outputPrecioFinal.Text = nuevoCarro.leerPrecioFinal().ToString();

        }

        private void OutputIVA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void imputModelo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
