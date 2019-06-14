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
    public partial class CadastroForm : Form
    {
        public pessoa pessoaObj;
        public string cadastroaux;

        public CadastroForm()
        {
            InitializeComponent();
            pessoaObj = new pessoa();
            cadastroaux = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        public void cadastrar()
        {
            pessoaObj.cpf = txtCPF.Text;
            pessoaObj.nome = txtNome.Text;
            pessoaObj.sobrenome = txtSobrenome.Text;
            pessoaObj.email = txtEmail.Text;
            if (txtIdade.Text.Equals(null) || txtIdade.Text.Equals(""))
            {
                pessoaObj.idade = 0;
            }
            else
            {
                pessoaObj.idade = Convert.ToInt32(txtIdade.Text);
            }
            if (rdbtnMasc.Checked == true && rdbtnFem.Checked == false)
            {
                pessoaObj.sexo = true;
            }
            else if (rdbtnMasc.Checked == false && rdbtnFem.Checked == true)
            {
                pessoaObj.sexo = false;
            }
            pessoaObj.senha = txtSenha.Text;

            cadastroaux = PessoaDAO.cadastrarPessoa(pessoaObj);

            if (cadastroaux == null)
            {
                limparCampos();
                MessageBox.Show("Cadastro não realizado.\nPor favor, preencha todos os campos obrigatórios!");
            }
            else
            {
                limparCampos();
                MessageBox.Show(cadastroaux);
                pessoaObj = new pessoa();
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
            }
        }

        public void limparCampos()
        {
            txtCPF.Text = null;
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtEmail.Text = null;
            txtIdade.Text = null;
            txtSenha.Text = null;
            rdbtnMasc.Checked = false;
            rdbtnFem.Checked = false;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (Validador.IsCpf(txtCPF.Text))
            {
                txtNome.Focus();
            }
            else if (txtCPF.Text.Equals(""))
            {
                txtNome.Focus();
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
            if (Validador.IsEmail(txtEmail.Text))
            {
                txtIdade.Focus();
            }
            else if (txtEmail.Text.Equals(""))
            {
                txtIdade.Focus();
            }
            else
            {
                MessageBox.Show("Este E-mail não é válido! Por favor, insira um válido.");
                txtEmail.Text = null;
                txtEmail.Focus();
            }
        }
    }
}
