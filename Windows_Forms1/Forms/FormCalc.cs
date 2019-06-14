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
    public partial class FormCalc : Form
    {
        double acumula = 0;
        string operacao = "";

        public FormCalc()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = null;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.AppendText("9");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operacao = "+";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operacao = "-";
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operacao = "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                operacao = "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Igual
            if (operacao == "+")
            {
                acumula += double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
                limpa();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
                limpa();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
                limpa();
            }
            else if (operacao == "/")
            {
                if (double.Parse(txtVisor.Text) != 0)
                {
                    acumula /= double.Parse(txtVisor.Text);
                    txtVisor.Text = acumula.ToString();
                    limpa();
                }
                else
                {
                    txtVisor.Text = "Dividindo por zero";
                    limpa();
                }
            }
        }
        public void limpa()
        {
            double acumula = 0;
            string operacao = "";
        }
    }
}
