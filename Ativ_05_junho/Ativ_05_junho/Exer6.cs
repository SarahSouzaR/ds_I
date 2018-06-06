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
    public partial class Exer6 : Form
    {
        public Exer6()
        {
            InitializeComponent();
        }

        private void Exer6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 6", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnExibe_Click(object sender, EventArgs e)
        {
            double v = System.Convert.ToDouble(txbVezes.Text);
            lblBrasil.Text = "";

            for (int i = 1; i <= v; i++) 
            {
                if (lblBrasil.Text == "")
                {
                    lblBrasil.Text = "Brasil" + "\n";
                }
                else
                {
                    lblBrasil.Text = lblBrasil.Text + "Brasil" + "\n";
                }
            }
        }
    }
}
