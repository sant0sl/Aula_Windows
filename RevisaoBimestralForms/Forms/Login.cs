using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevisaoBimestralForms.Classes;
using ClassLibrary;

namespace RevisaoBimestralForms.Forms
{
    public partial class Login : Form
    {
        private Usuario usuarioLogin;

        public Login()
        {
            InitializeComponent();
            usuarioLogin = new Usuario();
            carregarCredenciais();
        }

        //Métodos

        public void limparCampos()
        {
            txtCPF.Text = string.Empty;
            txtSenha.Text = string.Empty;
            chBoxLogado.Checked = false;
            usuarioLogin = new Usuario();
        }

        public void logout()
        {
            Environment.Exit(0);
        }

        public void carregarCredenciais()
        {
            string checkaux = ConfigurationManager.AppSettings["check_login"];
            usuarioLogin.cpf = ConfigurationManager.AppSettings["cpf_login"];
            usuarioLogin.senha = ConfigurationManager.AppSettings["senha_login"];
            if (!usuarioLogin.cpf.Equals("admin") && !usuarioLogin.senha.Equals("admin"))
            {
                txtCPF.Text = usuarioLogin.cpf;
                txtSenha.Text = usuarioLogin.senha;
                if (checkaux.Equals("1"))
                {
                    chBoxLogado.Checked = true;
                }
            }
            else
            {
                limparCampos();
            }
        }

        public void salvarCredenciais()
        {
            if (!txtCPF.Text.Equals("") || !txtSenha.Text.Equals(""))
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("cpf_login");
                config.AppSettings.Settings.Remove("senha_login");
                config.AppSettings.Settings.Remove("check_login");
                config.AppSettings.Settings.Add("cpf_login", txtCPF.Text);
                config.AppSettings.Settings.Add("senha_login", txtSenha.Text);
                config.AppSettings.Settings.Add("check_login", "1");
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                limparCampos();
            }
        }

        public void naoSalvarCredenciais()
        {
            if (!txtCPF.Text.Equals("") || !txtSenha.Text.Equals(""))
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("cpf_login");
                config.AppSettings.Settings.Remove("senha_login");
                config.AppSettings.Settings.Remove("chack_login");
                config.AppSettings.Settings.Add("cpf_login", "admin");
                config.AppSettings.Settings.Add("senha_login", "admin");
                config.AppSettings.Settings.Add("check_login", "0");
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                limparCampos();
            }
        }

        public void fazerLogin()
        {
            if (chBoxLogado.Checked == true)
            {
                salvarCredenciais();
                login();
            }
            else
            {
                naoSalvarCredenciais();
                login();
            }
        }

        public void login()
        {
            usuarioLogin.cpf = txtCPF.Text;
            usuarioLogin.senha = txtSenha.Text;
            Usuario usuario = usuarioLogin.sp_readUsuarioByCPFandPass();
            if (usuario.nomeCompleto == null)
            {
                limparCampos();
                MessageBox.Show("CPF ou Senha incorretos..", "Mensagem");
            }
            else
            {
                Main form = new Main(usuario);
                form.Show();
                this.Hide();
            }
        }

        public void loginDireto()
        {
            usuarioLogin.cpf = ConfigurationManager.AppSettings["cpf_login"];
            usuarioLogin.senha = ConfigurationManager.AppSettings["senha_login"];
            if (!usuarioLogin.cpf.Equals("admin") && !usuarioLogin.senha.Equals("admin"))
            {
                Usuario usuario = usuarioLogin.sp_readUsuarioByCPFandPass();
                if (usuario.nomeCompleto == null)
                {
                    limparCampos();
                }
                else
                {
                    Main form = new Main(usuario);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                limparCampos();
            }
        }

        //Componentes e eventos

        private void btnSair_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            fazerLogin();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            loginDireto();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            Validador.verificarCPFForms(txtCPF, txtSenha);
        }
    }
}
