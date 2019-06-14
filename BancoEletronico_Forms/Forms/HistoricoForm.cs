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
    public partial class HistoricoForm : Form
    {
        ContaBancaria cbLogada;

        public HistoricoForm()
        {
            InitializeComponent();
        }

        public HistoricoForm(ContaBancaria cb)
        {
            InitializeComponent();
            cbLogada = cb;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HistoricoForm_Activated(object sender, EventArgs e)
        {
            //Popular histórico
            dgvHistorico.DataSource = cbLogada.sp_consultarHistorico().Tables[0];
        }
        
    }
}
