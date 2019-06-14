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

namespace UpaForms.Forms
{
    public partial class CadastrarForm : Form
    {
        Crianca c;

        public CadastrarForm()
        {
            InitializeComponent();
            c = new Crianca();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            bool cpfaux = false;
            bool criancaaux = false;
            bool maeaux = false;
            bool idadeaux = false;

            if (txtCPF.Text.Equals(""))
            {
                cpfaux = false;
            }
            else
            {
                cpfaux = true;
                c.cpf = txtCPF.Text;
            }

            if (txtNomeCrianca.Text.Equals(""))
            {
                criancaaux = false;
            }
            else
            {
                criancaaux = true;
                c.nomeCrianca = txtNomeCrianca.Text;
            }

            if (txtNomeMae.Text.Equals(""))
            {
                maeaux = false;
            }
            else
            {
                maeaux = true;
                c.nomeMae = txtNomeMae.Text;
            }

            if (txtIdade.Text.Equals(""))
            {
                idadeaux = false;
            }
            else
            {
                idadeaux = true;
                c.idade = Convert.ToInt32(txtIdade.Text);
            }

            if (cpfaux == true && criancaaux == true && maeaux == true && idadeaux == true)
            {
                aux = c.sp_createCrianca();
                MessageBox.Show(aux, "Cadastro");
                limparCampos();
                this.Hide();
            }
            else
            {
                limparCampos();
                MessageBox.Show("Preencha todos os campos!", "Cadastro");
            }
        }

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtNomeCrianca.Text = string.Empty;
            txtNomeMae.Text = string.Empty;
            txtIdade.Text = string.Empty;
        }
    }
}
