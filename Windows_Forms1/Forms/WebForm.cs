using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms1.Forms
{
    public partial class WebForm : Form
    {
        public WebForm()
        {
            InitializeComponent();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("http://www.google.com.br/");
        }

        private void btnUnifacear_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("http://www.unifacear.edu.br/");
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("http://www.youtube.com.br/");
        }
    }
}
