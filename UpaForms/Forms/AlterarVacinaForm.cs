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
    public partial class AlterarVacinaForm : Form
    {
        Crianca criancaLogada;
        Vacinas vacina;
        int idVacina;

        public AlterarVacinaForm()
        {
            InitializeComponent();
        }
        public AlterarVacinaForm(Crianca c, Vacinas v)
        {
            InitializeComponent();
            criancaLogada = c;
            vacina = v;
            criancaLogada = criancaLogada.sp_readCriancaByCPF();
            vacina = criancaLogada.sp_readVacinasById(v);
            carregaCampo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtVacina.Text.Equals(vacina.nomeVacina))
            {
                vacina.nomeVacina = vacina.nomeVacina;
            }
            else
            {
                vacina.nomeVacina = txtVacina.Text;
            }

            string aux = string.Empty;
            aux = criancaLogada.sp_updateVacina(criancaLogada, vacina);
            MessageBox.Show(aux, "Mensagem");
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void carregaCampo()
        {
            txtVacina.Text = vacina.nomeVacina;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            if (MessageBox.Show("Deseja mesmo apagar definitivamente esta Vacina?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aux = criancaLogada.sp_deleteVacina(criancaLogada, vacina);
                this.Hide();
                MessageBox.Show(aux, "Mensagem");
            }
            else
            {
                this.Hide();
            }
        }
    }
}
