using System;
using System.Windows.Forms;

namespace Desafios
{
    public partial class txtInteres : Form
    {
        public txtInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double montoprestamo = double.Parse(txtMontoInicial.Text);
                double tasaInteresAnual = double.Parse(txtTasaInteres.Text) / 100; 
                int plazoprestamo = int.Parse(txtInversion.Text);

                double cuotamensual = (montoprestamo * tasaInteresAnual) / (1 - Math.Pow((1 + tasaInteresAnual), -plazoprestamo));
                double interesesTotales = cuotamensual * plazoprestamo - montoprestamo;
                double totalAPagar = montoprestamo + interesesTotales;

                lblCuotaMensual.Text = $"Cuota Mensual: {cuotamensual:C2}";
                lblInteresesTotales.Text = $"Intereses Totales: {interesesTotales:C2}";
                lblTotalPagar.Text = $"Total a Pagar: {totalAPagar:C2}";

                MessageBox.Show($"Intereses Totales: {interesesTotales:C2}\nTotal a Pagar: {totalAPagar:C2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCapitalFinal_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
