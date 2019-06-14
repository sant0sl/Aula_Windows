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
    public partial class CNPJCEP : Form
    {
        public CNPJCEP()
        {
            InitializeComponent();
        }

        private void btnCNPJ_Click(object sender, EventArgs e)
        {
            CNPJForm form = new CNPJForm();
            form.Show();
            this.Hide();
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            CEPForm form = new CEPForm();
            form.Show();
            this.Hide();
        }
    }
}
