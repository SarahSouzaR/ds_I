namespace Atividade1_7
{
    partial class Exer7
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
            this.lblArlindo = new System.Windows.Forms.Label();
            this.lblManoel = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArlindo
            // 
            this.lblArlindo.AutoSize = true;
            this.lblArlindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArlindo.Location = new System.Drawing.Point(29, 44);
            this.lblArlindo.Name = "lblArlindo";
            this.lblArlindo.Size = new System.Drawing.Size(108, 15);
            this.lblArlindo.TabIndex = 0;
            this.lblArlindo.Text = "Arlindo:  1,50 m";
            // 
            // lblManoel
            // 
            this.lblManoel.AutoSize = true;
            this.lblManoel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoel.Location = new System.Drawing.Point(165, 44);
            this.lblManoel.Name = "lblManoel";
            this.lblManoel.Size = new System.Drawing.Size(107, 15);
            this.lblManoel.TabIndex = 1;
            this.lblManoel.Text = "Manoel: 1,10 m";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(30, 130);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 16);
            this.lblFinal.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(62, 86);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Exer7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 273);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblManoel);
            this.Controls.Add(this.lblArlindo);
            this.Name = "Exer7";
            this.Text = "Exer7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer7_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArlindo;
        private System.Windows.Forms.Label lblManoel;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnVerificar;
    }
}