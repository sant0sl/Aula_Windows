namespace BancoDeDados_LoginForms.Forms
{
    partial class MenuForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.btnDados = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(475, 62);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 31);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuarioLogado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(13, 24);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(103, 20);
            this.lblUsuarioLogado.TabIndex = 8;
            this.lblUsuarioLogado.Text = "Usuário atual";
            // 
            // btnDados
            // 
            this.btnDados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDados.Location = new System.Drawing.Point(344, 62);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(125, 31);
            this.btnDados.TabIndex = 9;
            this.btnDados.Text = "Dados do Cadastro";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApagar.Location = new System.Drawing.Point(213, 62);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(125, 31);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar minha Conta";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(612, 105);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Activated += new System.EventHandler(this.focusMenu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button btnApagar;
    }
}