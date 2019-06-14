using ClassLibrary;
using Consulta.CNPJ.Models;
using Consulta.CNPJ.Services;
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
    public partial class CNPJForm : Form
    {
        CNPJService service;
        CNPJResult result;

        public CNPJForm()
        {
            InitializeComponent();
            limparCampos();
        }

        public void limparCampos()
        {
            result = new CNPJResult();
            txtCNPJ.Text = string.Empty;
            txtCNPJResult.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEFR.Text = string.Empty;
            txtUltimaAtualizacao.Text = string.Empty;
            txtCapitalSocial.Text = string.Empty;
            txtAbertura.Text = string.Empty;
            txtNaturezaJuridica.Text = string.Empty;
            txtSituacao.Text = string.Empty;
            txtSituacaoEspecial.Text = string.Empty;
            txtDataSituacao.Text = string.Empty;
            txtDataSituacaoEspecial.Text = string.Empty;
            txtMotivoSituacao.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtCEP.Text = string.Empty;
        }

        public void carregarCampos(CNPJResult result)
        {
            txtCNPJResult.Text = result.Cnpj;
            txtTipo.Text = result.Tipo;
            txtStatus.Text = result.Status;
            txtNome.Text = result.Nome;
            txtFantasia.Text = result.Fantasia;
            txtEmail.Text = result.Email;
            txtEFR.Text = result.Efr;
            txtUltimaAtualizacao.Text = Convert.ToString(result.UltimaAtualizacao);
            txtCapitalSocial.Text = result.CapitalSocial;
            txtAbertura.Text = result.Abertura;
            txtNaturezaJuridica.Text = result.NaturezaJuridica;
            txtSituacao.Text = result.Situacao;
            txtSituacaoEspecial.Text = result.SituacaoEspecial;
            txtDataSituacao.Text = result.DataSituacao;
            txtDataSituacaoEspecial.Text = result.DataSituacaoEspecial;
            txtMotivoSituacao.Text = result.MotivoSituacao;
            txtLogradouro.Text = result.Logradouro;
            txtBairro.Text = result.Bairro;
            txtComplemento.Text = result.Complemento;
            txtNumero.Text = result.Numero;
            txtTelefone.Text = result.Telefone;
            txtMunicipio.Text = result.Municipio;
            txtUF.Text = result.Uf;
            txtCEP.Text = result.Cep;
        }

        public void buscarCNPJ()
        {
            service = new CNPJService();
            result = new CNPJResult();
            result = service.ConsultarCPNJ(txtCNPJ.Text);

            carregarCampos(result);
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            Validador.verificarCNPJForms(txtCNPJ, txtNome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCNPJ();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

    }
}
