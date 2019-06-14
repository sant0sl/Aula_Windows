using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Calculadora : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        verificaLogin();
    }

    protected void btnSomar_Click(object sender, EventArgs e)
    {
        txtResultado.Text = somar(txtValor1.Text, txtValor2.Text);
    }

    protected void btnDiminuir_Click(object sender, EventArgs e)
    {
        txtResultado.Text = diminuir(txtValor1.Text, txtValor2.Text);
    }

    protected void btnMultiplicar_Click(object sender, EventArgs e)
    {
        txtResultado.Text = multiplicar(txtValor1.Text, txtValor2.Text);
    }

    protected void btnDividir_Click(object sender, EventArgs e)
    {
        txtResultado.Text = dividir(txtValor1.Text, txtValor2.Text);
    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        limparCampos();
    }

    //Métodos

    public void verificaLogin()
    {
        string login = Request.QueryString["login"];
        string senha = Request.QueryString["senha"];

        if (login == null || senha == null)
        {
            Response.Redirect("Login.aspx");
        }
        else if (login != "adm" || senha != "123")
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            HyperLinkVoltar.NavigateUrl = "Home.aspx?login=adm&senha=123";
        }
    }

    public String somar(string campoValor1, string campoValor2)
    {
        string resultado = string.Empty;
        resultado = (Convert.ToInt32(campoValor1) + Convert.ToInt32(campoValor2)).ToString();
        return resultado;
    }

    public String diminuir(string campoValor1, string campoValor2)
    {
        string resultado = string.Empty;
        resultado = (Convert.ToInt32(campoValor1) - Convert.ToInt32(campoValor2)).ToString();
        return resultado;
    }

    public String multiplicar(string campoValor1, string campoValor2)
    {
        string resultado = string.Empty;
        resultado = (Convert.ToInt32(campoValor1) * Convert.ToInt32(campoValor2)).ToString();
        return resultado;
    }

    public String dividir(string campoValor1, string campoValor2)
    {
        string resultado = string.Empty;
        resultado = (Convert.ToInt32(campoValor1) / Convert.ToInt32(campoValor2)).ToString();
        return resultado;
    }

    public void limparCampos()
    {
        txtResultado.Text = string.Empty;
        txtValor1.Text = string.Empty;
        txtValor2.Text = string.Empty;
    }

}