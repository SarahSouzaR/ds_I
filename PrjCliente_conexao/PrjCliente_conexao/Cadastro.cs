using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrjCliente_conexao
{
    public partial class Cadastro : Form
    {
        //Conectar através da classe conexão
        OleDbConnection conn = Conexao.obterConexao();
        //Declarando o DataReader -- tabela virtual somente leitura
        OleDbDataReader dr_clientes;
        //Declarando o BindingSource -- tabela virtual editável
        BindingSource bs_clientes = new BindingSource();
        //cria a variável que receberá a query (comando sql (não é access?))
        String _query;

        private void carregar_grid()
        {
            //se não der certo colocar em um try
            //Determine a query desejada
            try
            {
                _query = "Select * from tb_cliente";
                //declare o objeto DataCommand passando a query e o objeto de conexão
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                //execute o método ExecuteReade r que retornará um DataReader preenchido com a query

                dr_clientes = _dataCommand.ExecuteReader();
                //Teste para verificar se retornaram linhas
                if (dr_clientes.HasRows == true)
                {
                    bs_clientes.DataSource = dr_clientes;
                    dgv_clientes.DataSource = bs_clientes;
                    igualar_text();
                }

                else
                {
                    MessageBox.Show("Não temos clientes cadastrados!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro bla");
            }
        }

        private void igualar_text()
        {
            lbl_Matricula.DataBindings.Add("Text", bs_clientes, "Matricula");
            lbl_Matricula.DataBindings.Clear();
            txt_Nome.DataBindings.Add("Text", bs_clientes, "Nome");
            txt_Nome.DataBindings.Clear();
            txt_endereco.DataBindings.Add("Text", bs_clientes, "Endereco");
            txt_endereco.DataBindings.Clear();
            txt_numero.DataBindings.Add("Text", bs_clientes, "numero");
            txt_numero.DataBindings.Clear();
            msk_cep.DataBindings.Add("Text", bs_clientes, "cep");
            msk_cep.DataBindings.Clear();
            dtp_nasc.DataBindings.Add("Text", bs_clientes, "Nasc");
            dtp_nasc.DataBindings.Clear();
        }

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechando Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)MessageBox.Show("Saindo");

            else 
            {
                MessageBox.Show("Cancelando");
                e.Cancel = true;
            }
        }



        private void Cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bD_Cliente1DataSet.tb_cliente' table. You can move, or remove it, as needed.
                this.tb_clienteTableAdapter.Fill(this.bD_Cliente1DataSet.tb_cliente);
                //Alimenta o datagridview com dados
                carregar_grid();
            }
            catch (Exception exce)
            {
                MessageBox.Show("Erro2222");
            }
        }

        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgv_clientes_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txb_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from tb_cliente where nome like '" + txbPesquisa.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else 
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisa.Text = "";
            }
        }

    }
}
