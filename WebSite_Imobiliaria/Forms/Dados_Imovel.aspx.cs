using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Dados_Imovel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        carregaImovel(id);
    }

    public void carregaImovel(string id)
    {
        if (!IsPostBack)
        {
            Imovel imovel = new Imovel();
            imovel = imovel.buscaImovelPorID(id);
            if (imovel != null)
            {
                //setar os valores nos campos
                txtID.Text = imovel.id.ToString();
                txtCPF.Text = imovel.cpf;
                txtCidade.Text = imovel.cidade;
                txtBairro.Text = imovel.bairro;
                txtValor.Text = imovel.valor.ToString();
                if (imovel.situacao == true)
                {
                    DropDownListSituacao.SelectedValue = "1";
                }
                else
                {
                    DropDownListSituacao.SelectedValue = "0";
                }
                if (imovel.tipo_locacao == true)
                {
                    rdbtnListVendaLocacao.SelectedValue = "1";
                }
                else
                {
                    rdbtnListVendaLocacao.SelectedValue = "0";
                }
            }
            else
            {
                limparCampos();
            }
        }
    }

    public void limparCampos()
    {
        txtID.Text = "0";
        txtCPF.Text = string.Empty;
        txtCidade.Text = string.Empty;
        txtBairro.Text = string.Empty;
        txtValor.Text = "0";
        DropDownListSituacao.SelectedValue = "1";
        rdbtnListVendaLocacao.SelectedValue = "1";
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

    public void salvarImovel()
    {
        Imovel im = new Imovel();
        im.id = Convert.ToInt32(txtID.Text);
        im.cpf = txtCPF.Text;
        im.cidade = txtCidade.Text;
        im.bairro = txtBairro.Text;
        im.valor = Convert.ToDecimal(txtValor.Text);
        if (DropDownListSituacao.SelectedItem.Value == "1")
        {
            im.situacao = true;
        }
        else
        {
            im.situacao = false;
        }
        if (rdbtnListVendaLocacao.SelectedItem.Value == "1")
        {
            im.tipo_locacao = true;
        }
        else
        {
            im.tipo_locacao = false;
        }
        if (txtID.Text == "0")
        {
            im.cadastrarImovel();
        }
        else
        {
            im.alterarImovel();
        }
        //alert(im.id + " - " + im.cpf + " - " + im.cidade + " - " + im.bairro + " - " + im.situacao + " - " + im.tipo_locacao + " - " + im.valor);
        Response.Redirect("Index.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        salvarImovel();
    }
}