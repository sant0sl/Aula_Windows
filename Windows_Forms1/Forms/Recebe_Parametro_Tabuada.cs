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
    public partial class Recebe_Parametro_Tabuada : Form
    {
        public Recebe_Parametro_Tabuada()
        {
            InitializeComponent();
        }

        public Recebe_Parametro_Tabuada(int numero)
        {
            InitializeComponent();

            lblTabuada.Text = tabuadaDoNumeroForm(numero);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public static string tabuadaDoNumeroForm(int numero1)
        {
            string tabuada = null;
            for (int i = 0; i < 11; i++)
            {
                //Console.WriteLine(numero1 + "X" + i + "=" + numero1 * i);
                tabuada += numero1 + "X" + i + "=" + numero1 * i + "\n";
            }
            return tabuada;
        }
    }
}
