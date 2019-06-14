using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Componentes : System.Web.UI.Page
{
    protected ListItem cbProf;

    protected void Page_Load(object sender, EventArgs e)
    {
        verificaLogin();
    }

    protected void btnAlert_Click(object sender, EventArgs e)
    {
        checkBoxAlert(txtNomeProf.Text, DropDownListProgramacao.SelectedItem);
    }

    protected void btnProcessar_Click(object sender, EventArgs e)
    {
        processarRadioButton();
    }

    protected void btnLimparCampos_Click(object sender, EventArgs e)
    {
        limparCampos();
    }

    protected void btnSelecionar_Click(object sender, EventArgs e)
    {
        txtIDProf.Text = DropDownListNome.SelectedValue;
        txtNomeProf.Text = DropDownListNome.SelectedItem.Text;
    }

    //Métodos
    public void carregarPagina()
    {
        if (!IsPostBack)
        {
            carregarProfessor();
        }
        
    }

    public void carregarProfessor()
    {
        Professor prof = new Professor();
        DropDownListNome.DataSource = prof.buscaProfessores();
        DropDownListNome.DataTextField = "Nome";
        DropDownListNome.DataValueField = "Id_professor";
        DropDownListNome.DataBind();
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
            HyperLinkVoltar.NavigateUrl = "Home.aspx?login=adm&senha=123";
            carregarPagina();
        }
    }

    public void alert(string mensagem)
    {
        Response.Write("<script>alert('" + mensagem + "')</script>");
    }

    public void checkBoxAlert(string professor, ListItem simounaoID)
    {
        string simounao = simounaoID.Text;
        try
        {
            if (chckAlert.Checked == true)
            {
                string mensagem = "Professor: " + professor + ", Dá esta aula?: " + simounao;
                alert(mensagem);
            }
            limparCampos();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void processarRadioButton()
    {
        foreach (ListItem item in rdbtnList.Items)
        {
            if (item.Selected == true)
            {
                alert(item.Text + " foi selecionado!!");
                limparCampos();
            }
        }
    }
    public void tirarSelecaoRadioButtonList()
    {
        foreach (ListItem item in rdbtnList.Items)
        {
            if (item.Selected == true)
            {
                item.Selected = false;
            }
        }
    }

    public void limparCampos()
    {
        DropDownListNome.SelectedValue = "1";
        txtIDProf.Text = string.Empty;
        txtNomeProf.Text = string.Empty;
        DropDownListProgramacao.SelectedValue = "1";
        chckAlert.Checked = false;
        tirarSelecaoRadioButtonList();
    }

}