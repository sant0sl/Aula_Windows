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

namespace Windows_Forms1.Forms
{
    public partial class Cadastrar_Professor : Form
    {
        public Cadastrar_Professor()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string aux = null;
            Professor prof = new Professor();
            prof.Nome = txtNome.Text;
            prof.Idade = Convert.ToInt32(txtIdade.Text);
            aux = prof.cadastrarProfessor();
            limparCampos();
            MessageBox.Show(aux, "Mensagem");
        }

        public void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtFiltro.Text = string.Empty;
        }

        private void Cadastrar_Professor_Enter(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            //dgViewProfessores.DataSource = prof.buscaProfessores().Tables[0];
            dgViewProfessores.DataSource = prof.buscaProfessores_Procedure().Tables[0];
            //dgViewProfessores.DataSource = prof.buscaProfessoresByNome_Procedure("Mar").Tables[0];
            lblQtdProf.Text = prof.buscaQtdProfessores().ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgViewProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            MessageBox.Show(dgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            dgViewProfessores.DataSource = prof.buscaProfessoresByFiltro_Procedure(txtFiltro.Text).Tables[0];
        }
    }
}
