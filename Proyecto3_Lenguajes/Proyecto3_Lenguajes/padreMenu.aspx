<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="padreMenu.aspx.cs" Inherits="Proyecto3_Lenguajes.padreMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#0099CC" Text="Bienvenido padre de familia"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Que accion desea realizar:"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_pago" runat="server" OnClick="btn_pago_Click" Text="Pago Matricula" />
        <asp:Button ID="btn_notas" runat="server" OnClick="btn_notas_Click" Text="Consultar notas" />
    </form>
</body>
</html>
