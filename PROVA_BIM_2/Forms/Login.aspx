<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Forms_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formLogin" runat="server">
        <div>
            <table border="1" width="100%" height="100%">
                <tr align="center">
                    <td align="center">
                        &nbsp;
                        <div>
                            <asp:Label ID="lblLogin" runat="server" Text="Login: "></asp:Label>
                            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                        </div>
                        &nbsp;
                        <div>
                            <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                        </div>
                        &nbsp;
                        <div>
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </div>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
