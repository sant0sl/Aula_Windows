<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dados_Imovel.aspx.cs" Inherits="Forms_Dados_Imovel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formDadosImovel" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblID" runat="server" Text="ID: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtID" runat="server" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCPF" runat="server" Text="CPF: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCidade" runat="server" Text="Cidade: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblValor" runat="server" Text="Valor: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSituacao" runat="server" Text="Situacao: "></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="DropDownListSituacao" runat="server">
                            <asp:ListItem Value="1">Disponível</asp:ListItem>
                            <asp:ListItem Value="0">Indisponível</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblVendaLocacao" runat="server" Text="Tipo de Aluguel: "></asp:Label>
                        &nbsp;
                        <asp:RadioButtonList ID="rdbtnListVendaLocacao" runat="server">
                            <asp:ListItem Value="1">Venda</asp:ListItem>
                            <asp:ListItem Value="0">Locacao</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                &nbsp;
                <tr>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                        &nbsp;
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
