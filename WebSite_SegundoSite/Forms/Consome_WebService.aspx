<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Consome_WebService.aspx.cs" Inherits="Forms_Consome_WebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formWS" runat="server">
        <table border="1" width="100%">
            <tr>
                <td>
                    <asp:Label ID="lblNumero1" runat="server" Text="Numero 1: " />
                    <asp:TextBox ID="txtN1" runat="server" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Label ID="lblNumero2" runat="server" Text="Numero 2: " />
                    <asp:TextBox ID="txtN2" runat="server" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                    &nbsp;
                    <asp:Button ID="btnLimparCampos" runat="server" Text="Limpar Campos" OnClick="btnLimparCampos_Click" />
                    &nbsp;
                    <asp:Button ID="btnSomar" runat="server" Text="Somar" OnClick="btnSomar_Click" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Label ID="lblResultado" runat="server" Text="Resultado: " />
                    <asp:TextBox ID="txtResultado" runat="server" Enabled="false"/>
                </td>
            </tr>
        </table>
        &nbsp;
        <table border="1" width="100%">
            <tr>
                <td>
                    <asp:Label ID="lblCadastrarProf" runat="server" Text="CADASTRAR PROFESSOR" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Label ID="lblID" runat="server" Text="ID: " />
                    <asp:TextBox ID="txtID" runat="server" Enabled="false" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Label ID="lblNome" runat="server" Text="Nome: " />
                    <asp:TextBox ID="txtNome" runat="server" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Label ID="lblIdade" runat="server" Text="Idade: " />
                    <asp:TextBox ID="txtIdade" runat="server" />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:Button ID="btnVoltar2" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                    &nbsp;
                    <asp:Button ID="btnLimparCampos2" runat="server" Text="Limpar Campos" OnClick="btnLimparCampos_Click" />
                    &nbsp;
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"  />
                </td>
            </tr>
            &nbsp;
            <tr>
                <td>
                    <asp:DataGrid ID="dgProfessores" runat="server" AutoGenerateColumns="False" OnItemCommand="dgProfessores_ItemCommand">
                        <Columns>
                            <asp:BoundColumn DataField="Id_Professor" FooterText="ID" HeaderText="ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Nome" FooterText="Nome" HeaderText="Nome"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Idade" FooterText="Idade" HeaderText="Idade"></asp:BoundColumn>
                            <asp:ButtonColumn CommandName="Alterar" Text="Alterar"></asp:ButtonColumn>
                            <asp:ButtonColumn CommandName="Deletar" Text="Deletar"></asp:ButtonColumn>
                        </Columns>
                    </asp:DataGrid>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
