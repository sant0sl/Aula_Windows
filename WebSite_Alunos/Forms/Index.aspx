<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Forms_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formIndexAlunos" runat="server">
        <table border="1" height="100%" width="100%">
            <tr>
                <td width="60%" align="center">
                    <div>
                        <asp:DataGrid ID="dgAlunos" runat="server" AutoGenerateColumns="False" OnItemCommand="dgAlunos_ItemCommand">
                            <Columns>
                                <asp:BoundColumn DataField="id" FooterText="ID" HeaderText="ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="nome" FooterText="Nome" HeaderText="Nome"></asp:BoundColumn>
                                <asp:BoundColumn DataField="turma" FooterText="Turma" HeaderText="Turma"></asp:BoundColumn>
                                <asp:ButtonColumn CommandName="Notas" Text="Ver Notas"></asp:ButtonColumn>
                                <asp:ButtonColumn CommandName="Alterar" Text="Alterar"></asp:ButtonColumn>
                                <asp:ButtonColumn CommandName="Apagar" Text="Apagar"></asp:ButtonColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                </td>
                <td width="40%" align="center">
                    <asp:HyperLink ID="HyperLinkNovoAluno" runat="server" NavigateUrl="~/Forms/Dados_Alunos.aspx">Novo Aluno</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
