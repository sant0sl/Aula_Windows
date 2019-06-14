using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AppConfigForms.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtNomeCampoRecuperar.Text = string.Empty;
            txtValorRecuperado.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtNomeCampoValor.Text = string.Empty;
            txtValorNovo.Text = string.Empty;
        }

        private void btnRecuperarNome_Click(object sender, EventArgs e)
        {
            if (!txtNomeCampoRecuperar.Text.Equals(""))
            {
                txtValorRecuperado.Text = ConfigurationManager.AppSettings[txtNomeCampoRecuperar.Text];
            }
            else
            {
                MessageBox.Show("Preencha o nome do campo.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[txtNomeCampoRecuperar.Text].Value = txtValor.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            limparCampos();
            MessageBox.Show("alterado!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNovoValor_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(txtNomeCampoValor.Text, txtValorNovo.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            limparCampos();
            MessageBox.Show("Campo novo cadastrado!");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(txtNomeCampoRecuperar.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            limparCampos();
            MessageBox.Show("Campo apagado!");
        }
    }
}
