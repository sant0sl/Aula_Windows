using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Dados_Notas : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        pageLoad();
    }

    public void pageLoad()
    {
        string idAluno = Request.QueryString["idAluno"];
        Aluno a = new Aluno();
        a = a.buscaAlunoByID(idAluno);
        carregarNotas(a);
        txtID.Text = a.id.ToString();
        List<Notas> lista_Notas = new List<Notas>();
        if (Session["Notas"] != null)
        {
            lista_Notas = (List<Notas>)Session["Notas"];
            dgNotasNaoSalvo.DataSource = lista_Notas;
            dgNotasNaoSalvo.DataBind();
        }
    }

    public void carregarNotas(Aluno a)
    {
        string idAluno = a.id.ToString();
        if (!IsPostBack)
        {
            ddlAlunos.DataSource = a.buscaAlunos();
            ddlAlunos.DataTextField = "nome";
            ddlAlunos.DataValueField = "id";
            ddlAlunos.DataBind();
            ddlAlunos.SelectedValue = idAluno;

            dgNotasBD.DataSource = a.buscaNotasByIDAluno(idAluno);
            dgNotasBD.DataBind();
        }
        else
        {
            ddlAlunos.DataSource = a.buscaAlunos();
            ddlAlunos.DataTextField = "nome";
            ddlAlunos.DataValueField = "id";
            ddlAlunos.DataBind();
            ddlAlunos.SelectedValue = idAluno;

            dgNotasBD.DataSource = a.buscaNotasByIDAluno(idAluno);
            dgNotasBD.DataBind();
        }
    }

    public Notas pegarValores()
    {
        Notas notas = new Notas();
        notas.idAluno = Convert.ToInt32(ddlAlunos.SelectedItem.Value);
        notas.idMateria = Convert.ToInt32(ddlMaterias.SelectedItem.Value);
        notas.nota = Convert.ToDecimal(txtNota.Text);
        return notas;
    }

    public string gerarID()
    {
        // caracteres para gerar o ID
        String caracteres = "qwertyuioplkjhgfdsazxcvbnmMNBVCXZASDFGHJKLPOIUYTREWQ0123456789";
        // instancia random
        Random aleatorio = new Random();
        // cria a string novaSenha
        String novoID = string.Empty;
        for (int i = 0; i < 10; ++i)
        {
            // gera um numero aleatório de acordo com a quantidade maxima da
            int gerador = aleatorio.Next(caracteres.Length);
            // concatena o caractere selecionado na nova senha
            novoID += caracteres[gerador];
        }
        // retorna o novo ID
        return novoID;
    }

    public void limparCampos()
    {
        ddlAlunos.SelectedValue = Request.QueryString["idAluno"];
        ddlMaterias.SelectedValue = "0";
        txtNota.Text = string.Empty;
    }

    public void adicionarNota()
    {
        List<Notas> lista_Notas = new List<Notas>();
        if (Session["Notas"] != null)
        {
            lista_Notas = (List<Notas>)Session["Notas"];
        }

        Notas nota = new Notas();
        nota = pegarValores();

        Random r = new Random();
        nota.id = r.Next();
        nota.quando = DateTime.Now;

        lista_Notas.Add(nota);
        limparCampos();
        
        Session["Notas"] = lista_Notas;

        dgNotasNaoSalvo.DataSource = lista_Notas;
        dgNotasNaoSalvo.DataBind();
    }

    public void salvarNotas()
    {
        List<Notas> lista_Notas = new List<Notas>();
        if (Session["Notas"] != null)
        {
            lista_Notas = (List<Notas>)Session["Notas"];
            Aluno aluno = new Aluno();
            Notas nota = new Notas();

            foreach (var item in lista_Notas)
            {
                item.id = Convert.ToInt32(txtID.Text);
                aluno.cadastrarNota(item);
            }

            Session.RemoveAll();
            lista_Notas = null;
            dgNotasNaoSalvo.DataSource = lista_Notas;
            dgNotasNaoSalvo.DataBind();
            pageLoad();
        }
        else
        {
            alert("A lista de notas na sessao está vazia!");
        }        
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

    protected void dgNotasNaoSalvo_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Apagar"))
        {
            List<Notas> lista_Notas = new List<Notas>();
            lista_Notas = (List<Notas>)Session["Notas"];

            Notas n = new Notas();
            n.id = Convert.ToInt32(e.Item.Cells[0].Text);
            foreach (var item in lista_Notas)
            {
                lista_Notas.Remove(n);
            }
            
            Session["Notas"] = lista_Notas;

            dgNotasNaoSalvo.DataSource = lista_Notas;
            dgNotasNaoSalvo.DataBind();
        }
    }

    protected void dgNotasBD_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Apagar"))
        {
            string idNota = e.Item.Cells[0].Text;
            Aluno a = new Aluno();
            a.excluirNota(idNota);
            pageLoad();
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        adicionarNota();
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        salvarNotas();
    }

    protected void btnLimparSessao_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        List<Notas> lista_Notas = new List<Notas>();
        lista_Notas = null;
        dgNotasNaoSalvo.DataSource = lista_Notas;
        dgNotasNaoSalvo.DataBind();
    }

}