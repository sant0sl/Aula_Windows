using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Home : System.Web.UI.Page
{
    private Usuario usuarioLogado;

    protected void Page_Load(object sender, EventArgs e)
    {
        string idUsuario = Session["idUser"].ToString();
        if (idUsuario == "nada")
        {
            Session["idUser"] = "nada";
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["idUser"] = "nada";
        Response.Redirect("Login.aspx");
    }

    protected void btnVerLog_Click(object sender, EventArgs e)
    {
        Response.Redirect("LogUser.aspx");
    }

    protected void btnValidar_Click(object sender, EventArgs e)
    {
        verificarEmail(txtContatos.Text);
        txtContatos.Text = string.Empty;
    }

    public void verificarEmail(string texto)
    {
        string[] emails = null;
        string email = texto;

        emails = email.Split(';');
        foreach (var item in emails)
        {
            Response.Write(item + " - " + verificarCaractere(item) + "<br><br>");
        }
    }

    public string verificarCaractere(string texto)
    {
        try
        {
            if (!texto.Contains('@'))
            {
                return "Email invalido (esta faltando o @)";
            }
            else if (!texto.Contains(".com"))
            {
                return "Email invalido (esta faltando o .com)";
            }
            else if (!texto.Contains('@') && !texto.Contains(".com"))
            {
                return "Email invalido (esta faltando o @ e tambem o .com)";
            }
            else
            {
                return "Email valido";
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}