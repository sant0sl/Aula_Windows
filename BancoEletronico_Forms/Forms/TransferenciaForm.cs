using BancoEletronico_Forms.Classes;
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

namespace BancoEletronico_Forms.Forms
{
    public partial class TransferenciaForm : Form
    {
        ContaBancaria cbEmissor;
        ContaBancaria cbRecebedor;

        public TransferenciaForm()
        {
            InitializeComponent();
        }

        public TransferenciaForm(ContaBancaria cb)
        {
            InitializeComponent();
            cbEmissor = cb;
            cbRecebedor = new ContaBancaria();
            carregarEmissor();
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            transferencia();
        }

        public void transferencia()
        {
            string aux = string.Empty;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            ContaBancaria contaBancaria = new ContaBancaria();
            if (txtCPFRecebedor.Text.Equals("") || txtValor.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo de CPF do recebedor, e o valor da transação.", "Transferência");
                limparCampos();
            }
            else if (txtNomeCompletoRecebedor.Text.Equals(""))
            {
                MessageBox.Show("Não foi encontrado alguma conta com este CPF de Recebedor", "Transferência");
                limparCampos();
            }
            else
            {
                aux = contaBancaria.sp_transferenciaBancaria(cbEmissor, cbRecebedor, valor);
                MessageBox.Show(aux, "Transferência");
                this.Hide();
            }
        }

        public void limparCampos()
        {
            txtCPFRecebedor.Text = string.Empty;
            txtNomeCompletoRecebedor.Text = string.Empty;
            txtValor.Text = string.Empty;
            cbRecebedor = new ContaBancaria();
        }

        public void carregarEmissor()
        {
            txtCPFEmissor.Text = cbEmissor.cpf;
            txtNomeCompletoEmissor.Text = cbEmissor.nomecompleto;
        }

        public void carregarRecebedor()
        {
            txtNomeCompletoRecebedor.Text = cbRecebedor.nomecompleto;
        }

        private void txtCPFRecebedor_Leave(object sender, EventArgs e)
        {
            if (Validacao.IsCpf(txtCPFRecebedor.Text))
            {
                cbRecebedor = cbRecebedor.sp_readContaByCPF(txtCPFRecebedor.Text);
                carregarRecebedor();
                txtValor.Focus();
            }
            else if (txtCPFRecebedor.Text.Equals(""))
            {
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Este CPF não é válido! Por favor, insira um válido.");
                txtCPFRecebedor.Text = null;
                txtCPFRecebedor.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //TODO ESSE CÓDIGO DO BANCOELETRONICOFORMS É DE AUTORIA DE https://www.steamcommunity.com/id/sant0sl
    }
}
