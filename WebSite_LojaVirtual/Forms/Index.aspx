<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Forms_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formIndex" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:Label ID="lblLoja" runat="server" Text="LOJA VIRTUAL"></asp:Label>
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="25%" align="center">
                        <asp:HyperLink ID="HyperLinkMonitor" runat="server" NavigateUrl="~/Forms/page_Monitor.aspx">Monitores</asp:HyperLink>
                    </td>
                    <td width="25%" align="center">
                        <asp:HyperLink ID="HyperLinkMouse" runat="server" NavigateUrl="~/Forms/page_Mouse.aspx">Mouses</asp:HyperLink>
                    </td>
                    <td width="25%" align="center">
                        <asp:HyperLink ID="HyperLinkTeclado" runat="server" NavigateUrl="~/Forms/page_Teclado.aspx">Teclados</asp:HyperLink>
                    </td>
                    <td width="25%" align="center">
                        <asp:HyperLink ID="HyperLinkFone" runat="server" NavigateUrl="~/Forms/page_Fone.aspx">Fones</asp:HyperLink>
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:HyperLink ID="HyperLinkCarrinho" runat="server" NavigateUrl="~/Forms/Carrinho.aspx">Carrinho de Compras</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
