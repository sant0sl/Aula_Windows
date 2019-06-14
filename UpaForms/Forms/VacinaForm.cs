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
    public partial class VacinaForm : Form
    {
        Crianca criancaLogada;
        Vacinas vacina;

        public VacinaForm()
        {
            InitializeComponent();
        }
        public VacinaForm(Crianca c)
        {
            InitializeComponent();
            txtVacina.Text = string.Empty;
            criancaLogada = c.sp_readCriancaByCPF();
            vacina = new Vacinas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtVacina.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo!", "Mensagem");
            }
            else
            {
                string aux = string.Empty;
                vacina.nomeVacina = txtVacina.Text;
                aux = criancaLogada.sp_createVacina(criancaLogada, vacina);
                MessageBox.Show(aux, "Vacina");
                this.Hide();
                txtVacina.Text = string.Empty;
            }
        }
    }
}
