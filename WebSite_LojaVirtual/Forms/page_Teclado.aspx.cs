using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_page_Teclado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarProdutos();
    }

    public void carregarProdutos()
    {
        List<Produto> lista_produtos = new List<Produto>();
        Produto p1 = new Produto(1, "Deathstalker", 300);
        lista_produtos.Add(p1);
        Produto p2 = new Produto(2, "CK104", 400);
        lista_produtos.Add(p2);
        Produto p3 = new Produto(3, "CK108", 500);
        lista_produtos.Add(p3);
        Produto p4 = new Produto(4, "K70", 600);
        lista_produtos.Add(p4);
        dgProdutos.DataSource = lista_produtos;
        dgProdutos.DataBind();
    }

    protected void dgProdutos_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Add"))
        {
            List<Produto> lista_Carrinho = new List<Produto>();

            if (Session["carrinho"] != null)
            {
                lista_Carrinho = (List<Produto>)Session["carrinho"];
            }

            Produto p = new Produto();
            Random r = new Random();
            p.id = r.Next();
            p.descricao = e.Item.Cells[1].Text;
            p.valorUnitario = Convert.ToDecimal(e.Item.Cells[2].Text);
            p.qtd = 1;
            lista_Carrinho.Add(p);

            Session["carrinho"] = lista_Carrinho;
            //alert("Produto adicionado no carrinho!");
        }
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }
}