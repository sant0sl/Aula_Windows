using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarTabelaAlunos();
    }

    public void carregarTabelaAlunos()
    {
        if (!IsPostBack)
        {
            Aluno aluno = new Aluno();
            dgAlunos.DataSource = aluno.buscaAlunos();
            dgAlunos.DataBind();
        }
        else
        {
            Aluno aluno = new Aluno();
            dgAlunos.DataSource = aluno.buscaAlunos();
            dgAlunos.DataBind();
        }
    }
    
    protected void dgAlunos_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Notas"))
        {
            Response.Redirect("Dados_Notas.aspx?idAluno=" + e.Item.Cells[0].Text);
        }
        else if (e.CommandName.Equals("Alterar"))
        {
            Response.Redirect("Dados_Alunos.aspx?id=" + e.Item.Cells[0].Text);
        }
        else if (e.CommandName.Equals("Apagar"))
        {
            Aluno a = new Aluno();
            a.id = Convert.ToInt32(e.Item.Cells[0].Text);
            a.excluirAluno();
            Response.Redirect("Index.aspx");
        }
    }

}