namespace Windows_Forms1.Forms
{
    partial class CNPJCEP
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
            this.btnCNPJ = new System.Windows.Forms.Button();
            this.btnCEP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCNPJ
            // 
            this.btnCNPJ.Location = new System.Drawing.Point(31, 27);
            this.btnCNPJ.Name = "btnCNPJ";
            this.btnCNPJ.Size = new System.Drawing.Size(101, 31);
            this.btnCNPJ.TabIndex = 1;
            this.btnCNPJ.Text = "CNPJ";
            this.btnCNPJ.UseVisualStyleBackColor = true;
            this.btnCNPJ.Click += new System.EventHandler(this.btnCNPJ_Click);
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(138, 27);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(101, 31);
            this.btnCEP.TabIndex = 2;
            this.btnCEP.Text = "CEP";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // CNPJCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(273, 80);
            this.Controls.Add(this.btnCEP);
            this.Controls.Add(this.btnCNPJ);
            this.MaximizeBox = false;
            this.Name = "CNPJCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNPJ/CEP";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCNPJ;
        private System.Windows.Forms.Button btnCEP;
    }
}