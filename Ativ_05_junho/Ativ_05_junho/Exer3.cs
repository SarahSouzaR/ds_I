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
    public partial class Exer3 : Form
    {
        public Exer3()
        {
            InitializeComponent();
        }

        private void Exer3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double a = System.Convert.ToDouble(txbA.Text);
            double b = System.Convert.ToDouble(txbB.Text);
            double c = System.Convert.ToDouble(txbC.Text);

            if ((b - c) < a && a < (b + c))
            {
                if ((a - c) < b && b < (a + c))
                {
                    if ((a - b) < c && c < (a + b))
                    {
                        if (a == b && b == c)
                        {
                            MessageBox.Show("Triângulo Equilátero");
                        }

                        else if (a == b || b == c || c == a)
                        {
                            MessageBox.Show("Triângulo Isósceles");
                        }

                        else
                        {
                            MessageBox.Show("Triângulo Escaleno");
                        }
                    }
                }
            }

            else 
            {
                MessageBox.Show("A figura não forma um triângulo!");
            }
        }
    }
}
