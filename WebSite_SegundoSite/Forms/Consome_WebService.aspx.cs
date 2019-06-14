using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Consome_WebService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarProfessores();
        limparCampos();
    }

    public void carregarProfessores()
    {
        MeuWS.WebService ws = new MeuWS.WebService();
        dgProfessores.DataSource = ws.buscaProfessores();
        dgProfessores.DataBind();
    }

    public void voltar()
    {
        Response.Redirect("Home.aspx?login=adm&senha=123");
    }

    public void limparCampos()
    {
        txtN1.Text = string.Empty;
        txtN2.Text = string.Empty;
        txtResultado.Text = string.Empty;
        txtID.Text = "0";
        txtNome.Text = string.Empty;
        txtIdade.Text = string.Empty;
    }


    // Componentes

    protected void btnLimparCampos_Click(object sender, EventArgs e)
    {
        limparCampos();
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        voltar();
    }

    protected void btnSomar_Click(object sender, EventArgs e)
    {
        MeuWS.WebService ws = new MeuWS.WebService();
        int n1 = Convert.ToInt32(txtN1.Text);
        int n2 = Convert.ToInt32(txtN2.Text);
        int resultado = ws.somaNumero(n1, n2);
        txtResultado.Text = resultado.ToString();
    }

    protected void dgProfessores_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Alterar"))
        {
            txtID.Text = e.Item.Cells[0].Text;
            txtNome.Text = e.Item.Cells[1].Text;
            txtIdade.Text = e.Item.Cells[2].Text;
        }
        else if (e.CommandName.Equals("Deletar"))
        {
            MeuWS.WebService ws = new MeuWS.WebService();
            ws.deletarProfessor(e.Item.Cells[0].Text);
            carregarProfessores();
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        MeuWS.WebService ws = new MeuWS.WebService();
        if (txtID.Text == "0")
        {
            ws.cadastrarProfessor(txtNome.Text, txtIdade.Text);
        }
        else
        {
            ws.alterarProfessor(txtID.Text, txtNome.Text, txtIdade.Text);
        }
        limparCampos();
        carregarProfessores();
    }
    
}