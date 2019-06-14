using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Passa_Parametro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        verificaLogin();
    }

    protected void btnPassaParametro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Recebe_Parametro.aspx?login=adm&senha=123&nome="+ txtNome.Text +"&idade="+ txtIdade.Text);
    }


    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx?login=adm&senha=123");
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
            //Response.Redirect("Home.aspx?login=adm&senha=123");
        }
    }
}