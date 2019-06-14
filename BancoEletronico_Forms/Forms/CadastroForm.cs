using BancoEletronico_Forms.Classes;
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
    public partial class CadastroForm : Form
    {
        ContaBancaria cb;

        public CadastroForm()
        {
            InitializeComponent();
            cb = new ContaBancaria();
            limparCampos();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (Validacao.IsCpf(txtCPF.Text))
            {
                txtNomeCompleto.Focus();
            }
            else if (txtCPF.Text.Equals(""))
            {
                txtNomeCompleto.Focus();
            }
            else
            {
                MessageBox.Show("Este CPF não é válido! Por favor, insira um válido.");
                txtCPF.Text = null;
                txtCPF.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Validacao.IsEmail(txtEmail.Text))
            {
                txtSenha.Focus();
            }
            else if (txtEmail.Text.Equals(""))
            {
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Este E-mail não é válido! Por favor, insira um válido.");
                txtEmail.Text = null;
                txtEmail.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            bool cpfaux = false;
            bool nomeaux = false;
            bool emailaux = false;
            bool senhaaux = false;

            if (txtCPF.Text.Equals(""))
            {
                cpfaux = false;
            }
            else
            {
                cb.cpf = txtCPF.Text;
                cpfaux = true;
            }

            if (txtNomeCompleto.Text.Equals(""))
            {
                nomeaux = false;
            }
            else
            {
                cb.nomecompleto = txtNomeCompleto.Text;
                nomeaux = true;
            }

            if (txtEmail.Text.Equals(""))
            {
                emailaux = false;
            }
            else
            {
                cb.email = txtEmail.Text;
                emailaux = true;
            }

            if (txtSenha.Text.Equals(""))
            {
                senhaaux = false;
            }
            else
            {
                cb.senha = txtSenha.Text;
                senhaaux = true;
            }

            if (cpfaux == true && nomeaux == true && emailaux == true && senhaaux == true)
            {
                aux = cb.sp_createConta();
                MessageBox.Show(aux, "Novo Cadastro");
                LoginForm form = new LoginForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Novo Cadastro");
            }
        }

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtNomeCompleto.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
    }
}
