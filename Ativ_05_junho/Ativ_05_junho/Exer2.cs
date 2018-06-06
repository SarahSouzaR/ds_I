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
    public partial class Exer2 : Form
    {
        public Exer2()
        {
            InitializeComponent();
        }

        private void Exer2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnDez_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(txbNum.Text);
            //double d10 = 0;

            if (num % 10 == 0) 
            {
                lblResult.Text = "O seu número é divisível por 10 !";

                if (num % 5 == 0)
                {
                    lblResult.Text = "O seu número é divisível por 10 e 5 !";

                    if (num % 2 == 0)
                    {
                        lblResult.Text = "O seu número é divisível por 10, 5 e 2 !";
                    }
                }
            }

            else if (num % 5 == 0) 
            {
                lblResult.Text = "O seu número é divisível por 5 !";
            }

            else if (num % 2 == 0)
            {
                lblResult.Text = "O seu número é divisível por 2 !";
            }

            else 
            {
                lblResult.Text = "O número não é divisível por 10, 5 ou 2 !";
            }
        }
    }
}
