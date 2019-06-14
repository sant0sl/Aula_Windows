namespace Windows_Forms1.Forms
{
    partial class Dll
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
            this.btnConsomeDLL = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsomeDLL
            // 
            this.btnConsomeDLL.Location = new System.Drawing.Point(270, 45);
            this.btnConsomeDLL.Name = "btnConsomeDLL";
            this.btnConsomeDLL.Size = new System.Drawing.Size(111, 34);
            this.btnConsomeDLL.TabIndex = 0;
            this.btnConsomeDLL.Text = "Consome";
            this.btnConsomeDLL.UseVisualStyleBackColor = true;
            this.btnConsomeDLL.Click += new System.EventHandler(this.btnConsomeDLL_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 42);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(37, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto:";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(16, 59);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(111, 20);
            this.txtOriginal.TabIndex = 2;
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(137, 59);
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(111, 20);
            this.txtRetorno.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maiúsculo:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(348, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(33, 26);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Dll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 92);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnConsomeDLL);
            this.MaximizeBox = false;
            this.Name = "Dll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsomeDLL;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
    }
}