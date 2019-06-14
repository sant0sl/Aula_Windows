using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Persistencia_Professor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        verificaLogin();
    }

    public void verificaLogin()
    {
        string login = Request.QueryString["login"];
        string senha = Request.QueryString["senha"];
        string id = Request.QueryString["id"];

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
            carregaProfessor(id);
        }
    }

    public void carregaProfessor(string id)
    {
        if (!IsPostBack)
        {
            Professor prof = new Professor();
            prof = prof.buscaProfessoresPorID(id);
            if (prof != null)
            {
                //setar os valores nos campos
                txtID.Text = prof.Id_Professor.ToString();
                txtNome.Text = prof.Nome;
                txtIdade.Text = prof.Idade.ToString();
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
        txtIdade.Text = "0";
    }

    public void salvarProfessor()
    {
        Professor p = new Professor();
        p.Id_Professor = Convert.ToInt32(txtID.Text);
        p.Nome = txtNome.Text;
        p.Idade = Convert.ToInt32(txtIdade.Text);
        if (txtID.Text.Equals("0"))
        {
            p.cadastrarProfessor();
        }
        else
        {
            p.alterarProfessor();

        }
        Response.Redirect("Listagem_Professores.aspx?login=adm&senha=123");
        //alert(Convert.ToInt32(txtID.Text) + " - " + txtNome.Text + " - " + Convert.ToInt32(txtIdade.Text));
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Listagem_Professores.aspx?login=adm&senha=123");
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        salvarProfessor();
    }
}