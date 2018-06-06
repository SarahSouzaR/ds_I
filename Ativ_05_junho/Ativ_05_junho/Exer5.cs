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
    public partial class Exer5 : Form
    {
        public Exer5()
        {
            InitializeComponent();
        }

        private void Exer5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 5", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            double n = System.Convert.ToDouble(txbNumero.Text);
            double i = 0;

            while (i < n)
            {
                i++;

                if (i <= n)
                {
                    MessageBox.Show(i.ToString());

                    if (n > 50)
                    {
                        MessageBox.Show("Esse número excede o valor!");
                    }
                }
            }
        }
    }
}
