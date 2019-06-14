using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text;
        string senha = txtSenha.Text;
        MeuWS.WebService ws = new MeuWS.WebService();
        Usuario usuario = new Usuario();
        var dados = ws.verificarLoginUsuario(login, senha);
        usuario = Newtonsoft.Json.JsonConvert.DeserializeObject<Usuario>(dados.ToString());
        if (usuario.nome != null)
        {
            usuario.registrarLog(usuario.id.ToString());
            Session["idUser"] = usuario.id;
            Response.Redirect("Home.aspx");
        }
        else
        {
            Session["idUser"] = "nada";
            Response.Redirect("Login.aspx");
        }
    }

}