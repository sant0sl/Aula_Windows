namespace Windows_Forms1.Forms
{
    partial class CNPJForm
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCNPJResult = new System.Windows.Forms.TextBox();
            this.lblCNPJResult = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBoxDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.txtEFR = new System.Windows.Forms.TextBox();
            this.lblEFR = new System.Windows.Forms.Label();
            this.txtNaturezaJuridica = new System.Windows.Forms.TextBox();
            this.lblNaturezaJuridica = new System.Windows.Forms.Label();
            this.txtAbertura = new System.Windows.Forms.TextBox();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.txtCapitalSocial = new System.Windows.Forms.TextBox();
            this.lblCapitalSocial = new System.Windows.Forms.Label();
            this.txtUltimaAtualizacao = new System.Windows.Forms.TextBox();
            this.lblUltimaAtualizacao = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxSituacao = new System.Windows.Forms.GroupBox();
            this.txtMotivoSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtDataSituacaoEspecial = new System.Windows.Forms.TextBox();
            this.lblMotivoSituacao = new System.Windows.Forms.Label();
            this.lblDataSituacaoEspecial = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtSituacaoEspecial = new System.Windows.Forms.TextBox();
            this.lblSituacaoEspecial = new System.Windows.Forms.Label();
            this.lblDataSituacao = new System.Windows.Forms.Label();
            this.txtDataSituacao = new System.Windows.Forms.TextBox();
            this.groupBoxLocalizacao = new System.Windows.Forms.GroupBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
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
            this.groupBoxDadosEmpresa.SuspendLayout();
            this.groupBoxSituacao.SuspendLayout();
            this.groupBoxLocalizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(136, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 26);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(215, 124);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJ.TabIndex = 9;
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(172, 127);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CNPJ:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(46, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(253, 153);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 26);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtFantasia
            // 
            this.txtFantasia.Enabled = false;
            this.txtFantasia.Location = new System.Drawing.Point(224, 97);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(192, 20);
            this.txtFantasia.TabIndex = 15;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(221, 81);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 14;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(47, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCNPJResult
            // 
            this.txtCNPJResult.Enabled = false;
            this.txtCNPJResult.Location = new System.Drawing.Point(47, 49);
            this.txtCNPJResult.Name = "txtCNPJResult";
            this.txtCNPJResult.Size = new System.Drawing.Size(125, 20);
            this.txtCNPJResult.TabIndex = 19;
            // 
            // lblCNPJResult
            // 
            this.lblCNPJResult.AutoSize = true;
            this.lblCNPJResult.Location = new System.Drawing.Point(44, 33);
            this.lblCNPJResult.Name = "lblCNPJResult";
            this.lblCNPJResult.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJResult.TabIndex = 18;
            this.lblCNPJResult.Text = "CNPJ:";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(304, 49);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(112, 20);
            this.txtTipo.TabIndex = 21;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(301, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo:";
            // 
            // groupBoxDadosEmpresa
            // 
            this.groupBoxDadosEmpresa.Controls.Add(this.txtEFR);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblEFR);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtNaturezaJuridica);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblNaturezaJuridica);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtAbertura);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblAbertura);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtCapitalSocial);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblCapitalSocial);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtUltimaAtualizacao);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblUltimaAtualizacao);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtEmail);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtStatus);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblCNPJResult);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblEmail);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtCNPJResult);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtNome);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblNome);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblStatus);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblNomeFantasia);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtTipo);
            this.groupBoxDadosEmpresa.Controls.Add(this.txtFantasia);
            this.groupBoxDadosEmpresa.Controls.Add(this.lblTipo);
            this.groupBoxDadosEmpresa.Location = new System.Drawing.Point(508, 27);
            this.groupBoxDadosEmpresa.Name = "groupBoxDadosEmpresa";
            this.groupBoxDadosEmpresa.Size = new System.Drawing.Size(458, 243);
            this.groupBoxDadosEmpresa.TabIndex = 22;
            this.groupBoxDadosEmpresa.TabStop = false;
            this.groupBoxDadosEmpresa.Text = "Dados da Empresa";
            // 
            // txtEFR
            // 
            this.txtEFR.Enabled = false;
            this.txtEFR.Location = new System.Drawing.Point(188, 146);
            this.txtEFR.Name = "txtEFR";
            this.txtEFR.Size = new System.Drawing.Size(97, 20);
            this.txtEFR.TabIndex = 33;
            // 
            // lblEFR
            // 
            this.lblEFR.AutoSize = true;
            this.lblEFR.Location = new System.Drawing.Point(185, 130);
            this.lblEFR.Name = "lblEFR";
            this.lblEFR.Size = new System.Drawing.Size(31, 13);
            this.lblEFR.TabIndex = 32;
            this.lblEFR.Text = "EFR:";
            // 
            // txtNaturezaJuridica
            // 
            this.txtNaturezaJuridica.Enabled = false;
            this.txtNaturezaJuridica.Location = new System.Drawing.Point(304, 195);
            this.txtNaturezaJuridica.Name = "txtNaturezaJuridica";
            this.txtNaturezaJuridica.Size = new System.Drawing.Size(112, 20);
            this.txtNaturezaJuridica.TabIndex = 31;
            // 
            // lblNaturezaJuridica
            // 
            this.lblNaturezaJuridica.AutoSize = true;
            this.lblNaturezaJuridica.Location = new System.Drawing.Point(301, 179);
            this.lblNaturezaJuridica.Name = "lblNaturezaJuridica";
            this.lblNaturezaJuridica.Size = new System.Drawing.Size(94, 13);
            this.lblNaturezaJuridica.TabIndex = 30;
            this.lblNaturezaJuridica.Text = "Natureza Jurídica:";
            // 
            // txtAbertura
            // 
            this.txtAbertura.Enabled = false;
            this.txtAbertura.Location = new System.Drawing.Point(188, 195);
            this.txtAbertura.Name = "txtAbertura";
            this.txtAbertura.Size = new System.Drawing.Size(97, 20);
            this.txtAbertura.TabIndex = 29;
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.Location = new System.Drawing.Point(185, 179);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(50, 13);
            this.lblAbertura.TabIndex = 28;
            this.lblAbertura.Text = "Abertura:";
            // 
            // txtCapitalSocial
            // 
            this.txtCapitalSocial.Enabled = false;
            this.txtCapitalSocial.Location = new System.Drawing.Point(47, 195);
            this.txtCapitalSocial.Name = "txtCapitalSocial";
            this.txtCapitalSocial.Size = new System.Drawing.Size(125, 20);
            this.txtCapitalSocial.TabIndex = 27;
            // 
            // lblCapitalSocial
            // 
            this.lblCapitalSocial.AutoSize = true;
            this.lblCapitalSocial.Location = new System.Drawing.Point(44, 179);
            this.lblCapitalSocial.Name = "lblCapitalSocial";
            this.lblCapitalSocial.Size = new System.Drawing.Size(74, 13);
            this.lblCapitalSocial.TabIndex = 26;
            this.lblCapitalSocial.Text = "Capital Social:";
            // 
            // txtUltimaAtualizacao
            // 
            this.txtUltimaAtualizacao.Enabled = false;
            this.txtUltimaAtualizacao.Location = new System.Drawing.Point(304, 146);
            this.txtUltimaAtualizacao.Name = "txtUltimaAtualizacao";
            this.txtUltimaAtualizacao.Size = new System.Drawing.Size(112, 20);
            this.txtUltimaAtualizacao.TabIndex = 25;
            // 
            // lblUltimaAtualizacao
            // 
            this.lblUltimaAtualizacao.AutoSize = true;
            this.lblUltimaAtualizacao.Location = new System.Drawing.Point(301, 130);
            this.lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            this.lblUltimaAtualizacao.Size = new System.Drawing.Size(97, 13);
            this.lblUltimaAtualizacao.TabIndex = 24;
            this.lblUltimaAtualizacao.Text = "Última Atualização:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(188, 49);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(97, 20);
            this.txtStatus.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(185, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // groupBoxSituacao
            // 
            this.groupBoxSituacao.Controls.Add(this.txtMotivoSituacao);
            this.groupBoxSituacao.Controls.Add(this.lblSituacao);
            this.groupBoxSituacao.Controls.Add(this.txtDataSituacaoEspecial);
            this.groupBoxSituacao.Controls.Add(this.lblMotivoSituacao);
            this.groupBoxSituacao.Controls.Add(this.lblDataSituacaoEspecial);
            this.groupBoxSituacao.Controls.Add(this.txtSituacao);
            this.groupBoxSituacao.Controls.Add(this.txtSituacaoEspecial);
            this.groupBoxSituacao.Controls.Add(this.lblSituacaoEspecial);
            this.groupBoxSituacao.Controls.Add(this.lblDataSituacao);
            this.groupBoxSituacao.Controls.Add(this.txtDataSituacao);
            this.groupBoxSituacao.Location = new System.Drawing.Point(26, 297);
            this.groupBoxSituacao.Name = "groupBoxSituacao";
            this.groupBoxSituacao.Size = new System.Drawing.Size(458, 205);
            this.groupBoxSituacao.TabIndex = 24;
            this.groupBoxSituacao.TabStop = false;
            this.groupBoxSituacao.Text = "Situação";
            // 
            // txtMotivoSituacao
            // 
            this.txtMotivoSituacao.Enabled = false;
            this.txtMotivoSituacao.Location = new System.Drawing.Point(47, 148);
            this.txtMotivoSituacao.Name = "txtMotivoSituacao";
            this.txtMotivoSituacao.Size = new System.Drawing.Size(369, 20);
            this.txtMotivoSituacao.TabIndex = 23;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(44, 33);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 18;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtDataSituacaoEspecial
            // 
            this.txtDataSituacaoEspecial.Enabled = false;
            this.txtDataSituacaoEspecial.Location = new System.Drawing.Point(289, 98);
            this.txtDataSituacaoEspecial.Name = "txtDataSituacaoEspecial";
            this.txtDataSituacaoEspecial.Size = new System.Drawing.Size(127, 20);
            this.txtDataSituacaoEspecial.TabIndex = 21;
            // 
            // lblMotivoSituacao
            // 
            this.lblMotivoSituacao.AutoSize = true;
            this.lblMotivoSituacao.Location = new System.Drawing.Point(44, 132);
            this.lblMotivoSituacao.Name = "lblMotivoSituacao";
            this.lblMotivoSituacao.Size = new System.Drawing.Size(87, 13);
            this.lblMotivoSituacao.TabIndex = 22;
            this.lblMotivoSituacao.Text = "Motivo Situação:";
            // 
            // lblDataSituacaoEspecial
            // 
            this.lblDataSituacaoEspecial.AutoSize = true;
            this.lblDataSituacaoEspecial.Location = new System.Drawing.Point(286, 82);
            this.lblDataSituacaoEspecial.Name = "lblDataSituacaoEspecial";
            this.lblDataSituacaoEspecial.Size = new System.Drawing.Size(121, 13);
            this.lblDataSituacaoEspecial.TabIndex = 20;
            this.lblDataSituacaoEspecial.Text = "Data Situação Especial:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Location = new System.Drawing.Point(47, 49);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(223, 20);
            this.txtSituacao.TabIndex = 19;
            // 
            // txtSituacaoEspecial
            // 
            this.txtSituacaoEspecial.Enabled = false;
            this.txtSituacaoEspecial.Location = new System.Drawing.Point(47, 98);
            this.txtSituacaoEspecial.Name = "txtSituacaoEspecial";
            this.txtSituacaoEspecial.Size = new System.Drawing.Size(223, 20);
            this.txtSituacaoEspecial.TabIndex = 12;
            // 
            // lblSituacaoEspecial
            // 
            this.lblSituacaoEspecial.AutoSize = true;
            this.lblSituacaoEspecial.Location = new System.Drawing.Point(44, 82);
            this.lblSituacaoEspecial.Name = "lblSituacaoEspecial";
            this.lblSituacaoEspecial.Size = new System.Drawing.Size(95, 13);
            this.lblSituacaoEspecial.TabIndex = 11;
            this.lblSituacaoEspecial.Text = "Situação Especial:";
            // 
            // lblDataSituacao
            // 
            this.lblDataSituacao.AutoSize = true;
            this.lblDataSituacao.Location = new System.Drawing.Point(286, 33);
            this.lblDataSituacao.Name = "lblDataSituacao";
            this.lblDataSituacao.Size = new System.Drawing.Size(78, 13);
            this.lblDataSituacao.TabIndex = 14;
            this.lblDataSituacao.Text = "Data Situação:";
            // 
            // txtDataSituacao
            // 
            this.txtDataSituacao.Enabled = false;
            this.txtDataSituacao.Location = new System.Drawing.Point(289, 49);
            this.txtDataSituacao.Name = "txtDataSituacao";
            this.txtDataSituacao.Size = new System.Drawing.Size(127, 20);
            this.txtDataSituacao.TabIndex = 15;
            // 
            // groupBoxLocalizacao
            // 
            this.groupBoxLocalizacao.Controls.Add(this.lblTelefone);
            this.groupBoxLocalizacao.Controls.Add(this.txtTelefone);
            this.groupBoxLocalizacao.Controls.Add(this.lblNumero);
            this.groupBoxLocalizacao.Controls.Add(this.txtNumero);
            this.groupBoxLocalizacao.Controls.Add(this.lblCEP);
            this.groupBoxLocalizacao.Controls.Add(this.txtCEP);
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
            this.groupBoxLocalizacao.Location = new System.Drawing.Point(508, 297);
            this.groupBoxLocalizacao.Name = "groupBoxLocalizacao";
            this.groupBoxLocalizacao.Size = new System.Drawing.Size(458, 194);
            this.groupBoxLocalizacao.TabIndex = 25;
            this.groupBoxLocalizacao.TabStop = false;
            this.groupBoxLocalizacao.Text = "Localização";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(286, 81);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 32;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(289, 97);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 20);
            this.txtTelefone.TabIndex = 33;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(202, 81);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 30;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(205, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(65, 20);
            this.txtNumero.TabIndex = 31;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(322, 126);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 28;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Location = new System.Drawing.Point(325, 142);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(91, 20);
            this.txtCEP.TabIndex = 29;
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
            this.txtComplemento.Size = new System.Drawing.Size(146, 20);
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
            // CNPJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(986, 537);
            this.Controls.Add(this.groupBoxLocalizacao);
            this.Controls.Add(this.groupBoxSituacao);
            this.Controls.Add(this.groupBoxDadosEmpresa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblCPF);
            this.MaximizeBox = false;
            this.Name = "CNPJForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CNPJForm";
            this.groupBoxDadosEmpresa.ResumeLayout(false);
            this.groupBoxDadosEmpresa.PerformLayout();
            this.groupBoxSituacao.ResumeLayout(false);
            this.groupBoxSituacao.PerformLayout();
            this.groupBoxLocalizacao.ResumeLayout(false);
            this.groupBoxLocalizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCNPJResult;
        private System.Windows.Forms.Label lblCNPJResult;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox groupBoxDadosEmpresa;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtDataSituacaoEspecial;
        private System.Windows.Forms.Label lblDataSituacaoEspecial;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtSituacaoEspecial;
        private System.Windows.Forms.Label lblSituacaoEspecial;
        private System.Windows.Forms.Label lblDataSituacao;
        private System.Windows.Forms.TextBox txtDataSituacao;
        private System.Windows.Forms.GroupBox groupBoxLocalizacao;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtMotivoSituacao;
        private System.Windows.Forms.Label lblMotivoSituacao;
        private System.Windows.Forms.TextBox txtUltimaAtualizacao;
        private System.Windows.Forms.Label lblUltimaAtualizacao;
        private System.Windows.Forms.TextBox txtCapitalSocial;
        private System.Windows.Forms.Label lblCapitalSocial;
        private System.Windows.Forms.TextBox txtNaturezaJuridica;
        private System.Windows.Forms.Label lblNaturezaJuridica;
        private System.Windows.Forms.TextBox txtAbertura;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEFR;
        private System.Windows.Forms.Label lblEFR;
    }
}