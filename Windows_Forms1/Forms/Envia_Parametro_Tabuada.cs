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
    public partial class Envia_Parametro_Tabuada : Form
    {
        public Envia_Parametro_Tabuada()
        {
            InitializeComponent();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            Recebe_Parametro_Tabuada formRecebe = new Recebe_Parametro_Tabuada(Convert.ToInt32(txtEnviaParametro.Text));
            formRecebe.Show();
            this.Dispose();
        }
    }
}
