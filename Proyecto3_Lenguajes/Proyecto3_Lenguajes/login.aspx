<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Proyecto3_Lenguajes.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button CssClass="" ID="btn_login" runat="server" Text="Entrar" OnClick="btn_login_Click" />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066CC" Text="Inicio de Sesion"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
        <br />
        <asp:TextBox ID="tb_user" runat="server" Width="158px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Contrasena"></asp:Label>
        <br />
        <asp:TextBox ID="tb_contrasena" runat="server" Width="155px"></asp:TextBox>
        <br />
        <asp:Button ID="btn_iniciarsesion" runat="server" OnClick="btn_iniciarsesion_Click" Text="Iniciar" />
        <br />
        <asp:Label ID="lb_resultado" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
