using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double adicao = valorA + valorB;

            lblResultado.Text = adicao.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double sub = valorA - valorB;

            lblResultado.Text = sub.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double mult = valorA * valorB;

            lblResultado.Text = mult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double div = valorA / valorB;

            lblResultado.Text = div.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

    }
}
