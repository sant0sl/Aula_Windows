<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page_Teclado.aspx.cs" Inherits="Forms_page_Teclado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formTeclados" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:Label ID="lblLoja" runat="server" Text="TECLADOS"></asp:Label>
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:DataGrid width="100%" ID="dgProdutos" runat="server" AutoGenerateColumns="False" OnItemCommand="dgProdutos_ItemCommand">
                            <Columns>
                                <asp:BoundColumn DataField="id" FooterText="ID" HeaderText="ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="descricao" FooterText="Descricao" HeaderText="Descricao"></asp:BoundColumn>
                                <asp:BoundColumn DataField="valorUnitario" FooterText="Valor Unitario" HeaderText="Valor Unitario"></asp:BoundColumn>
                                <asp:ButtonColumn CommandName="Add" Text="Adicionar no Carrinho"></asp:ButtonColumn>
                            </Columns>
                        </asp:DataGrid>
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="50%" align="center">
                        <asp:HyperLink ID="HyperLinkHome" runat="server" NavigateUrl="~/Forms/Index.aspx">Voltar</asp:HyperLink>
                    </td>
                    <td width="50%" align="center">
                        <asp:HyperLink ID="HyperLinkCarrinho" runat="server" NavigateUrl="~/Forms/Carrinho.aspx">Finalizar Compra</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
