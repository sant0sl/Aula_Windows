namespace Windows_Forms1.Forms
{
    partial class ExecutarArquivos
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
            this.btnNavegador = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnMusica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavegador
            // 
            this.btnNavegador.Location = new System.Drawing.Point(12, 12);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(95, 28);
            this.btnNavegador.TabIndex = 0;
            this.btnNavegador.Text = "Browser";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(127, 12);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(111, 28);
            this.btnNotepad.TabIndex = 1;
            this.btnNotepad.Text = "Bloco de Notas";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnMusica
            // 
            this.btnMusica.Location = new System.Drawing.Point(259, 12);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(102, 28);
            this.btnMusica.TabIndex = 2;
            this.btnMusica.Text = "Música";
            this.btnMusica.UseVisualStyleBackColor = true;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
            // 
            // ExecutarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(383, 56);
            this.Controls.Add(this.btnMusica);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnNavegador);
            this.MaximizeBox = false;
            this.Name = "ExecutarArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExecutarArquivos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnMusica;
    }
}