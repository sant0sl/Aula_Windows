using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Listagem_Professores : System.Web.UI.Page
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
            HyperLinkNovoProf.NavigateUrl = "Persistencia_Professor.aspx?login=adm&senha=123";
            HyperLinkVoltar.NavigateUrl = "Home.aspx?login=adm&senha=123";
            carregarTabelaProfessores();
        }
    }

    public void carregarTabelaProfessores()
    {
        if (!IsPostBack)
        {
            Professor prof = new Professor();
            dgProfessores.DataSource = prof.buscaProfessores();
            dgProfessores.DataBind();
        }
        else
        {
            Professor prof = new Professor();
            dgProfessores.DataSource = prof.buscaProfessores();
            dgProfessores.DataBind();
        }
    }

    protected void dgProfessores_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Update"))
        {
            Response.Redirect("Persistencia_Professor.aspx?login=adm&senha=123&id=" + e.Item.Cells[0].Text);
        }
        else if (e.CommandName.Equals("Delete"))
        {
            Professor prof = new Professor();
            prof.Id_Professor = Convert.ToInt32(e.Item.Cells[0].Text);
            prof.excluirProfessor();
            Response.Redirect("Listagem_Professores.aspx?login=adm&senha=123");
        }
    }

    //Paginação das tabelas
    protected void dgProfessores_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        dgProfessores.CurrentPageIndex = e.NewPageIndex;
        carregarTabelaProfessores();
    }

    //Manipulação de dados da tabela, como alterar dados de colunas, etc...
    protected void dgProfessores_ItemDataBound(object sender, DataGridItemEventArgs e)
    {
        if (e.Item.Cells[1].Text == "Marcão")
        {
            e.Item.Cells[1].Text = "<a href='https://www.google.com.br/'>Prof - Marcão</a>";
        }
        try
        {
            if (Convert.ToInt32(e.Item.Cells[2].Text) > 40)
            {
                e.Item.Cells[2].Text = "Velhinho";
            }
            else if (Convert.ToInt32(e.Item.Cells[2].Text) < 40)
            {
                e.Item.Cells[2].Text = "Adulto";
                e.Item.Attributes.Add("onmouseover", "this.style.backgroundColor='red'");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor='white'");
            }
        }
        catch { }
    }
}