namespace Windows_Forms1.Forms
{
    partial class Envia_Parametro_Tabuada
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
            this.txtEnviaParametro = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnviaParametro
            // 
            this.txtEnviaParametro.Location = new System.Drawing.Point(104, 88);
            this.txtEnviaParametro.Name = "txtEnviaParametro";
            this.txtEnviaParametro.Size = new System.Drawing.Size(241, 20);
            this.txtEnviaParametro.TabIndex = 3;
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(159, 165);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(124, 23);
            this.btnEnvia.TabIndex = 2;
            this.btnEnvia.Text = "Tabuada do Nº";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // Envia_Parametro_Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 259);
            this.Controls.Add(this.txtEnviaParametro);
            this.Controls.Add(this.btnEnvia);
            this.Name = "Envia_Parametro_Tabuada";
            this.Text = "Envia_Parametro_Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnviaParametro;
        private System.Windows.Forms.Button btnEnvia;
    }
}