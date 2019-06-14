using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeDados_LoginForms.Classes;
using BancoDeDados_LoginForms.EDM;
using BancoDeDados_LoginForms.Forms;

namespace BancoDeDados_LoginForms.Forms
{
    public partial class AlterarForm : Form
    {
        public pessoa pessoaSessaoLogada = new pessoa();

        public AlterarForm()
        {
            InitializeComponent();
        }
        public AlterarForm(pessoa p)
        {
            InitializeComponent();
            pessoaSessaoLogada = p;
            carregarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar();   
        }

        public void alterar()
        {
            //mensagem de retorno
            string altaux = null;
            //nova pessoa pra pegar os valores dos textbox referente à pessoa logada
            pessoa altp = new pessoa();
            //seta valores - cpf da pessoa logada, e valores que podem ser alterados nos textbox
            altp.cpf = pessoaSessaoLogada.cpf;
            altp.nome = txtNome.Text;
            altp.sobrenome = txtSobrenome.Text;
            altp.email = txtEmail.Text;
            altp.idade = Convert.ToInt32(txtIdade.Text);
            if (rdbtnMasc.Checked == true && rdbtnFem.Checked == false)
            {
                altp.sexo = true;
            }else if (rdbtnMasc.Checked == false && rdbtnFem.Checked == true)
            {
                altp.sexo = false;
            }
            altp.senha = txtSenha.Text;
            //faz a alteração, e retorna na variável a mensagem de resposta
            altaux = PessoaDAO.alterarPessoa(altp);
            //mostra a mensagem que retornou
            MessageBox.Show(altaux);
            this.Hide();
        }

        public void voltar()
        {
            this.Hide();
        }

        public void carregarCampos()
        {
            txtCPF.Text = pessoaSessaoLogada.cpf;
            txtNome.Text = pessoaSessaoLogada.nome;
            txtSobrenome.Text = pessoaSessaoLogada.sobrenome;
            txtEmail.Text = pessoaSessaoLogada.email;
            txtIdade.Text = Convert.ToString(pessoaSessaoLogada.idade);
            if (pessoaSessaoLogada.sexo == true)
            {
                rdbtnMasc.Checked = true;
                rdbtnFem.Checked = false;
            }
            else
            {
                rdbtnMasc.Checked = false;
                rdbtnFem.Checked = true;
            }
            txtSenha.Text = pessoaSessaoLogada.senha;
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
