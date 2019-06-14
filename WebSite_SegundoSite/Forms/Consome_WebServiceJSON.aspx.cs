using ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Consome_WebServiceJSON : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        carregarPagina();
    }

    public void carregarPagina()
    {
        //carregaPessoa();
        carregarListaDePessoas();
    }

    //MONTA 1 OBJETO COM DADOS DE JSON
    public void carregaPessoa()
    {
        MeuWS.WebService ws = new MeuWS.WebService();
        var dados = ws.retornaPessoa();
        //MOSTRA JSON EM STRING
        //Response.Write(dados);

        //MONTA 1 OBJETO COM DADOS DE JSON
        Pessoa dados_limpos = JsonConvert.DeserializeObject<Pessoa>(dados.ToString());
        Response.Write("ID: " + dados_limpos.uid_pessoa);
        Response.Write("Nome: " + dados_limpos.nome);
        Response.Write("Idade: " + dados_limpos.idade);
        Response.Write("Email: " + dados_limpos.email);
    }

    //MOSTRA VALORES DE JSON EM LISTA
    public void carregarListaDePessoas()
    {
        MeuWS.WebService ws = new MeuWS.WebService();
        var dados = ws.retornaListaDePessoas();

        ////MOSTRA JSON EM STRING
        //Response.Write(dados);
        ////OU
        //for (int i = 0; i < dados.Count(); i++)
        //{
        //    Response.Write(dados[i].ToString());
        //}

        //MOSTRA VALORES DE JSON EM LISTA
        List<Pessoa> listaDePessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dados.ToString());
        dgPessoas.DataSource = listaDePessoas;
        dgPessoas.DataBind();

        //DYNAMIC É UMA VARIÁVEL PARECIDA COM VAR, E NESTE CASO ESTÁ MOLDANDO UM OBJETO QUE NÃO EXISTE, E ARMAZENANDO OS VALORES
        dynamic lista = JsonConvert.DeserializeObject(dados);
        foreach (var item in lista)
        {
            Response.Write("Nome: " + item.Nome + " / Idade: " + item.Idade + " / E-mail: " + item.Email + "<br>");
            //Pessoa p = new Pessoa();
            //p.uid_pessoa = item.UID_Pessoa;
            //p.nome = item.Nome;
            //p.idade = item.Idade;
            //p.email = item.Email;
            //listaDePessoas.Add(p);
        }
    }

}