using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnir_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }
    }
}
