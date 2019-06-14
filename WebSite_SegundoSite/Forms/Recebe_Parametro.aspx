<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Recebe_Parametro.aspx.cs" Inherits="Forms_Recebe_Parametro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formRecebe" runat="server">
        <table border="1" width="100%>
            <tr width="100%">
                <td>
                    <asp:Label ID="lblRecebeParametro" runat="server" Text="Tela que recebe parâmetros..." />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNome" runat="server" Text="." />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIdade" runat="server" Text=".." />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Home.aspx">Voltar</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
