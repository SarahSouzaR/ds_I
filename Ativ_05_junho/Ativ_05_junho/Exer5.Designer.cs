namespace Atividade1_7
{
    partial class Exer5
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(49, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(70, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número: ";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(137, 32);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(93, 68);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(81, 26);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Location = new System.Drawing.Point(60, 109);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(10, 13);
            this.lblOk.TabIndex = 3;
            this.lblOk.Text = " ";
            // 
            // Exer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Exer5";
            this.Text = "Exer5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblOk;
    }
}