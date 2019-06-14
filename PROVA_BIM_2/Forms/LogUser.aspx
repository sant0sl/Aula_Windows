<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogUser.aspx.cs" Inherits="Forms_LogUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formLog" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DataGrid ID="dgLog" runat="server"></asp:DataGrid>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
