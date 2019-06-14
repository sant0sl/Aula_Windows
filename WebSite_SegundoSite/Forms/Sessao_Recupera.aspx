<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sessao_Recupera.aspx.cs" Inherits="Forms_Sessao_Recupera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formSessaoRecupera" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td width="80%" align="center">
                        <asp:Label ID="lblLogin" runat="server" Text="Login: "></asp:Label>
                        <asp:TextBox ID="txtLogin" Enabled="false" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
                        <asp:TextBox ID="txtSenha" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                    <td width="20%" align="center">
                        <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Sessao_Grava.aspx">Voltar</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
