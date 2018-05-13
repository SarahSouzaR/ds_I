using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace Calculadora_2
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private double ProcessarCommando(string command)
        {
            //Cria um provedor de Código C#
            CSharpCodeProvider mCodeProvider = new CSharpCodeProvider();
            // Cria os parâmetros para a compilação origem
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateExecutable = false;    //Não precisa criar um arquivo EXE
            cp.GenerateInMemory = true;       //Cria um na memória
            cp.OutputAssembly = "TempModule"; // Isso não é necessário, no entanto, se usado ​​repetidamente, faz com que o CLR não precisa carregar uma novo assembly cada vez que a função é executada.
            // A string abaixo é basicamente a casca do programa C #, que não faz nada, mas contém um método Avaliar() para nossos propósitos. 
       
            string TempModuleSource = "namespace ns{" +
                                      "using System;" +
                                      "class class1{" +
                                      "public static double Evaluate(){return " + command + ";}}} ";  //Calcula a expressão

            CompilerResults cr = mCodeProvider.CompileAssemblyFromSource(cp, TempModuleSource);
            if (cr.Errors.Count > 0)
            {
                //Se um erro de compilação é gerado, iremos lançar uma exceção
                //A sintaxe estava errado - novamente, isso é deixado ao implementador para verificar sintaxe antes
                //Chamando a função. O código de chamada pode prender isso em um laço try, e notificar o usuário
                //O comando não foi compreendido, por exemplo.
                throw new ArgumentException("A expressão não pode ser avaliada, utiliza uma expressão C# válida...");
            }
            else
            {
                MethodInfo Methinfo = cr.CompiledAssembly.GetType("ns.class1").GetMethod("Evaluate");
                return (double)Methinfo.Invoke(null, null);
            }
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
            txbVisor.Text = txbVisor.Text + " + ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + " - ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + " * ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + " / ";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            try
            {
                txbResultado.Text = ProcessarCommando(txbVisor.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao avaliar a expressão..." + ex.Message.ToString() + ".");
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
            txbResultado.Text = "";
        }

    }
}