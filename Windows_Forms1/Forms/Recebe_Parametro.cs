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
    public partial class Recebe_Parametro : Form
    {

        public Recebe_Parametro()
        {
            InitializeComponent();
        }

        public Recebe_Parametro(string parametro)
        {
            InitializeComponent();
            txtRecebeParametro.Text = parametro;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Recebe_Parametro_Load(object sender, EventArgs e)
        {
            Envia_Parametro dadosForm = (Envia_Parametro)Application.OpenForms["Envia_Parametro"];
            txtRecebeParametro.Text = dadosForm.Controls["txtEnviaParametro"].Text;
        }
    }
}
