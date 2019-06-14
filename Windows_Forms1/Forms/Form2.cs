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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSoma10_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            resultado = Convert.ToInt32(txtValor.Text) + 10;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int resultadoSoma = 0;
            resultadoSoma = Convert.ToInt32(txtn1.Text) + Convert.ToInt32(txtn2.Text);
            txtResultadoSoma.Text = resultadoSoma.ToString();
        }
    }
}
