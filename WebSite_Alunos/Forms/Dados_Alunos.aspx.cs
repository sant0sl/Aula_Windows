using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Dados_Alunos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        carregarAluno(id);
    }

    public void carregarAluno(string id)
    {
        if (!IsPostBack)
        {
            Aluno aluno = new Aluno();
            aluno = aluno.buscaAlunoByID(id);
            if (aluno != null)
            {
                txtID.Text = aluno.id.ToString();
                txtNome.Text = aluno.nome;
                txtTurma.Text = aluno.turma;
            }
            else
            {
                limparCampos();
            }
        }
    }

    public void limparCampos()
    {
        txtID.Text = "0";
        txtNome.Text = string.Empty;
        txtTurma.Text = string.Empty;
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

    public void salvarAluno()
    {
        Aluno al = new Aluno();
        al.id = Convert.ToInt32(txtID.Text);
        al.nome = txtNome.Text;
        al.turma = txtTurma.Text;

        if (txtID.Text == "0")
        {
            al.cadastrarAluno();
            Response.Redirect("Index.aspx");
        }
        else
        {
            al.alterarAluno();
            Response.Redirect("Index.aspx");
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        salvarAluno();
    }
}