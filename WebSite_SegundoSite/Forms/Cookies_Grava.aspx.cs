using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Cookies_Grava : System.Web.UI.Page
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

    protected void btnGravaCookie_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text;
        string senha = txtSenha.Text;
        HttpCookie cookie = new HttpCookie("cookie_unifacear");
        cookie.Values.Add("login", login);
        cookie.Values.Add("senha", senha);
        cookie.Expires = DateTime.Now.AddMinutes(10);
        Response.AppendCookie(cookie);
        limparCampos();
    }

    protected void btnRecuperaCookie_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cookies_Recupera.aspx?login=adm&senha=123");
    }
}