<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookies_Grava.aspx.cs" Inherits="Forms_Cookies_Grava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formCookiesGrava" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td width="50%" align="center">
                        <asp:Label ID="lblLogin" runat="server" Text="Login: "></asp:Label>
                        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
                        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                    </td>
                    <td width="40%" align="center">
                        <asp:Button ID="btnGravaCookie" runat="server" Text="Gravar Cookie" OnClick="btnGravaCookie_Click" />
                        &nbsp;
                        <asp:Button ID="btnRecuperaCookie" runat="server" Text="Recuperar Cookie" OnClick="btnRecuperaCookie_Click" />
                    </td>
                    <td width="10%" align="center">
                        <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Home.aspx">Voltar</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
