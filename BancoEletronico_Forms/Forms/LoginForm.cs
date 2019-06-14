using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoEletronico_Forms.Classes;
using ClassLibrary;


namespace BancoEletronico_Forms.Forms
{
    public partial class LoginForm : Form
    {
        ContaBancaria cbLogin;

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
            limparCampos();
            CadastroForm form = new CadastroForm();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fazerLogin();
        }

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {

            if (Validacao.IsCpf(txtCPF.Text))
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

        public void fazerLogin()
        {
            cbLogin = new ContaBancaria();
            cbLogin = cbLogin.sp_readContaByCPFandPass(txtCPF.Text, txtSenha.Text);

            if (txtCPF.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                limparCampos();
                MessageBox.Show("CPF e/ou Senha incorretos!");
            }
            else
            {
                MainForm form = new MainForm(cbLogin);
                limparCampos();
                form.Show();
                this.Hide();
            }
        }
    }
}
