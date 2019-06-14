<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Listagem_Professores.aspx.cs" Inherits="Forms_Listagem_Professores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formListagem" runat="server">
        <table border="1" width="100%">
            <tr>
                <td width="60%" align="center">
                    <div>
                        <asp:DataGrid ID="dgProfessores" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemCommand="dgProfessores_ItemCommand" OnPageIndexChanged="dgProfessores_PageIndexChanged" AllowPaging="True" OnItemDataBound="dgProfessores_ItemDataBound" PageSize="3">
                            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundColumn DataField="Id_professor" FooterText="ID" HeaderText="ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Nome" FooterText="Nome" HeaderText="Nome"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Idade" FooterText="Idade" HeaderText="Idade"></asp:BoundColumn>
                                <asp:ButtonColumn CommandName="Update" Text="Update"></asp:ButtonColumn>
                                <asp:ButtonColumn CommandName="Delete" Text="Delete"></asp:ButtonColumn>
                            </Columns>
                            <EditItemStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
                            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataGrid>
                    </div>
                </td>
                <td width="20%" align="center">
                    <asp:HyperLink ID="HyperLinkNovoProf" runat="server" NavigateUrl="~/Forms/Persistencia_Professor.aspx">Novo Professor</asp:HyperLink>
                </td>
                <td width="20%" align="center">
                    <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Home.aspx">Voltar</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
