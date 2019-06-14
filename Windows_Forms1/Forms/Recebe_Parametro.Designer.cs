namespace Windows_Forms1.Forms
{
    partial class Recebe_Parametro
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
            this.txtRecebeParametro = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecebeParametro
            // 
            this.txtRecebeParametro.Location = new System.Drawing.Point(32, 61);
            this.txtRecebeParametro.Name = "txtRecebeParametro";
            this.txtRecebeParametro.ReadOnly = true;
            this.txtRecebeParametro.Size = new System.Drawing.Size(253, 20);
            this.txtRecebeParametro.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(121, 112);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Recebe_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 182);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtRecebeParametro);
            this.Name = "Recebe_Parametro";
            this.Text = "Recebe_Parametro";
            this.Load += new System.EventHandler(this.Recebe_Parametro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecebeParametro;
        private System.Windows.Forms.Button btnFechar;
    }
}