namespace RevisaoBimestralForms.Forms
{
    partial class ServicoPC
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.rdbtnNaoPronto = new System.Windows.Forms.RadioButton();
            this.rdbtnPronto = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxPC = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtGabinete = new System.Windows.Forms.TextBox();
            this.lblGabinete = new System.Windows.Forms.Label();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.lblVGA = new System.Windows.Forms.Label();
            this.txtSSD = new System.Windows.Forms.TextBox();
            this.lblssd = new System.Windows.Forms.Label();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.lblHD = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.txtCoolerCPU = new System.Windows.Forms.TextBox();
            this.lblCPUCooler = new System.Windows.Forms.Label();
            this.txtFonte = new System.Windows.Forms.TextBox();
            this.lblFonte = new System.Windows.Forms.Label();
            this.txtPlacaMae = new System.Windows.Forms.TextBox();
            this.lblMobo = new System.Windows.Forms.Label();
            this.txtProcessador = new System.Windows.Forms.TextBox();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(35, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(36, 20);
            this.txtID.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(354, 19);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 21);
            this.cbStatus.TabIndex = 9;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(270, 22);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServico.TabIndex = 10;
            this.lblTipoServico.Text = "Tipo de Serviço:";
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Enabled = false;
            this.txtCPFCliente.Location = new System.Drawing.Point(148, 19);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(116, 20);
            this.txtCPFCliente.TabIndex = 12;
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Location = new System.Drawing.Point(77, 22);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(65, 13);
            this.lblCPFCliente.TabIndex = 11;
            this.lblCPFCliente.Text = "CPF Cliente:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.rdbtnNaoPronto);
            this.groupBoxInfo.Controls.Add(this.rdbtnPronto);
            this.groupBoxInfo.Controls.Add(this.lblStatus);
            this.groupBoxInfo.Controls.Add(this.txtID);
            this.groupBoxInfo.Controls.Add(this.txtCPFCliente);
            this.groupBoxInfo.Controls.Add(this.lblID);
            this.groupBoxInfo.Controls.Add(this.lblCPFCliente);
            this.groupBoxInfo.Controls.Add(this.cbStatus);
            this.groupBoxInfo.Controls.Add(this.lblTipoServico);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(487, 79);
            this.groupBoxInfo.TabIndex = 13;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Sobre O Serviço";
            // 
            // rdbtnNaoPronto
            // 
            this.rdbtnNaoPronto.AutoSize = true;
            this.rdbtnNaoPronto.Location = new System.Drawing.Point(170, 51);
            this.rdbtnNaoPronto.Name = "rdbtnNaoPronto";
            this.rdbtnNaoPronto.Size = new System.Drawing.Size(79, 17);
            this.rdbtnNaoPronto.TabIndex = 15;
            this.rdbtnNaoPronto.TabStop = true;
            this.rdbtnNaoPronto.Text = "Não Pronto";
            this.rdbtnNaoPronto.UseVisualStyleBackColor = true;
            // 
            // rdbtnPronto
            // 
            this.rdbtnPronto.AutoSize = true;
            this.rdbtnPronto.Location = new System.Drawing.Point(91, 51);
            this.rdbtnPronto.Name = "rdbtnPronto";
            this.rdbtnPronto.Size = new System.Drawing.Size(56, 17);
            this.rdbtnPronto.TabIndex = 14;
            this.rdbtnPronto.TabStop = true;
            this.rdbtnPronto.Text = "Pronto";
            this.rdbtnPronto.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status do PC:";
            // 
            // groupBoxPC
            // 
            this.groupBoxPC.Controls.Add(this.txtObs);
            this.groupBoxPC.Controls.Add(this.lblObs);
            this.groupBoxPC.Controls.Add(this.txtGabinete);
            this.groupBoxPC.Controls.Add(this.lblGabinete);
            this.groupBoxPC.Controls.Add(this.txtVGA);
            this.groupBoxPC.Controls.Add(this.lblVGA);
            this.groupBoxPC.Controls.Add(this.txtSSD);
            this.groupBoxPC.Controls.Add(this.lblssd);
            this.groupBoxPC.Controls.Add(this.txtHD);
            this.groupBoxPC.Controls.Add(this.lblHD);
            this.groupBoxPC.Controls.Add(this.txtRam);
            this.groupBoxPC.Controls.Add(this.lblRam);
            this.groupBoxPC.Controls.Add(this.txtCoolerCPU);
            this.groupBoxPC.Controls.Add(this.lblCPUCooler);
            this.groupBoxPC.Controls.Add(this.txtFonte);
            this.groupBoxPC.Controls.Add(this.lblFonte);
            this.groupBoxPC.Controls.Add(this.txtPlacaMae);
            this.groupBoxPC.Controls.Add(this.lblMobo);
            this.groupBoxPC.Controls.Add(this.txtProcessador);
            this.groupBoxPC.Controls.Add(this.lblProcessador);
            this.groupBoxPC.Location = new System.Drawing.Point(13, 110);
            this.groupBoxPC.Name = "groupBoxPC";
            this.groupBoxPC.Size = new System.Drawing.Size(487, 318);
            this.groupBoxPC.TabIndex = 14;
            this.groupBoxPC.TabStop = false;
            this.groupBoxPC.Text = "Computador";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(91, 227);
            this.txtObs.MaxLength = 255;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(377, 73);
            this.txtObs.TabIndex = 19;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 230);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 18;
            this.lblObs.Text = "Observações:";
            // 
            // txtGabinete
            // 
            this.txtGabinete.Location = new System.Drawing.Point(91, 201);
            this.txtGabinete.MaxLength = 255;
            this.txtGabinete.Name = "txtGabinete";
            this.txtGabinete.Size = new System.Drawing.Size(377, 20);
            this.txtGabinete.TabIndex = 17;
            // 
            // lblGabinete
            // 
            this.lblGabinete.AutoSize = true;
            this.lblGabinete.Location = new System.Drawing.Point(16, 204);
            this.lblGabinete.Name = "lblGabinete";
            this.lblGabinete.Size = new System.Drawing.Size(53, 13);
            this.lblGabinete.TabIndex = 16;
            this.lblGabinete.Text = "Gabinete:";
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(106, 175);
            this.txtVGA.MaxLength = 255;
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(362, 20);
            this.txtVGA.TabIndex = 15;
            // 
            // lblVGA
            // 
            this.lblVGA.AutoSize = true;
            this.lblVGA.Location = new System.Drawing.Point(16, 178);
            this.lblVGA.Name = "lblVGA";
            this.lblVGA.Size = new System.Drawing.Size(84, 13);
            this.lblVGA.TabIndex = 14;
            this.lblVGA.Text = "Placa de Vídeo:";
            // 
            // txtSSD
            // 
            this.txtSSD.Location = new System.Drawing.Point(302, 149);
            this.txtSSD.MaxLength = 255;
            this.txtSSD.Name = "txtSSD";
            this.txtSSD.Size = new System.Drawing.Size(166, 20);
            this.txtSSD.TabIndex = 13;
            // 
            // lblssd
            // 
            this.lblssd.AutoSize = true;
            this.lblssd.Location = new System.Drawing.Point(264, 152);
            this.lblssd.Name = "lblssd";
            this.lblssd.Size = new System.Drawing.Size(32, 13);
            this.lblssd.TabIndex = 12;
            this.lblssd.Text = "SSD:";
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(106, 149);
            this.txtHD.MaxLength = 255;
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(152, 20);
            this.txtHD.TabIndex = 11;
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Location = new System.Drawing.Point(16, 152);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(26, 13);
            this.lblHD.TabIndex = 10;
            this.lblHD.Text = "HD:";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(91, 123);
            this.txtRam.MaxLength = 255;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(377, 20);
            this.txtRam.TabIndex = 9;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(16, 126);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(34, 13);
            this.lblRam.TabIndex = 8;
            this.lblRam.Text = "RAM:";
            // 
            // txtCoolerCPU
            // 
            this.txtCoolerCPU.Location = new System.Drawing.Point(91, 97);
            this.txtCoolerCPU.MaxLength = 255;
            this.txtCoolerCPU.Name = "txtCoolerCPU";
            this.txtCoolerCPU.Size = new System.Drawing.Size(377, 20);
            this.txtCoolerCPU.TabIndex = 7;
            // 
            // lblCPUCooler
            // 
            this.lblCPUCooler.AutoSize = true;
            this.lblCPUCooler.Location = new System.Drawing.Point(16, 100);
            this.lblCPUCooler.Name = "lblCPUCooler";
            this.lblCPUCooler.Size = new System.Drawing.Size(65, 13);
            this.lblCPUCooler.TabIndex = 6;
            this.lblCPUCooler.Text = "CPU Cooler:";
            // 
            // txtFonte
            // 
            this.txtFonte.Location = new System.Drawing.Point(91, 71);
            this.txtFonte.MaxLength = 255;
            this.txtFonte.Name = "txtFonte";
            this.txtFonte.Size = new System.Drawing.Size(377, 20);
            this.txtFonte.TabIndex = 5;
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Location = new System.Drawing.Point(16, 74);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(37, 13);
            this.lblFonte.TabIndex = 4;
            this.lblFonte.Text = "Fonte:";
            // 
            // txtPlacaMae
            // 
            this.txtPlacaMae.Location = new System.Drawing.Point(91, 45);
            this.txtPlacaMae.MaxLength = 255;
            this.txtPlacaMae.Name = "txtPlacaMae";
            this.txtPlacaMae.Size = new System.Drawing.Size(377, 20);
            this.txtPlacaMae.TabIndex = 3;
            // 
            // lblMobo
            // 
            this.lblMobo.AutoSize = true;
            this.lblMobo.Location = new System.Drawing.Point(16, 48);
            this.lblMobo.Name = "lblMobo";
            this.lblMobo.Size = new System.Drawing.Size(61, 13);
            this.lblMobo.TabIndex = 2;
            this.lblMobo.Text = "Placa-Mãe:";
            // 
            // txtProcessador
            // 
            this.txtProcessador.Location = new System.Drawing.Point(91, 19);
            this.txtProcessador.MaxLength = 255;
            this.txtProcessador.Name = "txtProcessador";
            this.txtProcessador.Size = new System.Drawing.Size(377, 20);
            this.txtProcessador.TabIndex = 1;
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(16, 22);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(69, 13);
            this.lblProcessador.TabIndex = 0;
            this.lblProcessador.Text = "Processador:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 434);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 38);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(367, 434);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(133, 38);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Atualizar Informações";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(228, 434);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(133, 38);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar Serviço";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // ServicoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(512, 484);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBoxPC);
            this.Controls.Add(this.groupBoxInfo);
            this.MaximizeBox = false;
            this.Name = "ServicoPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Serviço";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxPC.ResumeLayout(false);
            this.groupBoxPC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rdbtnNaoPronto;
        private System.Windows.Forms.RadioButton rdbtnPronto;
        private System.Windows.Forms.GroupBox groupBoxPC;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblProcessador;
        private System.Windows.Forms.TextBox txtPlacaMae;
        private System.Windows.Forms.Label lblMobo;
        private System.Windows.Forms.TextBox txtProcessador;
        private System.Windows.Forms.TextBox txtFonte;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.TextBox txtCoolerCPU;
        private System.Windows.Forms.Label lblCPUCooler;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.TextBox txtSSD;
        private System.Windows.Forms.Label lblssd;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.Label lblVGA;
        private System.Windows.Forms.TextBox txtGabinete;
        private System.Windows.Forms.Label lblGabinete;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
    }
}