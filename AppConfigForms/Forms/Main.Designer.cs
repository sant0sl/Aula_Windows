namespace AppConfigForms.Forms
{
    partial class Main
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
            this.btnRecuperarNome = new System.Windows.Forms.Button();
            this.txtValorRecuperado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNomeCampoValor = new System.Windows.Forms.TextBox();
            this.txtValorNovo = new System.Windows.Forms.TextBox();
            this.btnNovoValor = new System.Windows.Forms.Button();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNomeCampoRecuperar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecuperarNome
            // 
            this.btnRecuperarNome.Location = new System.Drawing.Point(12, 87);
            this.btnRecuperarNome.Name = "btnRecuperarNome";
            this.btnRecuperarNome.Size = new System.Drawing.Size(230, 28);
            this.btnRecuperarNome.TabIndex = 0;
            this.btnRecuperarNome.Text = "Recuperar Valor";
            this.btnRecuperarNome.UseVisualStyleBackColor = true;
            this.btnRecuperarNome.Click += new System.EventHandler(this.btnRecuperarNome_Click);
            // 
            // txtValorRecuperado
            // 
            this.txtValorRecuperado.Enabled = false;
            this.txtValorRecuperado.Location = new System.Drawing.Point(130, 61);
            this.txtValorRecuperado.Name = "txtValorRecuperado";
            this.txtValorRecuperado.Size = new System.Drawing.Size(112, 20);
            this.txtValorRecuperado.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(156, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 28);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 153);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 28);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar Valor";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(230, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(202, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 28);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNomeCampoValor
            // 
            this.txtNomeCampoValor.Location = new System.Drawing.Point(12, 212);
            this.txtNomeCampoValor.Name = "txtNomeCampoValor";
            this.txtNomeCampoValor.Size = new System.Drawing.Size(112, 20);
            this.txtNomeCampoValor.TabIndex = 6;
            // 
            // txtValorNovo
            // 
            this.txtValorNovo.Location = new System.Drawing.Point(130, 212);
            this.txtValorNovo.Name = "txtValorNovo";
            this.txtValorNovo.Size = new System.Drawing.Size(112, 20);
            this.txtValorNovo.TabIndex = 7;
            // 
            // btnNovoValor
            // 
            this.btnNovoValor.Location = new System.Drawing.Point(12, 238);
            this.btnNovoValor.Name = "btnNovoValor";
            this.btnNovoValor.Size = new System.Drawing.Size(230, 28);
            this.btnNovoValor.TabIndex = 8;
            this.btnNovoValor.Text = "Novo Valor";
            this.btnNovoValor.UseVisualStyleBackColor = true;
            this.btnNovoValor.Click += new System.EventHandler(this.btnNovoValor_Click);
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Location = new System.Drawing.Point(13, 193);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(89, 13);
            this.lblNomeCampo.TabIndex = 9;
            this.lblNomeCampo.Text = "Nome do Campo:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(127, 193);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor:";
            // 
            // txtNomeCampoRecuperar
            // 
            this.txtNomeCampoRecuperar.Location = new System.Drawing.Point(12, 61);
            this.txtNomeCampoRecuperar.Name = "txtNomeCampoRecuperar";
            this.txtNomeCampoRecuperar.Size = new System.Drawing.Size(112, 20);
            this.txtNomeCampoRecuperar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome do Campo:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(130, 153);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(112, 28);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover Valor";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(254, 281);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCampoRecuperar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNomeCampo);
            this.Controls.Add(this.btnNovoValor);
            this.Controls.Add(this.txtValorNovo);
            this.Controls.Add(this.txtNomeCampoValor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValorRecuperado);
            this.Controls.Add(this.btnRecuperarNome);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppConfigForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecuperarNome;
        private System.Windows.Forms.TextBox txtValorRecuperado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNomeCampoValor;
        private System.Windows.Forms.TextBox txtValorNovo;
        private System.Windows.Forms.Button btnNovoValor;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNomeCampoRecuperar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
    }
}