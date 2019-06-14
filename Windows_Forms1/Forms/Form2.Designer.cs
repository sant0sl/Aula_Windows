namespace Windows_Forms1.Forms
{
    partial class Form2
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSoma10 = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultadoSoma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(30, 20);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(44, 13);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Número";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(80, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnSoma10
            // 
            this.btnSoma10.Location = new System.Drawing.Point(206, 15);
            this.btnSoma10.Name = "btnSoma10";
            this.btnSoma10.Size = new System.Drawing.Size(75, 23);
            this.btnSoma10.TabIndex = 2;
            this.btnSoma10.Text = "Soma 10";
            this.btnSoma10.UseVisualStyleBackColor = true;
            this.btnSoma10.Click += new System.EventHandler(this.btnSoma10_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(310, 20);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_Resultado.TabIndex = 3;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(380, 17);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(138, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(89, 54);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número 1";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(360, 52);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.Text = "Somar";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(254, 54);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número 2";
            // 
            // txtResultadoSoma
            // 
            this.txtResultadoSoma.Location = new System.Drawing.Point(441, 54);
            this.txtResultadoSoma.Name = "txtResultadoSoma";
            this.txtResultadoSoma.Size = new System.Drawing.Size(77, 20);
            this.txtResultadoSoma.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(544, 103);
            this.Controls.Add(this.txtResultadoSoma);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btnSoma10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSoma10;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultadoSoma;
    }
}