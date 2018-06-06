namespace Atividade1_7
{
    partial class Exer4
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
            this.lblMes = new System.Windows.Forms.Label();
            this.txbMes = new System.Windows.Forms.TextBox();
            this.btnCorresponde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEscreve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(61, 30);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(45, 16);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mês: ";
            // 
            // txbMes
            // 
            this.txbMes.Location = new System.Drawing.Point(112, 29);
            this.txbMes.Name = "txbMes";
            this.txbMes.Size = new System.Drawing.Size(100, 20);
            this.txbMes.TabIndex = 1;
            // 
            // btnCorresponde
            // 
            this.btnCorresponde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorresponde.Location = new System.Drawing.Point(90, 73);
            this.btnCorresponde.Name = "btnCorresponde";
            this.btnCorresponde.Size = new System.Drawing.Size(89, 26);
            this.btnCorresponde.TabIndex = 2;
            this.btnCorresponde.Text = "Verificar";
            this.btnCorresponde.UseVisualStyleBackColor = true;
            this.btnCorresponde.Click += new System.EventHandler(this.btnCorresponde_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Corresponde ao mês de: ";
            // 
            // lblEscreve
            // 
            this.lblEscreve.AutoSize = true;
            this.lblEscreve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreve.Location = new System.Drawing.Point(64, 148);
            this.lblEscreve.Name = "lblEscreve";
            this.lblEscreve.Size = new System.Drawing.Size(0, 16);
            this.lblEscreve.TabIndex = 4;
            // 
            // Exer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblEscreve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCorresponde);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.lblMes);
            this.Name = "Exer4";
            this.Text = "Exer4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txbMes;
        private System.Windows.Forms.Button btnCorresponde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEscreve;
    }
}