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
    public partial class Exer4 : Form
    {
        public Exer4()
        {
            InitializeComponent();
        }

        private void Exer4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Exercício 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo!");
            else
            {
                MessageBox.Show("Cancelando!");
                e.Cancel = true;
            }
        }

        private void btnCorresponde_Click(object sender, EventArgs e)
        {
            double mes = System.Convert.ToDouble(txbMes.Text);

            if (mes == 1) 
            {
                lblEscreve.Text = "Janeiro";
            }
            else if (mes == 2)
            {
                lblEscreve.Text = "Fevereiro";
            }
            else if (mes == 3)
            {
                lblEscreve.Text = "Março";
            }
            else if (mes == 4)
            {
                lblEscreve.Text = "Abril";
            }
            else if (mes == 5)
            {
                lblEscreve.Text = "Maio";
            }
            else if (mes == 6)
            {
                lblEscreve.Text = "Junho";
            }
            else if (mes == 7)
            {
                lblEscreve.Text = "Julho";
            }
            else if (mes == 8)
            {
                lblEscreve.Text = "Agosto";
            }
            else if (mes == 9)
            {
                lblEscreve.Text = "Setembro";
            }
            else if (mes == 10)
            {
                lblEscreve.Text = "Outubro";
            }
            else if (mes == 11)
            {
                lblEscreve.Text = "Novembro";
            }
            else if (mes == 12)
            {
                lblEscreve.Text = "Dezembro";
            }
            else
            {
                lblEscreve.Text = "Não existe esse mês!";
            }
        }
    }
}
