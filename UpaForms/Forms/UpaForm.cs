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
    public partial class UpaForm : Form
    {
        Crianca criancaLogada;

        public UpaForm()
        {
            InitializeComponent();
        }

        public UpaForm(Crianca c)
        {
            InitializeComponent();
            criancaLogada = c.sp_readCriancaByCPF();
            carregar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            logout();
        }

        public void logout()
        {
            criancaLogada = new Crianca();
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            if (MessageBox.Show("Deseja mesmo apagar definitivamente esta criança?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aux = criancaLogada.sp_deleteCrianca();
                logout();
                MessageBox.Show(aux, "Mensagem");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarForm form = new AlterarForm(criancaLogada);
            form.Show();
        }

        private void UpaForm_Activated(object sender, EventArgs e)
        {
            criancaLogada = criancaLogada.sp_readCriancaByCPF();
            carregar();
        }

        public void carregar()
        {
            lblNomeCrianca.Text = criancaLogada.nomeCrianca;
            dgvVacinas.DataSource = criancaLogada.sp_readVacinasByCPF(criancaLogada.cpf).Tables[0];
        }

        private void dgvVacinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            Vacinas v = new Vacinas();
            v.idVacina = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            AlterarVacinaForm form = new AlterarVacinaForm(criancaLogada, v);
            form.Show();
        }

        private void btnVacina_Click(object sender, EventArgs e)
        {
            VacinaForm form = new VacinaForm(criancaLogada);
            form.Show();
        }
    }
}
