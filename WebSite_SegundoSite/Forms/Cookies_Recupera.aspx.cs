using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Cookies_Recupera : System.Web.UI.Page
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
            HyperLinkVoltar.NavigateUrl = "Cookies_Grava.aspx?login=adm&senha=123";
            recuperarCookie();
        }
    }

    public void recuperarCookie()
    {
        HttpCookie cookie = Request.Cookies["cookie_unifacear"];
        txtLogin.Text = cookie.Values.Get("login");
        txtSenha.Text = cookie.Values.Get("senha");
    }
}