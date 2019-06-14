using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Forms_Comandos_Uteis : System.Web.UI.Page
{
    string nome = "a";

    protected void Page_Load(object sender, EventArgs e)
    {
        //exemplo01();
        exemplo02();
        //exemplo03();
    }

    //TRIM & NULLORWHITESPACE
    public void exemplo01()
    {
        //Remove os espaços em branco antes e depois de uma string
        nome = nome.Trim();

        //Verifica se o valor da variável é nula ou com espaço em branco
        if (string.IsNullOrWhiteSpace(nome))
        {
            txtResultado.Text = "Nome está vazio";
        }
        else
        {
            txtResultado.Text = "Nome tem valor";
        }
    }

    //CONTAINS, ENDSWITH, INDEXOF, LASTINDEXOF, REMOVE, REPLACE, STARTSWITH, SUBSTRING, TOUPPER, TOLOWER
    public void exemplo02()
    {
        //nome = "Facear & CIA";
        //Response.Write("Nome original: " + nome);
        //Response.Write("<br>Nome alterado: " + nome.Replace("&", "e"));

        ////REPLACE TROCA (O QUE TEM NA STRING, SUBSTITUIR POR...)
        //Response.Write("<br>Nome alterado: " + nome.Replace("CIA", "LTDA"));

        ////REMOVE, REMOVE PARTE DO CONTEÚDO DE UMA STRING(COMEÇA A REMOVER EM TAL POSIÇÃO, REMOVE QUANTOS CARACTERES)
        //Response.Write("<br>Nome alterado: " + nome.Remove(0, 3));

        ////SUBSTRING, PEGA PARTE DE UM TEXTO PARA ARMAZENAR EM UMA VARIAVEL(COMEÇA A PEGAR EM TAL POSIÇÃO, PEGA QUANTO CARACTERES)
        //Response.Write("<br>Nome alterado: " + nome.Substring(4,3));

        ////TOUPPER (TUDO MAIÚSCULO)
        //Response.Write("<br>Nome alterado: " + nome.ToUpper());
        ////TOLOWER (TUDO MINÚSCULO)
        //Response.Write("<br>Nome alterado: " + nome.ToLower());

        ////CONTAINS, SE CONTÉM TAL CARACTERE DENTRO DE UMA STRING
        //if (nome.Contains('&'))
        //{
        //    txtResultado.Text = "Palavra possui &";
        //}
        //else
        //{
        //    txtResultado.Text = "Palavra não possui &";
        //}

        ////ENDSWITH (SE A STRING TERMINA COM DETERMINADO CARACTERE)
        //if (nome.EndsWith("a"))
        //{
        //    //Faz tal coisa
        //}
        ////STARTSWITH (SE A STRING COMEÇA COM DETERMINADO CARACTERE)
        //if (nome.StartsWith("X"))
        //{
        //    //Faz tal coisa
        //}

        ////INDEXOF, PEGA A POSIÇÃO DE UM DETERMINADO CARACTERE EM UMA STRING
        //int posicaoInicial = nome.IndexOf(';');
        ////LASTINDEXOF, PEGA A POSIÇÃO DA ÚLTIMA OCORRÊNCIA DE UM DETERMINADO CARACTERE EM UMA STRING
        //int posicaoFinal = nome.LastIndexOf(';');
        //txtResultado.Text = "O ; está na posição: " + posicaoInicial;

        ////COMO LER UM ARQUIVO TXT E MONTAR UMA LISTA DE OBJETOS DE PESSOA
        //string path = @"C:\Facear2019\pessoaTeste.txt";
        //List<Pessoa> listaPessoas = leitorDeRegistrosBlocoDeNotas(path);
        //dgPessoas.DataSource = listaPessoas;
        //dgPessoas.DataBind();
        
    }

    //DATAS E TIMESPAN
    public void exemplo03()
    {
        ////Data e Hora
        //Response.Write("<br>" + DateTime.Now);
        ////Data
        //txtResultado.Text = DateTime.Now.ToString("dd/MM/yyyy");
        ////Dia
        //Response.Write("<br>" + DateTime.Now.ToString("dd"));
        ////Mes
        //Response.Write("<br>" + DateTime.Now.ToString("MM"));
        ////Ano
        //Response.Write("<br>" + DateTime.Now.ToString("yyyy"));
        ////Hora
        //Response.Write("<br>" + DateTime.Now.ToString("HH"));
        ////Minuto
        //Response.Write("<br>" + DateTime.Now.ToString("mm"));
        ////Segundos
        //Response.Write("<br>" + DateTime.Now.ToString("ss"));

        string dataDeNascimento = "1998-10-19";
        calculadoraDeAnos(dataDeNascimento);
    }

    //dataNascimento = Ano-Mes-Dia
    public void calculadoraDeAnos(string dataNascimento)
    {
        //Calculo de dias entre datas
        string dataInicial = dataNascimento;
        string dataFinal = DateTime.Now.ToString("dd/MM/yyyy");
        TimeSpan data = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);
        DateTime idade = DateTime.MinValue + data;

        // note: MinValue is 1/1/1 so we have to subtract...
        int Years = idade.Year - 1;
        int Months = idade.Month - 1;
        int Days = idade.Day - 1;

        Response.Write("<br> Tempo de vida percorrido: " + Years.ToString() + " anos, " + Months.ToString() + " meses, e " + Days.ToString() + " dias");
        Response.Write("<br> Dias passados: " + data.TotalDays);
    }

    //Ler linhas de registros de um bloco de notas
    public List<Pessoa> leitorDeRegistrosBlocoDeNotas(string path)
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        string[] linhas = File.ReadAllLines(path);
        string registros = string.Empty;
        string[] registrosLista = null;

        foreach (string linha in linhas)
        {
            registros = linha;
            registrosLista = registros.Split(';');
            Pessoa p = new Pessoa();
            p.uid_pessoa = Convert.ToInt32(registrosLista[0]);
            p.nome = registrosLista[1];
            p.idade = Convert.ToInt32(registrosLista[2]);
            p.email = registrosLista[3];
            listaPessoas.Add(p);
        }

        return listaPessoas;
    }

}