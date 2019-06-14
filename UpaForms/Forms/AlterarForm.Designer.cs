namespace UpaForms.Forms
{
    partial class AlterarForm
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeCrianca = new System.Windows.Forms.TextBox();
            this.lblNomeCrianca = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(266, 172);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 31);
            this.btnAlterar.TabIndex = 39;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(159, 172);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 31);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(23, 178);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(69, 20);
            this.txtIdade.TabIndex = 37;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(19, 155);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(134, 20);
            this.lblSenha.TabIndex = 36;
            this.lblSenha.Text = "Idade da Criança:";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(23, 132);
            this.txtNomeMae.MaxLength = 100;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(320, 20);
            this.txtNomeMae.TabIndex = 35;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(184, 20);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Nome Completo da Mãe:";
            // 
            // txtNomeCrianca
            // 
            this.txtNomeCrianca.Location = new System.Drawing.Point(23, 86);
            this.txtNomeCrianca.MaxLength = 100;
            this.txtNomeCrianca.Name = "txtNomeCrianca";
            this.txtNomeCrianca.Size = new System.Drawing.Size(320, 20);
            this.txtNomeCrianca.TabIndex = 33;
            // 
            // lblNomeCrianca
            // 
            this.lblNomeCrianca.AutoSize = true;
            this.lblNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCrianca.Location = new System.Drawing.Point(19, 63);
            this.lblNomeCrianca.Name = "lblNomeCrianca";
            this.lblNomeCrianca.Size = new System.Drawing.Size(207, 20);
            this.lblNomeCrianca.TabIndex = 32;
            this.lblNomeCrianca.Text = "Nome Completo da Criança:";
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(23, 40);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(161, 20);
            this.txtCPF.TabIndex = 31;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(19, 17);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(124, 20);
            this.lblCPF.TabIndex = 30;
            this.lblCPF.Text = "CPF da Criança:";
            // 
            // AlterarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(387, 221);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeCrianca);
            this.Controls.Add(this.lblNomeCrianca);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.MaximizeBox = false;
            this.Name = "AlterarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeCrianca;
        private System.Windows.Forms.Label lblNomeCrianca;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
    }
}