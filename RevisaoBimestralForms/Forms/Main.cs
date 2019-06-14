using RevisaoBimestralForms.Classes;
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

namespace RevisaoBimestralForms.Forms
{
    public partial class Main : Form
    {
        private Usuario usuarioLogado;

        public Main()
        {
            InitializeComponent();
        }

        public Main(Usuario u)
        {
            InitializeComponent();
            carregarUsuarioLogado(u);
        }

        //Métodos

        public void deslogar()
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
            Login form = new Login();
            form.Show();

            this.Hide();
        }

        public void sair()
        {
            Environment.Exit(0);
        }

        public void carregarUsuarioLogado(Usuario u)
        {
            usuarioLogado = u.sp_readUsuarioByCPF();
            carregarServicos();
        }

        public void carregarServicos()
        {
            dgvPCS.DataSource = usuarioLogado.sp_readPC().Tables[0];
        }

        public void filtrarPC(string filtro)
        {
            dgvPCS.DataSource = usuarioLogado.sp_readPCByCPFCliente(filtro).Tables[0];
        }

        public void alterarPC(object sender)
        {
            DataGridView dgv = sender as DataGridView;
            PC pc = new PC();
            pc.uid_pc = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            txtFiltro.Text = string.Empty;
            ServicoPC form = new ServicoPC(pc);
            form.Show();
        }

        public void novoUsuario()
        {
            NovoUsuario form = new NovoUsuario();
            form.Show();
        }

        public void gerenciarFuncionarios()
        {
            Usuarios form = new Usuarios();
            form.Show();
        }

        public void cadastrarPC()
        {
            NovoServicoPC form = new NovoServicoPC();
            form.Show();
        }

        public void alterarPerfil()
        {
            Logado form = new Logado(usuarioLogado);
            form.Show();
        }

        public void apagarPerfil()
        {
            if (MessageBox.Show("Deseja mesmo apagar definitivamente o seu perfil de usuário?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string aux = usuarioLogado.sp_deleteUsuario();
                deslogar();
                MessageBox.Show(aux, "Mensagem");
            }
        }

        //Componentes e eventos

        private void btnLogout_Click(object sender, EventArgs e)
        {
            deslogar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            novoUsuario();
        }

        private void btnGerenciarFuncionarios_Click(object sender, EventArgs e)
        {
            gerenciarFuncionarios();
        }

        private void btnCadastrarPC_Click(object sender, EventArgs e)
        {
            cadastrarPC();
        }

        private void btnAlterarPerfil_Click(object sender, EventArgs e)
        {
            alterarPerfil();
        }

        private void btnApagarPerfil_Click(object sender, EventArgs e)
        {
            apagarPerfil();
        }

        private void dgvPCS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            alterarPC(sender);
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            carregarUsuarioLogado(usuarioLogado);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrarPC(txtFiltro.Text);
        }
    }
}
