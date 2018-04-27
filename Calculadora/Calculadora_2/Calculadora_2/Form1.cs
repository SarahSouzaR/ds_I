using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 0;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbVisor.Text);
            double valor2 = System.Convert.ToDouble(txbVisor.Text);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnMult_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
