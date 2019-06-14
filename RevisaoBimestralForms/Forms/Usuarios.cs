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
    public partial class Usuarios : Form
    {
        private Usuario usuarioAtual;

        public Usuarios()
        {
            InitializeComponent();
            usuarioAtual = new Usuario();
            carregarTabelaUsuarios();
            limparCampos();
        }

        //Métodos

        public void limparCampos()
        {
            txtFiltro.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNomeCompleto.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
        
        public void voltar()
        {
            this.Hide();
        }

        public void carregarTabelaUsuarios()
        {
            dgvUsuarios.DataSource = usuarioAtual.sp_readUsuario().Tables[0];
        }

        public void carregarCampos(Usuario u)
        {
            txtCPF.Text = u.cpf;
            txtNomeCompleto.Text = u.nomeCompleto;
            txtEmail.Text = u.email;
            txtSenha.Text = u.senha;
        }

        public void filtrarUsuario(string filtro)
        {
            dgvUsuarios.DataSource = usuarioAtual.sp_readUsuarioByFilter(filtro).Tables[0];
        }

        public void pegarDadosUsuario(object sender)
        {
            DataGridView dgv = sender as DataGridView;
            usuarioAtual.cpf = dgv.CurrentRow.Cells[0].Value.ToString();
            Usuario u = new Usuario();
            u = usuarioAtual.sp_readUsuarioByCPF();
            txtFiltro.Text = string.Empty;
            carregarCampos(u);
        }

        public void alterarDados()
        {
            if (MessageBox.Show("Deseja mesmo alterar definitivamente as informações deste usuário?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuarioAtual.cpf = txtCPF.Text;
                usuarioAtual.nomeCompleto = txtNomeCompleto.Text;
                usuarioAtual.email = txtEmail.Text;
                usuarioAtual.senha = txtSenha.Text;
                string aux = usuarioAtual.sp_updateUsuario();
                this.Hide();
                MessageBox.Show(aux, "Mensagem");
            }
            else
            {
                limparCampos();
            }
        }

        //Componentes e eventos

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pegarDadosUsuario(sender);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            usuarioAtual = new Usuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDados();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Validador.verificarEmailForms(txtEmail, txtSenha);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrarUsuario(txtFiltro.Text);
        }
    }
}
