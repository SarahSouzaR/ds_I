namespace Atividade1_7
{
    partial class Exer2
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btnDez = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(40, 29);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(70, 16);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número: ";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(131, 29);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 20);
            this.txbNum.TabIndex = 1;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(32, 74);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(229, 16);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Descubra se é divisível por 10, 5 ou 2";
            // 
            // btnDez
            // 
            this.btnDez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDez.Location = new System.Drawing.Point(56, 112);
            this.btnDez.Name = "btnDez";
            this.btnDez.Size = new System.Drawing.Size(152, 24);
            this.btnDez.TabIndex = 3;
            this.btnDez.Text = "Divisível ?";
            this.btnDez.UseVisualStyleBackColor = true;
            this.btnDez.Click += new System.EventHandler(this.btnDez_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(32, 158);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(11, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = " ";
            // 
            // Exer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDez);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Exer2";
            this.Text = "Exer2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Button btnDez;
        private System.Windows.Forms.Label lblResult;
    }
}