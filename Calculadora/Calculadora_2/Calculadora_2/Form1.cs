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
        double n1 = 0, n2 = 0, n3 = 0, resultado = 0, variavel1 = 0, variavel2 = 0; 
        //n1 = primeiro número que clicar, n2 o segundo
        //variavel1 para armazenar o primeiro número e a operação do botão
        
        int operacao;

        bool res = false; //string booleana para verificar se tem algo no visor


        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(1);
                if (n1 != 0)
                    n2 = 1;
                else n1 = 1;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(2);
                if (n1 != 0)
                    n2 = 2;
                else n1 = 2;
            } 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(3);
                if (n1 != 0)
                    n2 = 3;
                else n1 = 3;
            } 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(4);
                if (n1 != 0)
                    n2 = 4;
                else n1 = 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(5);
                if (n1 != 0)
                    n2 = 5;
                else n1 = 5;
            } 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(6);
                if (n1 != 0)
                    n2 = 6;
                else n1 = 6;
            } 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(7);
                if (n1 != 0)
                    n2 = 7;
                else n1 = 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(8);
                if (n1 != 0)
                    n2 = 8;
                else n1 = 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(9);
                if (n1 != 0)
                    n2 = 9;
                else n1 = 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (res)
                txbVisor.Text = "";
            res = false;
            if (res == false)
            {
                txbVisor.Text += Convert.ToString(0);
                if (n1 != 0)
                    n2 = 0;
                else n1 = 0;
            } 
            //txbVisor.Text = txbVisor.Text + 0;
            /*mais simples e também funciona, mas na hora de fazer a expressão
             pode ser melhor para verificar os valores e na entrada de mais números*/ 
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            operacao = 1; //função de adição
            variavel1 = System.Convert.ToDouble(txbVisor.Text); //armazenando o valor do visor
            txbVisor.Text = ""; //zerado para receber o segundo número
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operacao = 2;
            variavel1 = System.Convert.ToDouble(txbVisor.Text);
            txbVisor.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacao = 3;
            variavel1 = System.Convert.ToDouble(txbVisor.Text);
            txbVisor.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacao = 4;
            variavel1 = System.Convert.ToDouble(txbVisor.Text);
            txbVisor.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txbVisor.Text);

            if (operacao == 1)
                resultado = variavel1 + n2;

            if (operacao == 2)
                resultado = variavel1 - n2;

            if (operacao == 3)
                resultado = variavel1 * n2;

            if (operacao == 4)
                resultado = variavel1 / n2;
            
            txbVisor.Text = Convert.ToString(resultado);
            
            variavel1 = System.Convert.ToDouble(txbVisor.Text);
            
            res = true;

            //MessageBox.Show(); //ABRE UMA JANELA COM MENSAGEM
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
            n1 = 0;
            variavel1 = 0;
            n2 = 0;
        }
    }
}
