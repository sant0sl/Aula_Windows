namespace Windows_Forms1.Forms
{
    partial class FormThread
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(30, 24);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(73, 22);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Número";
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(219, 24);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(75, 23);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Iniciar";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(34, 74);
            this.progressBar.Maximum = 50000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(196, 103);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(98, 30);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // FormThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(329, 168);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.lblNumeros);
            this.MaximizeBox = false;
            this.Name = "FormThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThread_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCarregar;
    }
}