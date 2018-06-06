using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade1_7
{
    public partial class Exer1 : Form
    {
        public Exer1()
        {
            InitializeComponent();
        }

        private void Exer1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else 
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbNum1.Text);
            double num2 = System.Convert.ToDouble(txbNum2.Text);

            double resultado = num1 + num2;
            double result2 = resultado + 8;
            double result3 = resultado - 5;

            lblResultado.Text = "Resultado: " + resultado.ToString();

            if (resultado > 20) 
            {
                lblCondicao.Text = "Somando com 8, ficará: " + result2.ToString();
            }

            else
            {
                lblCondicao.Text = "Subtraindo 5, ficará: " + result3.ToString();
            }
        }

    }
}
