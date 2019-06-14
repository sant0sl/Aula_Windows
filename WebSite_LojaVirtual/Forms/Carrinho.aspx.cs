using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Carrinho : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarCarrinho();
    }

    public void carregarCarrinho()
    {
        List<Produto> lista_Carrinho = new List<Produto>();

        if (Session["carrinho"] != null)
        {
            lista_Carrinho = (List<Produto>)Session["carrinho"];
            dgProdutos.DataSource = lista_Carrinho;
            dgProdutos.DataBind();
        }
        else
        {
            dgProdutos.DataSource = null;
            dgProdutos.DataBind();
        }
    }

    protected void dgProdutos_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Alterar"))
        {
            txtID.Text = e.Item.Cells[0].Text;
            txtDesc.Text = e.Item.Cells[1].Text;
            txtValor.Text = e.Item.Cells[2].Text;
            txtQtd.Text = e.Item.Cells[3].Text;
        }
    }

    protected void btnExcluirTudo_Click(object sender, EventArgs e)
    {
        List<Produto> lista_Carrinho = new List<Produto>();
        if (Session["carrinho"] != null)
        {
            lista_Carrinho = (List<Produto>)Session["carrinho"];
        }

        //Session.RemoveAll();
        Session["carrinho"] = null;
        carregarCarrinho();
    }

    public void limparCampos()
    {
        txtID.Text = string.Empty;
        txtDesc.Text = string.Empty;
        txtValor.Text = string.Empty;
        txtQtd.Text = string.Empty;
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        List<Produto> lista_Carrinho = new List<Produto>();
        lista_Carrinho = (List<Produto>)Session["carrinho"];

        foreach (var item in lista_Carrinho)
        {
            if (item.id.Equals(txtID.Text))
            {
                item.qtd = Convert.ToInt32(txtQtd.Text);
            }
        }

        Session.RemoveAll();
        Session["carrinho"] = lista_Carrinho;
        carregarCarrinho();
        limparCampos();
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        List<Produto> lista_Carrinho = new List<Produto>();
        lista_Carrinho = (List<Produto>)Session["carrinho"];

        HttpCookie cookieLoja = new HttpCookie("cookieLoja");

        foreach (var item in lista_Carrinho)
        {
            cookieLoja.Values.Add("id", item.id.ToString());
            cookieLoja.Values.Add("descricao", item.descricao);
            cookieLoja.Values.Add("valorUnitario", item.valorUnitario.ToString());
            cookieLoja.Values.Add("qtd", item.qtd.ToString());
            cookieLoja.Expires = DateTime.Now.AddDays(7);
            Response.AppendCookie(cookieLoja);
        }

        alert("Valores gravado em cookie!");
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }
    
}