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
using BancoEletronico_Forms.Forms;

namespace BancoEletronico_Forms
{
    public partial class MainForm : Form
    {
        ContaBancaria cbLogada;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(ContaBancaria cbLogin)
        {
            InitializeComponent();
            cbLogada = new ContaBancaria();
            cbLogada = cbLogin;
            lblNomeCPF.Text = cbLogada.nomecompleto;
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            decimal saldoaux = 0;
            saldoaux = cbLogada.sp_consultarSaldo();
            MessageBox.Show("Seu saldo atual é de R$"+saldoaux+" !!","Consulta de Saldo");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            HistoricoForm form = new HistoricoForm(cbLogada);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            DepositoForm form = new DepositoForm(cbLogada);
            form.Show();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            SaqueForm form = new SaqueForm(cbLogada);
            form.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string apagaraux = null;
            if (MessageBox.Show("Deseja mesmo apagar definitivamente a sua conta?", "Apagando Conta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                apagaraux = cbLogada.sp_deleteContaByCPF();
                logout();
                MessageBox.Show(apagaraux, "Apagando...");
            }
        }

        public void logout()
        {
            cbLogada = new ContaBancaria();
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            cbLogada = cbLogada.sp_readContaByCPF(cbLogada.cpf);
            lblNomeCPF.Text = cbLogada.nomecompleto;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarForm form = new AlterarForm(cbLogada);
            form.Show();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            TransferenciaForm form = new TransferenciaForm(cbLogada);
            form.Show();
        }
    }
}
