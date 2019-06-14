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

namespace CRUD_Forms_sP_SQL
{
    public partial class Main : Form
    {
        Pessoa pessoinha;

        public Main()
        {
            InitializeComponent();
            pessoinha = new Pessoa();
        }

        //-------------------------Métodos-------------------------------

        public void cadastrarPessoa()
        {
            string aux = string.Empty;
            pessoinha = new Pessoa();
            pessoinha.nome = txtNome.Text;
            pessoinha.idade = Convert.ToInt32(txtIdade.Text);
            pessoinha.email = txtEmail.Text;
            aux = pessoinha.sp_createPessoa();
            limparCampos();
            MessageBox.Show(aux, "Mensagem");
        }
        public void alterarPessoa()
        {
            string aux = string.Empty;
            pessoinha = new Pessoa();
            pessoinha.uid_pessoa = Convert.ToInt32(lblUid.Text);
            pessoinha = pessoinha.sp_readPessoaByUID();

            if (txtNome.Text.Equals(null) || txtNome.Text.Equals("") || txtNome.Text.Equals(pessoinha.nome))
            {
                pessoinha.nome = pessoinha.nome;
            }
            else
            {
                pessoinha.nome = txtNome.Text;
            }

            if (txtIdade.Text.Equals(null) || txtIdade.Text.Equals("") || txtIdade.Text.Equals(pessoinha.idade))
            {
                pessoinha.idade = pessoinha.idade;
            }
            else
            {
                pessoinha.idade = Convert.ToInt32(txtIdade.Text);
            }

            if (txtEmail.Text.Equals(null) || txtEmail.Text.Equals("") || txtEmail.Text.Equals(pessoinha.email))
            {
                pessoinha.email = pessoinha.email;
            }
            else
            {
                pessoinha.email = txtEmail.Text;
            }

            aux = pessoinha.sp_updatePessoa();
            limparCampos();
            MessageBox.Show(aux, "Mensagem");
        }
        public void excluirPessoa()
        {
            string aux = string.Empty;
            pessoinha = new Pessoa();
            pessoinha.uid_pessoa = Convert.ToInt32(lblUid.Text);
            if (MessageBox.Show("Deseja mesmo apagar definitivamente este registro?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aux = pessoinha.sp_deletePessoa();
                limparCampos();
                MessageBox.Show(aux, "Mensagem");
            }
            else
            {
                limparCampos();
            }
        }
        public void filtrarPessoa(string filtro)
        {
            dgvPessoas.DataSource = pessoinha.sp_readPessoaByFilter(filtro).Tables[0];
        }

        public void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFiltro.Text = string.Empty;
            lblUid.Text = string.Empty;
        }

        public void preencherCampos()
        {
            lblUid.Text = Convert.ToString(pessoinha.uid_pessoa);
            txtNome.Text = pessoinha.nome;
            txtIdade.Text = Convert.ToString(pessoinha.idade);
            txtEmail.Text = pessoinha.email;
        }

        //-------------------Eventos------------------------

        private void Main_Activated(object sender, EventArgs e)
        {
            dgvPessoas.DataSource = pessoinha.sp_readPessoa().Tables[0];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarPessoa();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarPessoa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirPessoa();
        }

        private void dgvPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            pessoinha = new Pessoa();
            pessoinha.uid_pessoa = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            pessoinha.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            pessoinha.idade = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            pessoinha.email = dgv.CurrentRow.Cells[3].Value.ToString();
            preencherCampos();
            txtFiltro.Text = string.Empty;
            dgvPessoas.DataSource = pessoinha.sp_readPessoa().Tables[0];
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarPessoa(txtFiltro.Text);
        }

    }
}
