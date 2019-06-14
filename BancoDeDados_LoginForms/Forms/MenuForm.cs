using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeDados_LoginForms.Forms;
using BancoDeDados_LoginForms.EDM;
using BancoDeDados_LoginForms.Classes;

namespace BancoDeDados_LoginForms.Forms
{
    public partial class MenuForm : Form
    {

        public pessoa pessoaSessaoLogada = new pessoa();

        public MenuForm()
        {
            InitializeComponent();
        }
        public MenuForm(pessoa p)
        {
            InitializeComponent();
            pessoaSessaoLogada = p;
            lblUsuarioLogado.Text = pessoaSessaoLogada.nome + " " + pessoaSessaoLogada.sobrenome;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            apagar();
        }

        private void focusMenu_Click(object sender, EventArgs e)
        {
            atualizarUI();
            lblUsuarioLogado.Text = pessoaSessaoLogada.nome + " " + pessoaSessaoLogada.sobrenome + " / " + pessoaSessaoLogada.idade + " / " + pessoaSessaoLogada.email;
        }

        public void logout()
        {
            pessoaSessaoLogada = new pessoa();
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        public void apagar()
        {
            string apagaraux = null;
            if (MessageBox.Show("Deseja mesmo apagar definitivamente a sua conta?", "Apagando Conta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                apagaraux = PessoaDAO.deletarPessoa(pessoaSessaoLogada);
                logout();
                MessageBox.Show(apagaraux);
            }
        }

        public void alterar()
        {
            AlterarForm frm = new AlterarForm(pessoaSessaoLogada);
            frm.Show();
        }

        public void atualizarUI()
        {
            pessoaSessaoLogada = PessoaDAO.buscarPessoa(pessoaSessaoLogada.cpf);
        }
    }
}
