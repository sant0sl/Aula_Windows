<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Componentes.aspx.cs" Inherits="Forms_Componentes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formComponentes" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Home.aspx">Voltar</asp:HyperLink>
                    </td>
                </tr>
                <tr align="center">
                    <td>
                        <div>
                            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
                            <asp:DropDownList ID="DropDownListNome" runat="server" />
                            <asp:Button ID="btnSelecionar" runat="server" Text="Selecionar" OnClick="btnSelecionar_Click" />
                        </div>
                        &nbsp;
                        <div>
                            <asp:TextBox ID="txtIDProf" Enabled="false" runat="server"></asp:TextBox>
                            &nbsp;
                            <asp:TextBox ID="txtNomeProf" Enabled="false" runat="server"></asp:TextBox>
                        </div>
                    </td>
                    <td>
                        <asp:Label ID="lblProgramacao" runat="server" Text="Programação:"></asp:Label>
                        <asp:DropDownList ID="DropDownListProgramacao" runat="server">
                            <asp:ListItem Value="1">Sim</asp:ListItem>
                            <asp:ListItem Value="2">Não</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:CheckBox ID="chckAlert" runat="server" Text="Alert" />
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="btnAlert" runat="server" Text="Processar" OnClick="btnAlert_Click" />
                    </td>
                    <td>
                        <div>
                            <asp:RadioButtonList ID="rdbtnList" runat="server">
                                <asp:ListItem Value="1">Gosto</asp:ListItem>
                                <asp:ListItem Value="2">Amo</asp:ListItem>
                                <asp:ListItem Value="3">Amo X 2</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>    
                        <div>
                            <asp:Button ID="btnProcessar" runat="server" Text="Processar" OnClick="btnProcessar_Click" />
                        </div>
                    </td>
                    <td>
                        <div>
                            <asp:Button ID="btnLimparCampos" runat="server" Text="Limpar Campos" OnClick="btnLimparCampos_Click" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
