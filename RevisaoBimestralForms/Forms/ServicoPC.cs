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

namespace RevisaoBimestralForms.Forms
{
    public partial class ServicoPC : Form
    {
        private PC pcAtual;

        public ServicoPC()
        {
            InitializeComponent();
        }

        public ServicoPC(PC pc)
        {
            InitializeComponent();
            Usuario u = new Usuario();
            pcAtual = u.sp_readPCByUID(pc);
            carregarCampos(u, pcAtual);
        }

        //Métodos

        public void carregarCampos(Usuario u, PC pc)
        {
            //Carrega Combo
            cbStatus.DataSource = u.sp_readComboServicos().Tables[0];
            cbStatus.DisplayMember = "nomeServico";
            cbStatus.ValueMember = "uid_tipoServico";
            //Carrega Infos
            txtID.Text = Convert.ToString(pc.uid_pc);
            txtCPFCliente.Text = pc.cpfCliente;
            cbStatus.SelectedValue = pc.fk_tipoServico;
            if (pc.statuspc == true)
            {
                rdbtnPronto.Checked = true;
            }
            else
            {
                rdbtnNaoPronto.Checked = true;
            }
            txtProcessador.Text = pc.processador;
            txtPlacaMae.Text = pc.placaMae;
            txtFonte.Text = pc.fonte;
            txtCoolerCPU.Text = pc.coolerProcessador;
            txtRam.Text = pc.memoriaRam;
            txtHD.Text = pc.hd;
            txtSSD.Text = pc.ssd;
            txtVGA.Text = pc.placaDeVideo;
            txtGabinete.Text = pc.gabinete;
            txtObs.Text = pc.observacoes;
        }

        public void voltar()
        {
            this.Hide();
        }

        public void alterar()
        {
            if (MessageBox.Show("Deseja mesmo alterar definitivamente as informações deste serviço?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario u = new Usuario();
                pcAtual.fk_tipoServico = Convert.ToInt32(cbStatus.SelectedValue);
                pcAtual.uid_pc = Convert.ToInt32(txtID.Text);
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
                string aux = u.sp_updatePC(pcAtual);
                this.Hide();
                MessageBox.Show(aux, "Mensagem");
            }
            else
            {
                this.Hide();
            }
        }

        public void finalizar()
        {
            if (MessageBox.Show("Deseja mesmo finalizar definitivamente este serviço?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario u = new Usuario();
                string aux = u.sp_finalizarServico(pcAtual);
                this.Hide();
                MessageBox.Show(aux, "Mensagem");
            }
            else
            {
                this.Hide();
            }
        }

        //Componentes e eventos

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            finalizar();
        }

    }
}
