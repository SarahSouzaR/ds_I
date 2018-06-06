namespace Atividade1_7
{
    partial class Exer6
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
            this.btnExibe = new System.Windows.Forms.Button();
            this.lblVezes = new System.Windows.Forms.Label();
            this.txbVezes = new System.Windows.Forms.TextBox();
            this.lblBrasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExibe
            // 
            this.btnExibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibe.Location = new System.Drawing.Point(84, 70);
            this.btnExibe.Name = "btnExibe";
            this.btnExibe.Size = new System.Drawing.Size(87, 23);
            this.btnExibe.TabIndex = 0;
            this.btnExibe.Text = "Exibir";
            this.btnExibe.UseVisualStyleBackColor = true;
            this.btnExibe.Click += new System.EventHandler(this.btnExibe_Click);
            // 
            // lblVezes
            // 
            this.lblVezes.AutoSize = true;
            this.lblVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezes.Location = new System.Drawing.Point(25, 38);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(108, 15);
            this.lblVezes.TabIndex = 1;
            this.lblVezes.Text = "Número de Vezes:";
            // 
            // txbVezes
            // 
            this.txbVezes.Location = new System.Drawing.Point(142, 35);
            this.txbVezes.Name = "txbVezes";
            this.txbVezes.Size = new System.Drawing.Size(100, 20);
            this.txbVezes.TabIndex = 2;
            // 
            // lblBrasil
            // 
            this.lblBrasil.AutoSize = true;
            this.lblBrasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrasil.Location = new System.Drawing.Point(38, 108);
            this.lblBrasil.Name = "lblBrasil";
            this.lblBrasil.Size = new System.Drawing.Size(0, 15);
            this.lblBrasil.TabIndex = 3;
            // 
            // Exer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblBrasil);
            this.Controls.Add(this.txbVezes);
            this.Controls.Add(this.lblVezes);
            this.Controls.Add(this.btnExibe);
            this.Name = "Exer6";
            this.Text = "Exer6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer6_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibe;
        private System.Windows.Forms.Label lblVezes;
        private System.Windows.Forms.TextBox txbVezes;
        private System.Windows.Forms.Label lblBrasil;
    }
}