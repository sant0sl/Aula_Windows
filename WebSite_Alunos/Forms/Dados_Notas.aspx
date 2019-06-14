<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dados_Notas.aspx.cs" Inherits="Forms_Dados_Notas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formNotas" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtID" runat="server" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIDAluno" runat="server" Text="ID do Aluno: "></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="ddlAlunos" runat="server" Enabled="false"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIDMateria" runat="server" Text="ID da Materia: "></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="ddlMaterias" runat="server">
                            <asp:ListItem Value="0">Selecione uma Materia...</asp:ListItem>
                            <asp:ListItem Value="1">Lingua Portuguesa</asp:ListItem>
                            <asp:ListItem Value="2">Matematica</asp:ListItem>
                            <asp:ListItem Value="3">Ciencias</asp:ListItem>
                            <asp:ListItem Value="4">Historia</asp:ListItem>
                            <asp:ListItem Value="5">Geografia</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNota" runat="server" Text="Nota: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                    </td>
                </tr>
                &nbsp;
                <tr>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Voltar" OnClick="btnCancelar_Click" />
                        &nbsp;
                        <asp:Button ID="btnLimparSessao" runat="server" Text="Limpar Sessao" OnClick="btnLimparSessao_Click" />
                        &nbsp;
                        <asp:Button ID="btnAdd" runat="server" Text="Adicionar na Sessao" OnClick="btnAdd_Click" />
                        &nbsp;
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    </td>
                </tr>
            </table>
        </div>
        &nbsp;
        <div>
            <div>
                <asp:Label ID="lblNotasSessao" runat="server" Text="Notas gravadas em sessao: "></asp:Label>
            </div>
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <div>
                            <asp:DataGrid ID="dgNotasNaoSalvo" runat="server" AutoGenerateColumns="False" OnItemCommand="dgNotasNaoSalvo_ItemCommand">
                                <Columns>
                                    <asp:BoundColumn DataField="id" FooterText="ID da Nota" HeaderText="ID da Nota"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="idAluno" FooterText="ID do Aluno" HeaderText="ID do Aluno"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="idMateria" FooterText="ID da Materia" HeaderText="ID da Materia"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="quando" FooterText="Ultima Atualizacao" HeaderText="Ultima Atualizacao"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="nota" FooterText="Nota" HeaderText="Nota"></asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Apagar" Text="Apagar"></asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        &nbsp;
        <div>
            <div>
                <asp:Label ID="lblNotasBanco" runat="server" Text="Notas gravadas em banco de dados: "></asp:Label>
            </div>
            <table border="1" width="100%">
                <tr>
                    <td width="100%" align="center">
                        <div>
                            <asp:DataGrid ID="dgNotasBD" runat="server" AutoGenerateColumns="False" OnItemCommand="dgNotasBD_ItemCommand">
                                <Columns>
                                    <asp:BoundColumn DataField="id" FooterText="ID da Nota" HeaderText="ID da Nota"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="idAluno" FooterText="ID do Aluno" HeaderText="ID do Aluno"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="idMateria" FooterText="ID da Materia" HeaderText="ID da Materia"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="quando" FooterText="Ultima Atualizacao" HeaderText="Ultima Atualizacao"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="nota" FooterText="Nota" HeaderText="Nota"></asp:BoundColumn>
                                    <asp:ButtonColumn CommandName="Apagar" Text="Apagar"></asp:ButtonColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
