<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Forms_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formIndex" runat="server">
        <table border="1" height="100%" width="100%">
            <tr>
                <td width="60%" align="center">
                    <div>
                        <asp:DataGrid ID="dgImoveis" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnItemCommand="dgImoveis_ItemCommand" AutoGenerateColumns="False">
                            <AlternatingItemStyle BackColor="White" />
                            <Columns>
                                <asp:BoundColumn DataField="id" FooterText="ID" HeaderText="ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="cpf" FooterText="CPF" HeaderText="CPF"></asp:BoundColumn>
                                <asp:BoundColumn DataField="cidade" FooterText="Cidade" HeaderText="Cidade"></asp:BoundColumn>
                                <asp:BoundColumn DataField="bairro" FooterText="Bairro" HeaderText="Bairro"></asp:BoundColumn>
                                <asp:BoundColumn DataField="situacao" FooterText="Situacao" HeaderText="Situacao"></asp:BoundColumn>
                                <asp:BoundColumn DataField="tipo_locacao" FooterText="Tipo" HeaderText="Tipo"></asp:BoundColumn>
                                <asp:BoundColumn DataField="valor" FooterText="Valor" HeaderText="Valor"></asp:BoundColumn>
                                <asp:ButtonColumn CommandName="Alterar" Text="Alterar"></asp:ButtonColumn>
                                <asp:ButtonColumn CommandName="Deletar" Text="Deletar"></asp:ButtonColumn>
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#F7F7DE" />
                            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" Mode="NumericPages" />
                            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        </asp:DataGrid>
                    </div>
                </td>
                <td width="20%" align="center">
                    <div>
                        <asp:Label ID="lblBuscarPor" runat="server" Text="Buscar Por:"></asp:Label>
                    </div>
                    &nbsp;
                    <div>
                        <asp:Button ID="btnTodosOsDados" runat="server" Text="Todos os Dados" OnClick="btnTodosOsDados_Click" />
                    </div>
                    &nbsp;
                    <div>
                        <asp:Label ID="lblDisponibilidade" runat="server" Text="Disponibilidade: "></asp:Label>
                        <asp:CheckBox ID="checkBoxDisp" runat="server" />
                        <asp:Button ID="btnBuscarDisp" runat="server" Text="Buscar" OnClick="btnBuscarDisp_Click" />
                    </div>
                    &nbsp;
                    <div>
                        <asp:Label ID="lblFiltro" runat="server" Text="Cidade ou Bairro: "></asp:Label>
                        <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscarFiltro" runat="server" Text="Buscar" OnClick="btnBuscarFiltro_Click" />
                    </div>
                    &nbsp;
                    <div>
                        <asp:Label ID="lblVendaLocacao" runat="server" Text="Venda ou Locacao: "></asp:Label>
                        <asp:RadioButtonList ID="rdbtnListVendaLocacao" runat="server">
                            <asp:ListItem Value="1">Venda</asp:ListItem>
                            <asp:ListItem Value="0">Locacao</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Button ID="btnBuscarTipo" runat="server" Text="Buscar" OnClick="btnBuscarTipo_Click" />
                    </div>
                </td>
                <td width="20%" align="center">
                    <asp:HyperLink ID="HyperLinkNovoImovel" runat="server" NavigateUrl="~/Forms/Dados_Imovel.aspx">Novo Imóvel</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
