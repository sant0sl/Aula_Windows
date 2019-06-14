<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculadora.aspx.cs" Inherits="Forms_Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formCalc" runat="server">
        <table border="1" width="100%">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLinkVoltar" runat="server" NavigateUrl="~/Forms/Home.aspx">Voltar</asp:HyperLink>
                    </td>
                </tr>
                <tr height="50px" align="center">
                    <td>
                        <asp:Label ID="lblValor1" runat="server" Text="Valor I:"></asp:Label>
                        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
                        &nbsp;
                        &nbsp;
                        <asp:Label ID="lblValor2" runat="server" Text="Valor II:"></asp:Label>
                        <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="btnSomar" runat="server" Text="+" OnClick="btnSomar_Click" />
                        &nbsp;
                        <asp:Button ID="btnDiminuir" runat="server" Text="-" OnClick="btnDiminuir_Click" />
                        &nbsp;
                        <asp:Button ID="btnMultiplicar" runat="server" Text="*" OnClick="btnMultiplicar_Click" />
                        &nbsp;
                        <asp:Button ID="btnDividir" runat="server" Text="/" OnClick="btnDividir_Click" />
                        &nbsp;
                        <asp:Button ID="btnLimpar" runat="server" Text="C" OnClick="btnLimpar_Click" />
                        &nbsp;&nbsp;
                        <asp:Label ID="lblResultado" runat="server" Text="Resultado:"></asp:Label>
                        <asp:TextBox ID="txtResultado" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
