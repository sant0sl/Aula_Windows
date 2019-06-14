<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Persistencia_Professor.aspx.cs" Inherits="Forms_Persistencia_Professor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formPersistencia" runat="server">
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
                        <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIdade" runat="server" Text="Idade: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
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
