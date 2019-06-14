using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Sessao_grava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        verificaLogin();
    }

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

    public void limparCampos()
    {
        txtLogin.Text = string.Empty;
        txtSenha.Text = string.Empty;
    }

    protected void btnGravaSessao_Click(object sender, EventArgs e)
    {
        Session["login"] = txtLogin.Text;
        Session["senha"] = txtSenha.Text;
        limparCampos();
    }

    protected void btnRecuperaSessao_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sessao_Recupera.aspx?login=adm&senha=123");
    }

}