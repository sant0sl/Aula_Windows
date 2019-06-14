
using ClassLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    public WebService()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public int somaNumero(int n1, int n2)
    {
        int resultado = 0;
        resultado = (n1 + n2);
        return resultado;
    }

    [WebMethod]
    public string retornaNomeCompleto(string nome, string sobrenome)
    {
        string nomeCompleto = string.Empty;
        nomeCompleto = nome + " " + sobrenome;
        return nomeCompleto;
    }

    //PROFESSOR-----------------------------------------------------

    [WebMethod]
    public void cadastrarProfessor(string nome, string idade)
    {
        Professor prof = new Professor();
        prof.Nome = nome;
        prof.Idade = Convert.ToInt32(idade);
        prof.cadastrarProfessor();
    }

    [WebMethod]
    public DataSet buscaProfessores()
    {
        Professor prof = new Professor();
        return prof.buscaProfessores();
    }

    [WebMethod]
    public void alterarProfessor(string id, string nome, string idade)
    {
        Professor prof = new Professor();
        prof.Id_Professor = Convert.ToInt32(id);
        prof.Nome = nome;
        prof.Idade = Convert.ToInt32(idade);
        prof.alterarProfessor();
    }

    [WebMethod]
    public void deletarProfessor(string id)
    {
        Professor prof = new Professor();
        prof.Id_Professor = Convert.ToInt32(id);
        prof.excluirProfessor();
    }

    //JSON-----------------------------------------------------------

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string retornaPessoa()
    {
        Pessoa p1 = new Pessoa();
        p1.uid_pessoa = 0;
        p1.nome = "Leonardo Sampaio dos Santos";
        p1.idade = 20;
        p1.email = "sant0sl@outlook.com";

        JavaScriptSerializer js = new JavaScriptSerializer();
        //Valor de variável ou objeto
        return js.Serialize(p1);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string retornaListaDePessoas()
    {
        DataTable tbPessoas = new DataTable();
        tbPessoas.Columns.Add(new DataColumn("UID_Pessoa", typeof(int)));
        tbPessoas.Columns.Add(new DataColumn("Nome", typeof(string)));
        tbPessoas.Columns.Add(new DataColumn("Idade", typeof(int)));
        tbPessoas.Columns.Add(new DataColumn("Email", typeof(string)));

        DataRow linha = tbPessoas.NewRow();
        linha["UID_Pessoa"] = 1;
        linha["Nome"] = "Leonardo Sampaio dos Santos";
        linha["Idade"] = 20;
        linha["Email"] = "sant0sl@outlook.com";
        tbPessoas.Rows.Add(linha);

        linha = tbPessoas.NewRow();
        linha["UID_Pessoa"] = 2;
        linha["Nome"] = "Micael Kukla Ramos";
        linha["Idade"] = 21;
        linha["Email"] = "mikeramos@hotmail.com";
        tbPessoas.Rows.Add(linha);

        return Serialize(tbPessoas);
    }

    //Serializar para obter lista de objetos
    private string Serialize(object value)
    {
        Type type = value.GetType();
        Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
        if (type == typeof(DataTable))
        {
            json.Converters.Add(new DataTableConverter());
        }
        if (type == typeof(DataSet))
        {
            json.Converters.Add(new DataSetConverter());
        }
        StringWriter sw = new StringWriter();
        Newtonsoft.Json.JsonTextWriter write = new Newtonsoft.Json.JsonTextWriter(sw);
        write.Formatting = Formatting.None;
        write.QuoteChar = '"';
        json.Serialize(write, value);
        string output = sw.ToString();
        write.Close();
        sw.Close();
        return output;
    }

    //PROVA 2----------------------------------------------------------

    [WebMethod]
    public string verificarLoginUsuario(string login, string senha)
    {
        Usuario usuario = new Usuario();
        usuario = usuario.verificarLogin(login, senha);
        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(usuario);
    }

    [WebMethod]
    public string pegarUsuarioID(string idUser)
    {
        Usuario usuario = new Usuario();
        usuario = usuario.pegarUsuarioID(idUser);
        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(usuario);
    }

    [WebMethod]
    public void registrarLogUsuario(string idUser)
    {
        Usuario usuario = new Usuario();
        usuario.registrarLog(idUser);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string tabelaLogUsuario(string idUser)
    {
        Usuario usuario = new Usuario();
        DataSet ds = new DataSet();
        ds = usuario.verificarLogUsuario(idUser);

        return Serialize(ds);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string tabelaLogUsuario2(string idUser)
    {
        Usuario usuario = new Usuario();

        DataSet ds = usuario.verificarLogUsuario(idUser);

        return Serialize(ds);
    }

}
