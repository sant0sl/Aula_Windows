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
    public partial class MenuForms : Form
    {
        public MenuForms()
        {
            InitializeComponent();
        }

        private void btnEnviaParametro_Click(object sender, EventArgs e)
        {
            Envia_Parametro form = new Envia_Parametro();
            form.Show();
        }

        private void btnRecebeParametro_Click(object sender, EventArgs e)
        {
            Recebe_Parametro form = new Recebe_Parametro();
            form.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalc form = new FormCalc();
            form.Show();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            Envia_Parametro_Tabuada form = new Envia_Parametro_Tabuada();
            form.Show();
        }

        private void btnCadastrarProf_Click(object sender, EventArgs e)
        {
            Cadastrar_Professor form = new Cadastrar_Professor();
            form.Show();
        }

        private void btnComponentes_Click(object sender, EventArgs e)
        {
            Componentes form = new Componentes();
            form.Show();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            WebForm form = new WebForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecutarArquivos form = new ExecutarArquivos();
            form.Show();
        }

        private void btnDLL_Click(object sender, EventArgs e)
        {
            Dll form = new Dll();
            form.Show();
        }

        private void btnFormthread_Click(object sender, EventArgs e)
        {
            FormThread form = new FormThread();
            form.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CNPJCEP form = new CNPJCEP();
            form.Show();
        }
    }
}
