using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Home : System.Web.UI.Page
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
            HyperLinkCalculadora.NavigateUrl = "Calculadora.aspx?login=adm&senha=123";
            HyperLinkComponentes.NavigateUrl = "Componentes.aspx?login=adm&senha=123";
            HyperLinkPassaParamemetro.NavigateUrl = "Passa_Parametro.aspx?login=adm&senha=123";
            HyperLinkListagemProfessores.NavigateUrl = "Listagem_Professores.aspx?login=adm&senha=123";
            HyperLinkCookiesGrava.NavigateUrl = "Cookies_Grava.aspx?login=adm&senha=123";
            HyperLinkCookiesRecupera.NavigateUrl = "Cookies_Recupera.aspx?login=adm&senha=123";
            HyperLinkSessaoGrava.NavigateUrl = "Sessao_Grava.aspx?login=adm&senha=123";
            HyperLinkSessaoRecupera.NavigateUrl = "Sessao_Recupera.aspx?login=adm&senha=123";
            HyperLinkSessaoAddProfessores.NavigateUrl = "Sessao_AdicionarProfessor.aspx?login=adm&senha=123";
        }
    }
}