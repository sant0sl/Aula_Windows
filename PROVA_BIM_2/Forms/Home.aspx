<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Forms_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formHome" runat="server">
        <div>
            <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:TextBox ID="txtContatos" runat="server"></asp:TextBox>
                        <asp:Button ID="btnValidar" runat="server" Text="Validar Email" OnClick="btnValidar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnVerLog" runat="server" Text="Log Usuario" OnClick="btnVerLog_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
