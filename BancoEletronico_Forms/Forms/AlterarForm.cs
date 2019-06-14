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
    public partial class AlterarForm : Form
    {
        ContaBancaria cbLogada;

        public AlterarForm()
        {
            InitializeComponent();
        }

        public AlterarForm(ContaBancaria cb)
        {
            InitializeComponent();
            cbLogada = cb;
            carregarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        public void alterar()
        {
            ContaBancaria cb = new ContaBancaria();
            string aux = string.Empty;

            cb.cpf = cbLogada.cpf;

            if (txtNomeCompleto.Text.Equals(null) || txtNomeCompleto.Text.Equals(""))
            {
                cb.nomecompleto = cbLogada.nomecompleto;
            }
            else
            {
                cb.nomecompleto = txtNomeCompleto.Text;
            }

            if (txtEmail.Text.Equals(null) || txtEmail.Text.Equals(""))
            {
                cb.email = cbLogada.email;
            }
            else
            {
                cb.email = txtEmail.Text;
            }

            if (txtSenha.Text.Equals(null) || txtSenha.Text.Equals(""))
            {
                cb.senha = cbLogada.senha;
            }
            else
            {
                cb.senha = txtSenha.Text;
            }

            aux = cb.sp_updateConta();
            MessageBox.Show(aux, "Alteração");
            this.Hide();
        }

        public void carregarCampos()
        {
            txtCPF.Text = cbLogada.cpf;
            txtNomeCompleto.Text = cbLogada.nomecompleto;
            txtEmail.Text = cbLogada.email;
            txtSenha.Text = cbLogada.senha;
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
    }
}
