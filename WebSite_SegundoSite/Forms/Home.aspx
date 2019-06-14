<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Forms_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formHome" runat="server">
        <table border="1" width="100%">
            <tr>
                <td width="80%">
                    WEB FORMS
                </td>
                <td width="20%">
                    <asp:HyperLink ID="HyperLinkRecarregar" runat="server" NavigateUrl="~/Forms/Home.aspx">Logout</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLinkCalculadora" runat="server" NavigateUrl="~/Forms/Calculadora.aspx">Calculadora</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkComponentes" runat="server" NavigateUrl="~/Forms/Componentes.aspx">Componentes</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkPassaParamemetro" runat="server" NavigateUrl="~/Forms/Passa_Parametro.aspx">Passagem de Parâmetro</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkListagemProfessores" runat="server" NavigateUrl="~/Forms/Listagem_Professores.aspx">CRUD Professores</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   -
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkCookiesGrava" runat="server" NavigateUrl="~/Forms/Cookies_Grava.aspx">Cookies Grava</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkCookiesRecupera" runat="server" NavigateUrl="~/Forms/Cookies_Recupera.aspx">Cookies Recupera</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkSessaoGrava" runat="server" NavigateUrl="~/Forms/Sessao_Grava.aspx">Sessao Grava</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkSessaoRecupera" runat="server" NavigateUrl="~/Forms/Sessao_Recupera.aspx">Sessao Recupera</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkSessaoAddProfessores" runat="server" NavigateUrl="~/Forms/Sessao_AdicionarProfessor.aspx">Sessao Adicionar Professor</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkWS" runat="server" NavigateUrl="~/Forms/Consome_WebService.aspx">WebService</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkWSJSON" runat="server" NavigateUrl="~/Forms/Consome_WebServiceJSON.aspx">WebService JSON</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   <asp:HyperLink ID="HyperLinkComandosUteis" runat="server" NavigateUrl="~/Forms/Comandos_Uteis.aspx">Comandos Uteis</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                   -
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
