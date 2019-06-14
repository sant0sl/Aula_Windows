namespace BancoEletronico_Forms.Forms
{
    partial class TransferenciaForm
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
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomeCompletoEmissor = new System.Windows.Forms.TextBox();
            this.lblNomeEmissor = new System.Windows.Forms.Label();
            this.txtCPFEmissor = new System.Windows.Forms.TextBox();
            this.lblCPFEmissor = new System.Windows.Forms.Label();
            this.txtNomeCompletoRecebedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPFRecebedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(254, 299);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(101, 31);
            this.btnTransferir.TabIndex = 19;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(35, 299);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 31);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomeCompletoEmissor
            // 
            this.txtNomeCompletoEmissor.Enabled = false;
            this.txtNomeCompletoEmissor.Location = new System.Drawing.Point(35, 99);
            this.txtNomeCompletoEmissor.MaxLength = 100;
            this.txtNomeCompletoEmissor.Name = "txtNomeCompletoEmissor";
            this.txtNomeCompletoEmissor.Size = new System.Drawing.Size(320, 20);
            this.txtNomeCompletoEmissor.TabIndex = 13;
            // 
            // lblNomeEmissor
            // 
            this.lblNomeEmissor.AutoSize = true;
            this.lblNomeEmissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmissor.Location = new System.Drawing.Point(31, 76);
            this.lblNomeEmissor.Name = "lblNomeEmissor";
            this.lblNomeEmissor.Size = new System.Drawing.Size(116, 20);
            this.lblNomeEmissor.TabIndex = 12;
            this.lblNomeEmissor.Text = "Nome Emissor:";
            // 
            // txtCPFEmissor
            // 
            this.txtCPFEmissor.Enabled = false;
            this.txtCPFEmissor.Location = new System.Drawing.Point(35, 53);
            this.txtCPFEmissor.MaxLength = 11;
            this.txtCPFEmissor.Name = "txtCPFEmissor";
            this.txtCPFEmissor.Size = new System.Drawing.Size(161, 20);
            this.txtCPFEmissor.TabIndex = 11;
            // 
            // lblCPFEmissor
            // 
            this.lblCPFEmissor.AutoSize = true;
            this.lblCPFEmissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFEmissor.Location = new System.Drawing.Point(31, 30);
            this.lblCPFEmissor.Name = "lblCPFEmissor";
            this.lblCPFEmissor.Size = new System.Drawing.Size(105, 20);
            this.lblCPFEmissor.TabIndex = 10;
            this.lblCPFEmissor.Text = "CPF Emissor:";
            // 
            // txtNomeCompletoRecebedor
            // 
            this.txtNomeCompletoRecebedor.Enabled = false;
            this.txtNomeCompletoRecebedor.Location = new System.Drawing.Point(35, 191);
            this.txtNomeCompletoRecebedor.MaxLength = 100;
            this.txtNomeCompletoRecebedor.Name = "txtNomeCompletoRecebedor";
            this.txtNomeCompletoRecebedor.Size = new System.Drawing.Size(320, 20);
            this.txtNomeCompletoRecebedor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome Recebedor:";
            // 
            // txtCPFRecebedor
            // 
            this.txtCPFRecebedor.Location = new System.Drawing.Point(35, 145);
            this.txtCPFRecebedor.MaxLength = 11;
            this.txtCPFRecebedor.Name = "txtCPFRecebedor";
            this.txtCPFRecebedor.Size = new System.Drawing.Size(161, 20);
            this.txtCPFRecebedor.TabIndex = 21;
            this.txtCPFRecebedor.Leave += new System.EventHandler(this.txtCPFRecebedor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "CPF Recebedor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(175, 245);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 25;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(100, 240);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 25);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(142, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 31);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(391, 361);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNomeCompletoRecebedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPFRecebedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNomeCompletoEmissor);
            this.Controls.Add(this.lblNomeEmissor);
            this.Controls.Add(this.txtCPFEmissor);
            this.Controls.Add(this.lblCPFEmissor);
            this.MaximizeBox = false;
            this.Name = "TransferenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNomeCompletoEmissor;
        private System.Windows.Forms.Label lblNomeEmissor;
        private System.Windows.Forms.TextBox txtCPFEmissor;
        private System.Windows.Forms.Label lblCPFEmissor;
        private System.Windows.Forms.TextBox txtNomeCompletoRecebedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFRecebedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnLimpar;
    }
}