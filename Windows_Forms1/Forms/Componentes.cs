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
    public partial class Componentes : Form
    {
        public Componentes()
        {
            InitializeComponent();
        }

        private void btnCarrregaAlunos_Click(object sender, EventArgs e)
        {
            cbAlunos.Items.Add("Leonardo");
            cbAlunos.Items.Add("Talita");
            cbAlunos.Items.Add("Micael");
            cbAlunos.Items.Add("João");
        }

        private void Componentes_Activated(object sender, EventArgs e)
        {
            //carregaProfessores();
        }

        private void btnCarregaProfessores_Click(object sender, EventArgs e)
        {
            carregaProfessores();
        }

        private void btnPegaID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: "+cbProfessores.Text+"\nID: "+cbProfessores.SelectedValue, "Mensagem");
        }

        private void cbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateriasMuda();
        }

        private void btnSetaProf_Click(object sender, EventArgs e)
        {
            cbProfessores.SelectedValue = 4;
        }

        public void cbMateriasMuda()
        {
            //Limpa ComboBox
            cbDias.Items.Clear();
            cbDias.Text = string.Empty;

            if (cbMaterias.Text.Equals("C#"))
            {
                cbDias.Items.Add("Segunda 19:00 as 22:10");
                cbDias.Items.Add("Sexta 19:00 as 22:10");
            }
            else if (cbMaterias.Text.Equals("Java"))
            {
                cbDias.Items.Add("Terça 19:00 as 22:10");
                cbDias.Items.Add("Quinta 19:00 as 22:10");
            }
            else
            {
                cbDias.Items.Add("Indisponível");
            }
        }

        public void carregaProfessores()
        {
            Professor prof = new Professor();
            cbProfessores.DataSource = prof.buscaProfessores().Tables[0];
            cbProfessores.DisplayMember = "Nome";
            cbProfessores.ValueMember = "Id_professor";
        }

        private void btnMostraSelecionado_Click(object sender, EventArgs e)
        {
            if (rdbtnSim.Checked == true)
            {
                MessageBox.Show("Sim!");
            }
            else if(rdbtnNao.Checked == true){
                MessageBox.Show("Não!");
            }
            else
            {
                MessageBox.Show("Talvez!");
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            checkBoxBom.Checked = true;
            checkBoxMedio.Checked = true;
            checkBoxRuim.Checked = true;
        }

        private void btnDesmarca_Click(object sender, EventArgs e)
        {
            checkBoxBom.Checked = false;
            checkBoxMedio.Checked = false;
            checkBoxRuim.Checked = false;
        }

        private void btnVerificaCheck_Click(object sender, EventArgs e)
        {
            var selecionados = new System.Text.StringBuilder();

            if (checkBoxBom.Checked == true)
            {
                selecionados.AppendLine("Bom ");
            }
            else if (checkBoxMedio.Checked == true)
            {
                selecionados.AppendLine("Medio ");
            }
            else if (checkBoxRuim.Checked == true)
            {
                selecionados.AppendLine("Ruim.");
            }
            else
            {
                selecionados.AppendLine("Nenhum selecionado.");
            }

            MessageBox.Show(selecionados.ToString(), "Mensagem");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbMaterias.Items.Clear();
            cbDias.Items.Clear();
            cbAlunos.Items.Clear();
            //cbProfessores.Items.Clear();
            rdbtnSim.Checked = false;
            rdbtnNao.Checked = false;
            rdbtnTalvez.Checked = false;
            checkBoxBom.Checked = false;
            checkBoxMedio.Checked = false;
            checkBoxRuim.Checked = false;
            msktxtMascara.Text = string.Empty;
        }
    }
}
