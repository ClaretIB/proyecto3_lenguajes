<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagoMatricula.aspx.cs" Inherits="Proyecto3_Lenguajes.PagoMatricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="labyd" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0099CC" Text="Pago de matricula"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Monto a pagar:"></asp:Label>
&nbsp;
        <asp:Label ID="lb_monto" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ingrese el numero de tarjeta"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="161px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pagar" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
