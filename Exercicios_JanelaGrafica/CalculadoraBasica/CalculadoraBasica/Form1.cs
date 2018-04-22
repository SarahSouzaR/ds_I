using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double soma = valor1 + valor2;

            lblResultado.Text = soma.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double subtrair = valor1 - valor2;

            lblResultado.Text = subtrair.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double multiplicar = valor1 * valor2;

            lblResultado.Text = multiplicar.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double dividir = valor1 / valor2;

            lblResultado.Text = dividir.ToString();
        }
    }
}
