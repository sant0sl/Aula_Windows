<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sessao_AdicionarProfessor.aspx.cs" Inherits="Forms_Sessao_AdicionarProfessor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formAddProf" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                &nbsp;
                <tr>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"  />
                        &nbsp;
                        <asp:Button ID="btnAdd" runat="server" Text="Salvar" OnClick="btnAdd_Click"  />
                    </td>
                </tr>
                &nbsp;
                <tr>
                    <td>
                        <asp:DataGrid ID="dgProfessores" runat="server"></asp:DataGrid>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
