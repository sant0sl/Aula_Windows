using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_LogUser : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string idUsuario = Session["idUser"].ToString();
        if (idUsuario == "nada")
        {
            Session["idUser"] = "nada";
            Response.Redirect("Login.aspx");
        }
        else
        {
            MeuWS.WebService ws = new MeuWS.WebService();
            var dados = ws.tabelaLogUsuario(idUsuario);
            System.Data.DataSet lista = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataSet>(dados.ToString());

            dgLog.DataSource = lista;
            dgLog.DataBind();
        }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

}