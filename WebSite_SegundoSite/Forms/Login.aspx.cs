using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarCredenciais();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        fazerLogin();
    }

    public void fazerLogin()
    {
        if (cboxSalvarLogin.Checked)
        {
            verificarLogin();
            salvarCredenciais();
        }
        else
        {
            verificarLogin();
            naoSalvarCredenciais();
        }
    }

    public void verificarLogin()
    {
        if (txtLogin.Text.Equals("adm") && txtSenha.Text.Equals("123"))
        {
            Response.Redirect("Home.aspx?login=adm&senha=123");
        }
        else
        {
            Response.Redirect("Login.aspx");
            alert("Credenciais incorretas!");
        }
    }

    public void carregarCredenciais()
    {
        HttpCookie cookie = Request.Cookies["cookie_unifacear"];
        if (cookie.Values.Get("login") != "" && cookie.Values.Get("senha") != "")
        {
            txtLogin.Text = cookie.Values.Get("login");
            txtSenha.Text = cookie.Values.Get("senha");
        }
        else
        {

        }
    }

    public void salvarCredenciais()
    {
        string login = txtLogin.Text;
        string senha = txtSenha.Text;
        HttpCookie cookie = new HttpCookie("cookie_unifacear");
        cookie.Values.Add("login", login);
        cookie.Values.Add("senha", senha);
        cookie.Expires = DateTime.Now.AddYears(1);
        Response.AppendCookie(cookie);
    }

    public void naoSalvarCredenciais()
    {
        HttpCookie cookie = new HttpCookie("cookie_unifacear");
        cookie.Values.Add("login", "");
        cookie.Values.Add("senha", "");
        cookie.Expires = DateTime.Now.AddYears(1);
        Response.AppendCookie(cookie);
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

}