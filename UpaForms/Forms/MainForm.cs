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
    public partial class MainForm : Form
    {
        Crianca crianca;

        public MainForm()
        {
            InitializeComponent();
            crianca = new Crianca();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarForm form = new CadastrarForm();
            form.Show();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrarPessoa(txtCPF.Text);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dgvCriancas.DataSource = crianca.sp_readCrianca().Tables[0];
        }

        public void filtrarPessoa(string filtro)
        {
            dgvCriancas.DataSource = crianca.sp_readCriancaByFiltro(filtro).Tables[0];
        }

        private void dgvCriancas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            crianca = new Crianca();
            crianca.cpf = dgv.CurrentRow.Cells[0].Value.ToString();
            UpaForm form = new UpaForm(crianca);
            form.Show();
            this.Hide();
        }
    }
}
