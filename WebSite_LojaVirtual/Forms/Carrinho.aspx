<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Carrinho.aspx.cs" Inherits="Forms_Carrinho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formCarrinho" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:Label ID="lblLoja" runat="server" Text="CARRINHO DE COMPRAS"></asp:Label>
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
                                <asp:BoundColumn DataField="qtd" FooterText="Qtd" HeaderText="Qtd"></asp:BoundColumn>
                                <asp:ButtonColumn CommandName="Alterar" Text="Alterar Qtd"></asp:ButtonColumn>
                            </Columns>
                        </asp:DataGrid>
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
                        <asp:TextBox ID="txtID" Enabled="false" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Label ID="lblDesc" runat="server" Text="Descricao: "></asp:Label>
                        <asp:TextBox ID="txtDesc" Enabled="false" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Label ID="lblValor" runat="server" Text="Valor Unitario: "></asp:Label>
                        <asp:TextBox ID="txtValor" Enabled="false" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Label ID="lblQtd" runat="server" Text="Qtd: "></asp:Label>
                        <asp:TextBox ID="txtQtd" runat="server"></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    </td>
                </tr>
            </table>
            &nbsp;
            <table border="1" width="100%">
                <tr>
                    <td width="33%" align="center">
                        <asp:HyperLink ID="HyperLinkHome" runat="server" NavigateUrl="~/Forms/Index.aspx">Home</asp:HyperLink>
                    </td>
                    <td width="33%" align="center">
                        <asp:Button ID="btnExcluirTudo" runat="server" Text="Excluir Produtos" OnClick="btnExcluirTudo_Click" />
                    </td>
                    <td width="33%" align="center">
                        <asp:Button ID="btnCookie" runat="server" Text="Salvar Carrinho" OnClick="btnCookie_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
