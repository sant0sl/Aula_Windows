namespace Windows_Forms1.Forms
{
    partial class CEPForm
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.groupBoxLocalizacao = new System.Windows.Forms.GroupBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEPResult = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.groupBoxLocalizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(268, 68);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 26);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(151, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 26);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(230, 39);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 15;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(187, 42);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 14;
            this.lblCEP.Text = "CEP:";
            // 
            // groupBoxLocalizacao
            // 
            this.groupBoxLocalizacao.Controls.Add(this.lblTelefone);
            this.groupBoxLocalizacao.Controls.Add(this.txtComplemento2);
            this.groupBoxLocalizacao.Controls.Add(this.label1);
            this.groupBoxLocalizacao.Controls.Add(this.txtCEPResult);
            this.groupBoxLocalizacao.Controls.Add(this.lblComplemento);
            this.groupBoxLocalizacao.Controls.Add(this.txtComplemento);
            this.groupBoxLocalizacao.Controls.Add(this.lblUF);
            this.groupBoxLocalizacao.Controls.Add(this.txtUF);
            this.groupBoxLocalizacao.Controls.Add(this.lblMunicipio);
            this.groupBoxLocalizacao.Controls.Add(this.txtMunicipio);
            this.groupBoxLocalizacao.Controls.Add(this.lblBairro);
            this.groupBoxLocalizacao.Controls.Add(this.txtBairro);
            this.groupBoxLocalizacao.Controls.Add(this.lblLogradouro);
            this.groupBoxLocalizacao.Controls.Add(this.txtLogradouro);
            this.groupBoxLocalizacao.Location = new System.Drawing.Point(25, 122);
            this.groupBoxLocalizacao.Name = "groupBoxLocalizacao";
            this.groupBoxLocalizacao.Size = new System.Drawing.Size(458, 194);
            this.groupBoxLocalizacao.TabIndex = 26;
            this.groupBoxLocalizacao.TabStop = false;
            this.groupBoxLocalizacao.Text = "Localização";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(240, 81);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(83, 13);
            this.lblTelefone.TabIndex = 32;
            this.lblTelefone.Text = "Complemento 2:";
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Enabled = false;
            this.txtComplemento2.Location = new System.Drawing.Point(243, 97);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(173, 20);
            this.txtComplemento2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "CEP:";
            // 
            // txtCEPResult
            // 
            this.txtCEPResult.Enabled = false;
            this.txtCEPResult.Location = new System.Drawing.Point(325, 142);
            this.txtCEPResult.Name = "txtCEPResult";
            this.txtCEPResult.Size = new System.Drawing.Size(91, 20);
            this.txtCEPResult.TabIndex = 29;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(44, 81);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(47, 97);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(179, 20);
            this.txtComplemento.TabIndex = 27;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(252, 126);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 24;
            this.lblUF.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(255, 142);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(54, 20);
            this.txtUF.TabIndex = 25;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(44, 126);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 22;
            this.lblMunicipio.Text = "Município:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.Location = new System.Drawing.Point(47, 142);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(188, 20);
            this.txtMunicipio.TabIndex = 23;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(286, 33);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(289, 49);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(127, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(44, 33);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 18;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(47, 49);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(223, 20);
            this.txtLogradouro.TabIndex = 19;
            // 
            // CEPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(508, 342);
            this.Controls.Add(this.groupBoxLocalizacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblCEP);
            this.MaximizeBox = false;
            this.Name = "CEPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEPForm";
            this.groupBoxLocalizacao.ResumeLayout(false);
            this.groupBoxLocalizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.GroupBox groupBoxLocalizacao;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtComplemento2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEPResult;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
    }
}