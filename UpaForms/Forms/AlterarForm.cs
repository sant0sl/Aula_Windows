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
    public partial class AlterarForm : Form
    {
        Crianca criancaLogada;

        public AlterarForm()
        {
            InitializeComponent();
        }
        public AlterarForm(Crianca c)
        {
            InitializeComponent();
            criancaLogada = c;
            carregarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;

            if (txtNomeCrianca.Text.Equals(criancaLogada.nomeCrianca))
            {
                criancaLogada.nomeCrianca = criancaLogada.nomeCrianca;
            }
            else
            {
                criancaLogada.nomeCrianca = txtNomeCrianca.Text;
            }

            if (txtNomeMae.Text.Equals(criancaLogada.nomeMae))
            {
                criancaLogada.nomeMae = criancaLogada.nomeMae;
            }
            else
            {
                criancaLogada.nomeMae = txtNomeMae.Text;
            }

            if (txtIdade.Text.Equals(criancaLogada.idade))
            {
                criancaLogada.idade = criancaLogada.idade;
            }
            else
            {
                criancaLogada.idade = Convert.ToInt32(txtIdade.Text);
            }

            aux = criancaLogada.sp_updateCrianca();
            MessageBox.Show(aux, "Alteração");
            limparCampos();
            this.Hide();
        }

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtNomeCrianca.Text = string.Empty;
            txtNomeMae.Text = string.Empty;
            txtIdade.Text = string.Empty;
        }

        public void carregarCampos()
        {
            txtCPF.Text = criancaLogada.cpf;
            txtNomeCrianca.Text = criancaLogada.nomeCrianca;
            txtNomeMae.Text = criancaLogada.nomeMae;
            txtIdade.Text = Convert.ToString(criancaLogada.idade);
        }
    }
}
