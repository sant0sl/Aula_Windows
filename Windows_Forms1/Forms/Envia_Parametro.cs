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
    public partial class Envia_Parametro : Form
    {
        public Envia_Parametro()
        {
            InitializeComponent();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            //Recebe_Parametro form = new Recebe_Parametro(txtEnviaParametro.Text);
            Recebe_Parametro form = new Recebe_Parametro();
            form.Show();
            this.Dispose();
        }

        private void txtEnviaParametro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
