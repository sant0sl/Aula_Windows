using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Sessao_AdicionarProfessor : System.Web.UI.Page
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

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx?login=adm&senha=123");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        List<Professor> lista_professor = new List<Professor>();
        if (Session["Professores"] != null)
        {
            lista_professor = (List<Professor>)Session["Professores"];
        }

        Professor p = new Professor();
        p.Nome = txtNome.Text;
        lista_professor.Add(p);

        Session["Professores"] = lista_professor;

        dgProfessores.DataSource = lista_professor;
        dgProfessores.DataBind();
    }

}