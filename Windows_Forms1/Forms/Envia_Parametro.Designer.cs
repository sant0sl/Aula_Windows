namespace Windows_Forms1.Forms
{
    partial class Envia_Parametro
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
            this.btnEnvia = new System.Windows.Forms.Button();
            this.txtEnviaParametro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(112, 121);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(75, 23);
            this.btnEnvia.TabIndex = 0;
            this.btnEnvia.Text = "Enviar";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // txtEnviaParametro
            // 
            this.txtEnviaParametro.Location = new System.Drawing.Point(35, 62);
            this.txtEnviaParametro.Name = "txtEnviaParametro";
            this.txtEnviaParametro.Size = new System.Drawing.Size(241, 20);
            this.txtEnviaParametro.TabIndex = 1;
            this.txtEnviaParametro.TextChanged += new System.EventHandler(this.txtEnviaParametro_TextChanged);
            // 
            // Envia_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 182);
            this.Controls.Add(this.txtEnviaParametro);
            this.Controls.Add(this.btnEnvia);
            this.Name = "Envia_Parametro";
            this.Text = "Envia_Parametro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.TextBox txtEnviaParametro;
    }
}