using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnSoma_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txtNum1.Text);
            double dNum2 = System.Convert.ToDouble(txtNum2.Text);
            double dSoma = dNum1 + dNum2;
            label1.Text = dSoma.ToString();
        }

       
    }
}
