using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoEletronico_Forms.Forms
{
    public partial class SaqueForm : Form
    {
        ContaBancaria cb = new ContaBancaria();

        public SaqueForm()
        {
            InitializeComponent();
        }

        public SaqueForm(ContaBancaria cbLogada)
        {
            InitializeComponent();
            cb = cbLogada;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Equals(null) || txtValor.Text.Equals(""))
            {
                MessageBox.Show("Insira um valor de saque.");
                txtValor.Text = string.Empty;
            }
            else
            {
                string aux = string.Empty;
                decimal valor = Convert.ToDecimal(txtValor.Text);
                aux = cb.sp_saqueBancario(valor);
                MessageBox.Show(aux, "Saque");
                this.Hide();
            }
        }
    }
}
