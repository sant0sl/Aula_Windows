using RevisaoBimestralForms.Classes;
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

namespace RevisaoBimestralForms.Forms
{
    public partial class NovoServicoPC : Form
    {
        private PC pcAtual;
        public NovoServicoPC()
        {
            InitializeComponent();
            pcAtual = new PC();
            carregarComboTiposServico();
            limparCampos();
        }

        //Métodos
        public void limparCampos()
        {
            cbStatus.SelectedValue = 1;
            txtCPFCliente.Text = string.Empty;
            rdbtnPronto.Checked = false;
            rdbtnNaoPronto.Checked = true;
            txtProcessador.Text = string.Empty;
            txtPlacaMae.Text = string.Empty;
            txtFonte.Text = string.Empty;
            txtCoolerCPU.Text = string.Empty;
            txtRam.Text = string.Empty;
            txtHD.Text = string.Empty;
            txtSSD.Text = string.Empty;
            txtVGA.Text = string.Empty;
            txtGabinete.Text = string.Empty;
            txtObs.Text = string.Empty;
        }
        
        public void voltar()
        {
            this.Hide();
        }

        public void carregarComboTiposServico()
        {
            Usuario u = new Usuario();
            cbStatus.DataSource = u.sp_readComboServicos().Tables[0];
            cbStatus.DisplayMember = "nomeServico";
            cbStatus.ValueMember = "uid_tipoServico";
        }

        public void cadastrarPC()
        {
            if (MessageBox.Show("Deseja mesmo registrar definitivamente as informações deste serviço?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario u = new Usuario();
                pcAtual.fk_tipoServico = Convert.ToInt32(cbStatus.SelectedValue);
                pcAtual.cpfCliente = txtCPFCliente.Text;
                if (rdbtnPronto.Checked == true)
                {
                    pcAtual.statuspc = true;
                }
                else
                {
                    pcAtual.statuspc = false;
                }
                pcAtual.processador = txtProcessador.Text;
                pcAtual.placaMae = txtPlacaMae.Text;
                pcAtual.fonte = txtFonte.Text;
                pcAtual.coolerProcessador = txtCoolerCPU.Text;
                pcAtual.memoriaRam = txtRam.Text;
                pcAtual.hd = txtHD.Text;
                pcAtual.ssd = txtSSD.Text;
                pcAtual.placaDeVideo = txtVGA.Text;
                pcAtual.gabinete = txtGabinete.Text;
                pcAtual.observacoes = txtObs.Text;
                string aux = u.sp_createPC(pcAtual);
                this.Hide();
                MessageBox.Show(aux, "Mensagem");
            }
        }

        //Componentes e eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cadastrarPC();
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            Validador.verificarCPFForms(txtCPFCliente, txtProcessador);
        }
    }
}
