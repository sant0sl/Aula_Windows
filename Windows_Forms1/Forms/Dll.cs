using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Classe_do_Professor;

namespace Windows_Forms1.Forms
{
    public partial class Dll : Form
    {
        public Dll()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtOriginal.Text = string.Empty;
            txtRetorno.Text = string.Empty;
        }

        private void btnConsomeDLL_Click(object sender, EventArgs e)
        {
            Classe_do_Professor.Funcoes_do_Professor funcoes = new Funcoes_do_Professor();
            txtRetorno.Text = funcoes.Retorna_Tudo_Maiusculo(txtOriginal.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
