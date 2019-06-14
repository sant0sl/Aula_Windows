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
        carregarTabelaimoveis();
    }

    public void carregarTabelaimoveis()
    {
        if (!IsPostBack)
        {
            Imovel imovel = new Imovel();
            dgImoveis.DataSource = imovel.buscaImoveis();
            dgImoveis.DataBind();
        }
        else
        {
            Imovel imovel = new Imovel();
            dgImoveis.DataSource = imovel.buscaImoveis();
            dgImoveis.DataBind();
        }
    }

    public void carregarTabelaPorDisp(bool p)
    {
        Imovel imovel1 = new Imovel();
        dgImoveis.DataSource = imovel1.buscaImoveisPorSituacao(p);
        dgImoveis.DataBind();
    }

    public void carregarTabelaPorFiltro(string filtro)
    {
        Imovel imovel2 = new Imovel();
        dgImoveis.DataSource = imovel2.buscaImoveisPorFiltro(filtro);
        dgImoveis.DataBind();
    }

    public void carregarTabelaPorTipo(bool t)
    {
        Imovel imovel3 = new Imovel();
        dgImoveis.DataSource = imovel3.buscaImoveisPorTipo(t);
        dgImoveis.DataBind();
    }

    public void limparComponentes()
    {
        if (checkBoxDisp.Checked == true)
        {
            checkBoxDisp.Checked = false;
        }
        txtFiltro.Text = string.Empty;
        foreach (ListItem item in rdbtnListVendaLocacao.Items)
        {
            if (item.Selected == true)
            {
                item.Selected = false;
            }
        }
    }

    protected void dgImoveis_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName.Equals("Alterar"))
        {
            Response.Redirect("Dados_Imovel.aspx?id=" + e.Item.Cells[0].Text);
        }
        else if (e.CommandName.Equals("Deletar"))
        {
            Imovel p = new Imovel();
            p.id = Convert.ToInt32(e.Item.Cells[0].Text);
            p.excluirImovel();
            Response.Redirect("Index.aspx");
        }
    }

    protected void btnBuscarDisp_Click(object sender, EventArgs e)
    {
        if (checkBoxDisp.Checked == true)
        {
            carregarTabelaPorDisp(true);
            limparComponentes();
        }
        else
        {
            carregarTabelaPorDisp(false);
            limparComponentes();
        }
    }

    protected void btnBuscarFiltro_Click(object sender, EventArgs e)
    {
        carregarTabelaPorFiltro(txtFiltro.Text);
        limparComponentes();
    }

    protected void btnBuscarTipo_Click(object sender, EventArgs e)
    {
        if (rdbtnListVendaLocacao.SelectedItem.Value == "1")
        {
            carregarTabelaPorTipo(true);
            limparComponentes();
        }
        else
        {
            carregarTabelaPorTipo(false);
            limparComponentes();
        }
    }

    protected void btnTodosOsDados_Click(object sender, EventArgs e)
    {
        carregarTabelaimoveis();
        limparComponentes();
    }

}