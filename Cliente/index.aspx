<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Cliente.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Calculo Modulo"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbDividendo" runat="server" Text="Dividendo"></asp:Label>
            <asp:TextBox ID="inputDividendo" runat="server"></asp:TextBox><br>
        </div>
        <asp:Label ID="lblDivisor" runat="server" Text="Divisor"></asp:Label>
        <asp:TextBox ID="inputDivisor" runat="server"></asp:TextBox><br>
        <p>
            <asp:Button ID="btnCalcular" runat="server" Height="23px" Text="Calcular" OnClick="btnCalcular_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbResultado" runat="server" Text="El resultado es:"></asp:Label>
&nbsp;<asp:Label ID="lbTotal" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
