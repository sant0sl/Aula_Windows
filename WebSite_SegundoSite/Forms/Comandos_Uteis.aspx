<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Comandos_Uteis.aspx.cs" Inherits="Forms_Comandos_Uteis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formCmdsUteis" runat="server">
        <div>
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            <asp:DataGrid ID="dgPessoas" runat="server"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
