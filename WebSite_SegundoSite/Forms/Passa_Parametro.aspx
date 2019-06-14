<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Passa_Parametro.aspx.cs" Inherits="Forms_Passa_Parametro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formPassa" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Nome: " />
            <asp:TextBox ID="txtNome" runat="server" />
        </div>
        &nbsp;
        <div>
            <asp:Label ID="lblIdade" runat="server" Text="Idade: " />
            <asp:TextBox ID="txtIdade" runat="server" />
        </div>
        &nbsp;
        <div>
            <asp:Button ID="btnPassaParametro" runat="server" Text="Passa Parâmetro" OnClick="btnPassaParametro_Click" />
        </div>
        &nbsp;
        <div>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </form>
</body>
</html>
