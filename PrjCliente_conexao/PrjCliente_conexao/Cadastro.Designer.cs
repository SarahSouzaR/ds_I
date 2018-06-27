namespace PrjCliente_conexao
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.dtp_nasc = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.bntUltimo = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Cliente1DataSet = new PrjCliente_conexao.BD_Cliente1DataSet();
            this.tb_clienteTableAdapter = new PrjCliente_conexao.BD_Cliente1DataSetTableAdapters.tb_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Cliente1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(45, 31);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(75, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula::";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 70);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome::";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(44, 107);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(91, 15);
            this.lblNasc.TabIndex = 2;
            this.lblNasc.Text = "Nascimento::";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(44, 146);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(76, 15);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Endereço::";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(44, 183);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(66, 15);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Número::";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(152, 31);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(0, 15);
            this.lbl_Matricula.TabIndex = 5;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(155, 67);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(297, 21);
            this.txt_Nome.TabIndex = 6;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(155, 183);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 21);
            this.txt_numero.TabIndex = 7;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(155, 143);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(297, 21);
            this.txt_endereco.TabIndex = 8;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(295, 183);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 15);
            this.lblCep.TabIndex = 9;
            this.lblCep.Text = "CEP::";
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(352, 180);
            this.msk_cep.Mask = "00000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(100, 21);
            this.msk_cep.TabIndex = 11;
            // 
            // dtp_nasc
            // 
            this.dtp_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nasc.Location = new System.Drawing.Point(155, 107);
            this.dtp_nasc.Name = "dtp_nasc";
            this.dtp_nasc.Size = new System.Drawing.Size(136, 21);
            this.dtp_nasc.TabIndex = 12;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(524, 48);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 13;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(524, 99);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(524, 146);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(524, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(45, 243);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 17;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(155, 243);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(262, 243);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // bntUltimo
            // 
            this.bntUltimo.Location = new System.Drawing.Point(377, 243);
            this.bntUltimo.Name = "bntUltimo";
            this.bntUltimo.Size = new System.Drawing.Size(75, 23);
            this.bntUltimo.TabIndex = 20;
            this.bntUltimo.Text = "Último";
            this.bntUltimo.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(50, 420);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(144, 15);
            this.lblPesquisa.TabIndex = 22;
            this.lblPesquisa.Text = "Pesquisar por nome::";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(219, 417);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(218, 21);
            this.txbPesquisa.TabIndex = 23;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoGenerateColumns = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.DataSource = this.tbclienteBindingSource;
            this.dgv_clientes.Location = new System.Drawing.Point(45, 285);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(551, 105);
            this.dgv_clientes.TabIndex = 24;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.bD_Cliente1DataSet;
            // 
            // bD_Cliente1DataSet
            // 
            this.bD_Cliente1DataSet.DataSetName = "BD_Cliente1DataSet";
            this.bD_Cliente1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 488);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.bntUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dtp_nasc);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cadastro";
            this.Text = "Cadastro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Load);
            //this.Shown += new System.EventHandler(this.Cadastro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Cliente1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.DateTimePicker dtp_nasc;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button bntUltimo;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private BD_Cliente1DataSet bD_Cliente1DataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private BD_Cliente1DataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
    }
}