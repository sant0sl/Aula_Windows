namespace Windows_Forms1.Forms
{
    partial class WebForm
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
            this.webBrowserGoogle = new System.Windows.Forms.WebBrowser();
            this.webBrowserFacear = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnUnifacear = new System.Windows.Forms.Button();
            this.btnYT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowserGoogle
            // 
            this.webBrowserGoogle.Location = new System.Drawing.Point(12, 12);
            this.webBrowserGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogle.Name = "webBrowserGoogle";
            this.webBrowserGoogle.Size = new System.Drawing.Size(390, 188);
            this.webBrowserGoogle.TabIndex = 0;
            this.webBrowserGoogle.Url = new System.Uri("http://www.google.com.br/", System.UriKind.Absolute);
            // 
            // webBrowserFacear
            // 
            this.webBrowserFacear.Location = new System.Drawing.Point(408, 12);
            this.webBrowserFacear.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserFacear.Name = "webBrowserFacear";
            this.webBrowserFacear.Size = new System.Drawing.Size(387, 188);
            this.webBrowserFacear.TabIndex = 1;
            this.webBrowserFacear.Url = new System.Uri("http://www.unifacear.edu.br/", System.UriKind.Absolute);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(12, 206);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(783, 222);
            this.webBrowser3.TabIndex = 2;
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(12, 447);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(111, 23);
            this.btnGoogle.TabIndex = 3;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnUnifacear
            // 
            this.btnUnifacear.Location = new System.Drawing.Point(129, 447);
            this.btnUnifacear.Name = "btnUnifacear";
            this.btnUnifacear.Size = new System.Drawing.Size(111, 23);
            this.btnUnifacear.TabIndex = 4;
            this.btnUnifacear.Text = "Unifacear";
            this.btnUnifacear.UseVisualStyleBackColor = true;
            this.btnUnifacear.Click += new System.EventHandler(this.btnUnifacear_Click);
            // 
            // btnYT
            // 
            this.btnYT.Location = new System.Drawing.Point(246, 447);
            this.btnYT.Name = "btnYT";
            this.btnYT.Size = new System.Drawing.Size(111, 23);
            this.btnYT.TabIndex = 5;
            this.btnYT.Text = "Youtube";
            this.btnYT.UseVisualStyleBackColor = true;
            this.btnYT.Click += new System.EventHandler(this.btnYT_Click);
            // 
            // WebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.btnYT);
            this.Controls.Add(this.btnUnifacear);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowserFacear);
            this.Controls.Add(this.webBrowserGoogle);
            this.Name = "WebForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGoogle;
        private System.Windows.Forms.WebBrowser webBrowserFacear;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnUnifacear;
        private System.Windows.Forms.Button btnYT;
    }
}