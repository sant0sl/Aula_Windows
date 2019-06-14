using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Correios;
using Correios.CorreiosServiceReference;

namespace Windows_Forms1.Forms
{
    public partial class CEPForm : Form
    {
        CorreiosApi service;
        enderecoERP result;

        public CEPForm()
        {
            InitializeComponent();
            limparCampos();
        }

        public void limparCampos()
        {
            result = new enderecoERP();
            txtCEP.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtComplemento2.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCEPResult.Text = string.Empty;
        }

        public void carregarCampos(enderecoERP result)
        {
            txtLogradouro.Text = result.end;
            txtBairro.Text = result.bairro;
            txtComplemento.Text = result.complemento;
            txtComplemento2.Text = result.complemento2;
            txtMunicipio.Text = result.cidade;
            txtUF.Text = result.uf;
            txtCEPResult.Text = result.cep;
        }

        public void buscarCEP()
        {
            service = new CorreiosApi();
            result = new enderecoERP();
            result = service.consultaCEP(txtCEP.Text);

            carregarCampos(result);
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Validador.verificarCEPForms(txtCEP, txtLogradouro);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCEP();
        }
    }
}
