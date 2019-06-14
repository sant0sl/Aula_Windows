using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Sessao_Recupera : System.Web.UI.Page
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
            HyperLinkVoltar.NavigateUrl = "Sessao_Grava.aspx?login=adm&senha=123";
            carregarDadosSessao();
        }
    }

    public void carregarDadosSessao()
    {
        txtLogin.Text = Session["login"].ToString();
        txtSenha.Text = Session["senha"].ToString();
    }
}