using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double valorC = System.Convert.ToDouble(txbValorC.Text);

            if (valorA > valorB && valorA > valorC)
            {
                lblResposta.Text = "O maior valor é o de A";
            }

            else if (valorB > valorA && valorB > valorC)
            {
                lblResposta.Text = "O maior valor é o de B";
            }

            else if (valorC > valorA && valorC > valorB)
            {
                lblResposta.Text = "O maior valor é o de C";
            }

            else if (valorA == valorB && valorA > valorC)
            {
                lblResposta.Text = "Os valores de A e B são iguais e maiores que C";
            }

            else if (valorB == valorC && valorB > valorA)
            {
                lblResposta.Text = "Os valores de B e C são iguais e maiores que A";
            }

            else if (valorA == valorC && valorA > valorB)
            {
                lblResposta.Text = "Os valored de A e C são iguais e maiores que B";
            }

            else
            {
                lblResposta.Text = "Os três valores são iguais";
            }
        }
    }
}
