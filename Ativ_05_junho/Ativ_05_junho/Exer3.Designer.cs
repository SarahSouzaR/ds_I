namespace Atividade1_7
{
    partial class Exer3
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txbB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txbC = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(151, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Lados do Triângulo: ";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(60, 64);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 16);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A: ";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(102, 63);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(60, 101);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 16);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B: ";
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(102, 101);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 4;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(60, 141);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 16);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C: ";
            // 
            // txbC
            // 
            this.txbC.Location = new System.Drawing.Point(102, 137);
            this.txbC.Name = "txbC";
            this.txbC.Size = new System.Drawing.Size(100, 20);
            this.txbC.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(93, 180);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Exer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblNome);
            this.Name = "Exer3";
            this.Text = "Exer3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txbC;
        private System.Windows.Forms.Button btnVerificar;
    }
}