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
using BancoDeDados_LoginForms.Classes;
using BancoDeDados_LoginForms.EDM;

namespace BancoDeDados_LoginForms.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroForm frm = new CadastroForm();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fazerLogin();
        }

        public void fazerLogin()
        {
            string cpf = txtCPF.Text;
            string senha = txtSenha.Text;

            pessoa pessoaLogin = new pessoa();
            pessoaLogin = PessoaDAO.verificarLogin(cpf, senha);

            if (pessoaLogin == null || pessoaLogin.cpf.Equals(null) || pessoaLogin.cpf.Equals(""))
            {
                limpaCampos();
                MessageBox.Show("CPF e/ou Senha incorretos!");
            }
            else
            {
                //passar objeto carregado por parâmetro no MenuForm
                MenuForm frm = new MenuForm(pessoaLogin);
                frm.Show();
                this.Hide();
            }
        }

        public void limpaCampos()
        {
            txtCPF.Text = null;
            txtSenha.Text = null;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (Validador.IsCpf(txtCPF.Text))
            {
                txtSenha.Focus();
            }
            else if (txtCPF.Text.Equals(""))
            {
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Este CPF não é válido! Por favor, insira um válido.");
                txtCPF.Text = null;
                txtCPF.Focus();
            }
        }
    }
}
