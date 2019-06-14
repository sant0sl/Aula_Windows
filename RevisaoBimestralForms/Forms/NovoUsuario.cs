using RevisaoBimestralForms.Classes;
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

namespace RevisaoBimestralForms.Forms
{
    public partial class NovoUsuario : Form
    {
        private Usuario usuarioAtual;

        public NovoUsuario()
        {
            InitializeComponent();
            usuarioAtual = new Usuario();
            limparCampos();
        }

        //Métodos

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtNomeCompleto.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        public void voltar()
        {
            this.Hide();
        }

        public void cadastrarUsuario()
        {
            usuarioAtual.cpf = txtCPF.Text;
            usuarioAtual.nomeCompleto = txtNomeCompleto.Text;
            usuarioAtual.email = txtEmail.Text;
            usuarioAtual.senha = txtSenha.Text;
            string aux = usuarioAtual.sp_createUsuario();
            this.Hide();
            MessageBox.Show(aux, "Mensagem");
        }

        //Componentes e eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuario();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            Validador.verificarCPFForms(txtCPF, txtNomeCompleto);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Validador.verificarEmailForms(txtEmail, txtSenha);
        }
    }
}
