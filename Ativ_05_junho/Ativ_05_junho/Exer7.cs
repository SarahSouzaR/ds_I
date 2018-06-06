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
    public partial class Exer7 : Form
    {
        public Exer7()
        {
            InitializeComponent();
        }

        private void Exer7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 7", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double a = 1.50; 
            double m = 1.10;
            int i = 1;

            while (m < a)
            {
                i++;

                a = a + 0.02;
                m = m + 0.03;
            }

            lblFinal.Text = "Depois de " + System.Convert.ToString(i) + " anos, Manoel será maior.\nCom " + m + "m de altura.\nE Arlindo com " + a + "m.";

        }
    }
}
