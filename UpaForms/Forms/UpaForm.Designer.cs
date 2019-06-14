namespace UpaForms.Forms
{
    partial class UpaForm
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblNomeCrianca = new System.Windows.Forms.Label();
            this.dgvVacinas = new System.Windows.Forms.DataGridView();
            this.btnVacina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(479, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(97, 34);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar Conta";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(582, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(376, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 34);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar Dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblNomeCrianca
            // 
            this.lblNomeCrianca.AutoSize = true;
            this.lblNomeCrianca.Location = new System.Drawing.Point(12, 23);
            this.lblNomeCrianca.Name = "lblNomeCrianca";
            this.lblNomeCrianca.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCrianca.TabIndex = 8;
            this.lblNomeCrianca.Text = "Nome";
            // 
            // dgvVacinas
            // 
            this.dgvVacinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacinas.Location = new System.Drawing.Point(12, 52);
            this.dgvVacinas.Name = "dgvVacinas";
            this.dgvVacinas.Size = new System.Drawing.Size(667, 333);
            this.dgvVacinas.TabIndex = 9;
            this.dgvVacinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacinas_CellClick);
            // 
            // btnVacina
            // 
            this.btnVacina.Location = new System.Drawing.Point(273, 12);
            this.btnVacina.Name = "btnVacina";
            this.btnVacina.Size = new System.Drawing.Size(97, 34);
            this.btnVacina.TabIndex = 10;
            this.btnVacina.Text = "Nova Vacina";
            this.btnVacina.UseVisualStyleBackColor = true;
            this.btnVacina.Click += new System.EventHandler(this.btnVacina_Click);
            // 
            // UpaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(691, 397);
            this.Controls.Add(this.btnVacina);
            this.Controls.Add(this.dgvVacinas);
            this.Controls.Add(this.lblNomeCrianca);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSair);
            this.MaximizeBox = false;
            this.Name = "UpaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPA";
            this.Activated += new System.EventHandler(this.UpaForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblNomeCrianca;
        private System.Windows.Forms.DataGridView dgvVacinas;
        private System.Windows.Forms.Button btnVacina;
    }
}