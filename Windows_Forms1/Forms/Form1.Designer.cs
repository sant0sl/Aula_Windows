namespace Windows_Forms1
{
    partial class Form1
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lbl_NCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnUnir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(14, 16);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(64, 25);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sobrenome.Location = new System.Drawing.Point(285, 16);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(114, 25);
            this.lbl_Sobrenome.TabIndex = 2;
            this.lbl_Sobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(406, 20);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(239, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // lbl_NCompleto
            // 
            this.lbl_NCompleto.AutoSize = true;
            this.lbl_NCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NCompleto.Location = new System.Drawing.Point(14, 130);
            this.lbl_NCompleto.Name = "lbl_NCompleto";
            this.lbl_NCompleto.Size = new System.Drawing.Size(153, 25);
            this.lbl_NCompleto.TabIndex = 4;
            this.lbl_NCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(174, 134);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(471, 20);
            this.txtNomeCompleto.TabIndex = 5;
            // 
            // btnUnir
            // 
            this.btnUnir.Location = new System.Drawing.Point(217, 75);
            this.btnUnir.Name = "btnUnir";
            this.btnUnir.Size = new System.Drawing.Size(241, 23);
            this.btnUnir.TabIndex = 6;
            this.btnUnir.Text = "União";
            this.btnUnir.UseVisualStyleBackColor = true;
            this.btnUnir.Click += new System.EventHandler(this.btnUnir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(668, 180);
            this.Controls.Add(this.btnUnir);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lbl_NCompleto);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lbl_NCompleto;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button btnUnir;
    }
}

