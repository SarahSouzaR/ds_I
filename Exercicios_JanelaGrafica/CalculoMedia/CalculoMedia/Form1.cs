using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txb1Bim.Text);
            double valor2 = System.Convert.ToDouble(txb2Bim.Text);
            double valor3 = System.Convert.ToDouble(txb3Bim.Text);
            double valor4 = System.Convert.ToDouble(txb4Bim.Text);

            double media = (valor1 + valor2 + valor3 + valor4)/4;

            string nome = txbNome.Text;

            lblNome.Text = nome;

            lblMedia.Text = "Sua média é: " + media.ToString();

        }

        
    }
}
