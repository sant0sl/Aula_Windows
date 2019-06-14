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

namespace LoginFormsAppConfig.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            verificar();
        }

        public void verificar()
        {
            string usuario = ConfigurationManager.AppSettings["usuario"];
            string senha = ConfigurationManager.AppSettings["senha"];
            if (!usuario.Equals("facear123") && !senha.Equals("facear123"))
            {
                carregarCampos();
            }
            else
            {
                limparCampos();
            }
        }

        public void limparCampos()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            chckBoxSalvar.Checked = false;
        }

        public void carregarCampos()
        {
            txtUsuario.Text = ConfigurationManager.AppSettings["usuario"];
            txtSenha.Text = ConfigurationManager.AppSettings["senha"];
        }

        public void salvarCampos()
        {
            if (!txtUsuario.Text.Equals("") || !txtSenha.Text.Equals(""))
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("usuario");
                config.AppSettings.Settings.Remove("senha");
                config.AppSettings.Settings.Add("usuario", txtUsuario.Text);
                config.AppSettings.Settings.Add("senha", txtSenha.Text);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                limparCampos();
                MessageBox.Show("Logado e cadastrado!");
                Environment.Exit(0);
            }
            else
            {
                limparCampos();
                MessageBox.Show("Preencha os Campos..");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (chckBoxSalvar.Checked == true)
            {
                salvarCampos();
            }
            else
            {
                if (!txtUsuario.Text.Equals("") || !txtUsuario.Text.Equals(""))
                {
                    limparCampos();
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Remove("usuario");
                    config.AppSettings.Settings.Remove("senha");
                    config.AppSettings.Settings.Add("usuario", "facear123");
                    config.AppSettings.Settings.Add("senha", "facear123");
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Logado!");
                }
                else
                {
                    limparCampos();
                    MessageBox.Show("Preencha os Campos..");
                }
            }
        }
    }
}
