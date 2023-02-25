using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrayanMaradiaga
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private async void buttonCalcular_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBoxPrecio.Text);
            double cantidad = Convert.ToDouble(textBoxCantidad.Text);

            MessageBox.Show("El Descuento es: " + await descuentoAsincrono(precio, cantidad));
            MessageBox.Show("El Total es de: " + await pagoAsincrono(precio, cantidad));

        }

        private async Task<double> descuentoAsincrono(double precio, double x)
        {
            var descuentoFinal = await Task.Run(() =>
            {
                return (precio * x) * 0.15;
            });
            return descuentoFinal;
        }

        private async Task<double> pagoAsincrono(double precio, double x)
        {
            double subFinal = (precio * x), descuento = ((precio * x) * 0.15);
            var totalFinal = await Task.Run(() =>
            {
                return subFinal - descuento;
            });
            return totalFinal;


        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
            textBoxDirecc.Clear();
            textBoxRTN.Clear();
            textBoxFecha.Clear();
            textBoxDescrip.Clear();
            textBoxPrecio.Clear();  
            textBoxCantidad.Clear();
            textBoxCliente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TercerFormulario miforma = new TercerFormulario();

            miforma.Show();
        }
    }
}
