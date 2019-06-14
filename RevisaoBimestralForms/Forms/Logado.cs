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

namespace RevisaoBimestralForms.Forms
{
    public partial class Logado : Form
    {
        private Usuario usuarioLogado;
        
        public Logado()
        {
            InitializeComponent();
        }

        public Logado(Usuario u)
        {
            InitializeComponent();
            usuarioLogado = u;
            carregarCampos();
        }

        public void carregarCampos()
        {
            txtCPF.Text = usuarioLogado.cpf;
            txtNomeCompleto.Text = usuarioLogado.nomeCompleto;
            txtEmail.Text = usuarioLogado.email;
            txtSenha.Text = usuarioLogado.senha;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
