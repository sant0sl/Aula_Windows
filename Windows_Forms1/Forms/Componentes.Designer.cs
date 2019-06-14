namespace Windows_Forms1.Forms
{
    partial class Componentes
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
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.cbAlunos = new System.Windows.Forms.ComboBox();
            this.btnCarrregaAlunos = new System.Windows.Forms.Button();
            this.lblProf = new System.Windows.Forms.Label();
            this.cbProfessores = new System.Windows.Forms.ComboBox();
            this.btnCarregaProfessores = new System.Windows.Forms.Button();
            this.btnPegaID = new System.Windows.Forms.Button();
            this.btnSetaProf = new System.Windows.Forms.Button();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.rdbtnSim = new System.Windows.Forms.RadioButton();
            this.rdbtnNao = new System.Windows.Forms.RadioButton();
            this.rdbtnTalvez = new System.Windows.Forms.RadioButton();
            this.btnMostraSelecionado = new System.Windows.Forms.Button();
            this.groupBoxCheckBoxes = new System.Windows.Forms.GroupBox();
            this.checkBoxBom = new System.Windows.Forms.CheckBox();
            this.checkBoxMedio = new System.Windows.Forms.CheckBox();
            this.checkBoxRuim = new System.Windows.Forms.CheckBox();
            this.btnVerificaCheck = new System.Windows.Forms.Button();
            this.btnDesmarca = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.msktxtMascara = new System.Windows.Forms.MaskedTextBox();
            this.lblMask = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxRadioButtons.SuspendLayout();
            this.groupBoxCheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Items.AddRange(new object[] {
            "C#",
            "Java",
            "PHP",
            "Cobol"});
            this.cbMaterias.Location = new System.Drawing.Point(72, 16);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(188, 21);
            this.cbMaterias.TabIndex = 0;
            this.cbMaterias.SelectedIndexChanged += new System.EventHandler(this.cbMaterias_SelectedIndexChanged);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(13, 19);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(53, 13);
            this.lblMaterias.TabIndex = 1;
            this.lblMaterias.Text = "Materias :";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(13, 61);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(40, 13);
            this.lblAluno.TabIndex = 3;
            this.lblAluno.Text = "Aluno :";
            // 
            // cbAlunos
            // 
            this.cbAlunos.FormattingEnabled = true;
            this.cbAlunos.Location = new System.Drawing.Point(72, 58);
            this.cbAlunos.Name = "cbAlunos";
            this.cbAlunos.Size = new System.Drawing.Size(249, 21);
            this.cbAlunos.TabIndex = 2;
            // 
            // btnCarrregaAlunos
            // 
            this.btnCarrregaAlunos.Location = new System.Drawing.Point(327, 56);
            this.btnCarrregaAlunos.Name = "btnCarrregaAlunos";
            this.btnCarrregaAlunos.Size = new System.Drawing.Size(127, 23);
            this.btnCarrregaAlunos.TabIndex = 4;
            this.btnCarrregaAlunos.Text = "Carrega Alunos";
            this.btnCarrregaAlunos.UseVisualStyleBackColor = true;
            this.btnCarrregaAlunos.Click += new System.EventHandler(this.btnCarrregaAlunos_Click);
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(12, 100);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(65, 13);
            this.lblProf.TabIndex = 5;
            this.lblProf.Text = "Professores:";
            // 
            // cbProfessores
            // 
            this.cbProfessores.FormattingEnabled = true;
            this.cbProfessores.Location = new System.Drawing.Point(83, 97);
            this.cbProfessores.Name = "cbProfessores";
            this.cbProfessores.Size = new System.Drawing.Size(238, 21);
            this.cbProfessores.TabIndex = 6;
            // 
            // btnCarregaProfessores
            // 
            this.btnCarregaProfessores.Location = new System.Drawing.Point(327, 95);
            this.btnCarregaProfessores.Name = "btnCarregaProfessores";
            this.btnCarregaProfessores.Size = new System.Drawing.Size(127, 23);
            this.btnCarregaProfessores.TabIndex = 7;
            this.btnCarregaProfessores.Text = "Carrega Professores";
            this.btnCarregaProfessores.UseVisualStyleBackColor = true;
            this.btnCarregaProfessores.Click += new System.EventHandler(this.btnCarregaProfessores_Click);
            // 
            // btnPegaID
            // 
            this.btnPegaID.Location = new System.Drawing.Point(194, 124);
            this.btnPegaID.Name = "btnPegaID";
            this.btnPegaID.Size = new System.Drawing.Size(127, 23);
            this.btnPegaID.TabIndex = 8;
            this.btnPegaID.Text = "Pega ID Professor";
            this.btnPegaID.UseVisualStyleBackColor = true;
            this.btnPegaID.Click += new System.EventHandler(this.btnPegaID_Click);
            // 
            // btnSetaProf
            // 
            this.btnSetaProf.Location = new System.Drawing.Point(327, 124);
            this.btnSetaProf.Name = "btnSetaProf";
            this.btnSetaProf.Size = new System.Drawing.Size(127, 23);
            this.btnSetaProf.TabIndex = 9;
            this.btnSetaProf.Text = "Seta Professor";
            this.btnSetaProf.UseVisualStyleBackColor = true;
            this.btnSetaProf.Click += new System.EventHandler(this.btnSetaProf_Click);
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(266, 16);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(188, 21);
            this.cbDias.TabIndex = 10;
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.btnMostraSelecionado);
            this.groupBoxRadioButtons.Controls.Add(this.rdbtnTalvez);
            this.groupBoxRadioButtons.Controls.Add(this.rdbtnNao);
            this.groupBoxRadioButtons.Controls.Add(this.rdbtnSim);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(15, 165);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(439, 122);
            this.groupBoxRadioButtons.TabIndex = 11;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Text = "Radio Buttons";
            // 
            // rdbtnSim
            // 
            this.rdbtnSim.AutoSize = true;
            this.rdbtnSim.Checked = true;
            this.rdbtnSim.Location = new System.Drawing.Point(107, 37);
            this.rdbtnSim.Name = "rdbtnSim";
            this.rdbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rdbtnSim.TabIndex = 0;
            this.rdbtnSim.TabStop = true;
            this.rdbtnSim.Text = "Sim";
            this.rdbtnSim.UseVisualStyleBackColor = true;
            // 
            // rdbtnNao
            // 
            this.rdbtnNao.AutoSize = true;
            this.rdbtnNao.Location = new System.Drawing.Point(200, 37);
            this.rdbtnNao.Name = "rdbtnNao";
            this.rdbtnNao.Size = new System.Drawing.Size(45, 17);
            this.rdbtnNao.TabIndex = 1;
            this.rdbtnNao.Text = "Não";
            this.rdbtnNao.UseVisualStyleBackColor = true;
            // 
            // rdbtnTalvez
            // 
            this.rdbtnTalvez.AutoSize = true;
            this.rdbtnTalvez.Location = new System.Drawing.Point(291, 37);
            this.rdbtnTalvez.Name = "rdbtnTalvez";
            this.rdbtnTalvez.Size = new System.Drawing.Size(57, 17);
            this.rdbtnTalvez.TabIndex = 2;
            this.rdbtnTalvez.Text = "Talvez";
            this.rdbtnTalvez.UseVisualStyleBackColor = true;
            // 
            // btnMostraSelecionado
            // 
            this.btnMostraSelecionado.Location = new System.Drawing.Point(151, 74);
            this.btnMostraSelecionado.Name = "btnMostraSelecionado";
            this.btnMostraSelecionado.Size = new System.Drawing.Size(142, 23);
            this.btnMostraSelecionado.TabIndex = 3;
            this.btnMostraSelecionado.Text = "Verifica Selecionado";
            this.btnMostraSelecionado.UseVisualStyleBackColor = true;
            this.btnMostraSelecionado.Click += new System.EventHandler(this.btnMostraSelecionado_Click);
            // 
            // groupBoxCheckBoxes
            // 
            this.groupBoxCheckBoxes.Controls.Add(this.btnMarca);
            this.groupBoxCheckBoxes.Controls.Add(this.btnDesmarca);
            this.groupBoxCheckBoxes.Controls.Add(this.btnVerificaCheck);
            this.groupBoxCheckBoxes.Controls.Add(this.checkBoxRuim);
            this.groupBoxCheckBoxes.Controls.Add(this.checkBoxMedio);
            this.groupBoxCheckBoxes.Controls.Add(this.checkBoxBom);
            this.groupBoxCheckBoxes.Location = new System.Drawing.Point(15, 293);
            this.groupBoxCheckBoxes.Name = "groupBoxCheckBoxes";
            this.groupBoxCheckBoxes.Size = new System.Drawing.Size(439, 141);
            this.groupBoxCheckBoxes.TabIndex = 12;
            this.groupBoxCheckBoxes.TabStop = false;
            this.groupBoxCheckBoxes.Text = "Check Boxes";
            // 
            // checkBoxBom
            // 
            this.checkBoxBom.AutoSize = true;
            this.checkBoxBom.Location = new System.Drawing.Point(107, 51);
            this.checkBoxBom.Name = "checkBoxBom";
            this.checkBoxBom.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBom.TabIndex = 0;
            this.checkBoxBom.Text = "Bom";
            this.checkBoxBom.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedio
            // 
            this.checkBoxMedio.AutoSize = true;
            this.checkBoxMedio.Location = new System.Drawing.Point(200, 51);
            this.checkBoxMedio.Name = "checkBoxMedio";
            this.checkBoxMedio.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMedio.TabIndex = 1;
            this.checkBoxMedio.Text = "Médio";
            this.checkBoxMedio.UseVisualStyleBackColor = true;
            // 
            // checkBoxRuim
            // 
            this.checkBoxRuim.AutoSize = true;
            this.checkBoxRuim.Location = new System.Drawing.Point(291, 51);
            this.checkBoxRuim.Name = "checkBoxRuim";
            this.checkBoxRuim.Size = new System.Drawing.Size(50, 17);
            this.checkBoxRuim.TabIndex = 2;
            this.checkBoxRuim.Text = "Ruim";
            this.checkBoxRuim.UseVisualStyleBackColor = true;
            // 
            // btnVerificaCheck
            // 
            this.btnVerificaCheck.Location = new System.Drawing.Point(151, 89);
            this.btnVerificaCheck.Name = "btnVerificaCheck";
            this.btnVerificaCheck.Size = new System.Drawing.Size(142, 23);
            this.btnVerificaCheck.TabIndex = 4;
            this.btnVerificaCheck.Text = "Verifica Selecionado";
            this.btnVerificaCheck.UseVisualStyleBackColor = true;
            this.btnVerificaCheck.Click += new System.EventHandler(this.btnVerificaCheck_Click);
            // 
            // btnDesmarca
            // 
            this.btnDesmarca.Location = new System.Drawing.Point(311, 89);
            this.btnDesmarca.Name = "btnDesmarca";
            this.btnDesmarca.Size = new System.Drawing.Size(101, 23);
            this.btnDesmarca.TabIndex = 5;
            this.btnDesmarca.Text = "Desmarca Tudo";
            this.btnDesmarca.UseVisualStyleBackColor = true;
            this.btnDesmarca.Click += new System.EventHandler(this.btnDesmarca_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(29, 89);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(101, 23);
            this.btnMarca.TabIndex = 6;
            this.btnMarca.Text = "Marcar Tudo";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // msktxtMascara
            // 
            this.msktxtMascara.Location = new System.Drawing.Point(72, 457);
            this.msktxtMascara.Mask = "999,999,999-99";
            this.msktxtMascara.Name = "msktxtMascara";
            this.msktxtMascara.Size = new System.Drawing.Size(109, 20);
            this.msktxtMascara.TabIndex = 13;
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(13, 460);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(54, 13);
            this.lblMask.TabIndex = 14;
            this.lblMask.Text = "Máscara :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(327, 457);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar Tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(480, 499);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.msktxtMascara);
            this.Controls.Add(this.groupBoxCheckBoxes);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.btnSetaProf);
            this.Controls.Add(this.btnPegaID);
            this.Controls.Add(this.btnCarregaProfessores);
            this.Controls.Add(this.cbProfessores);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.btnCarrregaAlunos);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.cbAlunos);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.cbMaterias);
            this.MaximizeBox = false;
            this.Name = "Componentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.Activated += new System.EventHandler(this.Componentes_Activated);
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.groupBoxCheckBoxes.ResumeLayout(false);
            this.groupBoxCheckBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cbAlunos;
        private System.Windows.Forms.Button btnCarrregaAlunos;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.ComboBox cbProfessores;
        private System.Windows.Forms.Button btnCarregaProfessores;
        private System.Windows.Forms.Button btnPegaID;
        private System.Windows.Forms.Button btnSetaProf;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.RadioButton rdbtnTalvez;
        private System.Windows.Forms.RadioButton rdbtnNao;
        private System.Windows.Forms.RadioButton rdbtnSim;
        private System.Windows.Forms.Button btnMostraSelecionado;
        private System.Windows.Forms.GroupBox groupBoxCheckBoxes;
        private System.Windows.Forms.CheckBox checkBoxRuim;
        private System.Windows.Forms.CheckBox checkBoxMedio;
        private System.Windows.Forms.CheckBox checkBoxBom;
        private System.Windows.Forms.Button btnVerificaCheck;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnDesmarca;
        private System.Windows.Forms.MaskedTextBox msktxtMascara;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Button btnLimpar;
    }
}