<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="Proyecto3_Lenguajes.matricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
    <style type="text/css">
        #Text1 {
            width: 183px;
        }
        #Text2 {
            width: 184px;
        }
        #Text3 {
            width: 186px;
        }
        #Text4 {
            width: 186px;
        }
        #Text5 {
            width: 186px;
        }
        #Text6 {
            width: 186px;
        }
        #form1 {
            width: 927px;
            height: 451px;
        }
        #i_cedula {
            width: 180px;
        }
        #i_nombre {
            width: 185px;
        }
        #i_apellidos {
            width: 185px;
        }
        #i_direccion {
            width: 182px;
        }
        #i_correo {
            width: 182px;
        }
        #i_telefono {
            width: 181px;
        }
    </style>
</head>
<body>
<div>
    <br/>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Registro de estudiantes"></asp:Label>
    <form id="form1" runat="server"> 
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Datos del encargado"></asp:Label>
        <br/>
        <br/>
        <asp:Label ID="Label8" runat="server" Text="Cedula:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_cedula" runat="server" Width="161px"></asp:TextBox>
        <br />

        <asp:Button ID="Button2" runat="server" Text="Consultar" OnClick="Button2_Click" />
        <br />
         <asp:Label ID="Label10" runat="server" Text="l"></asp:Label>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Nombre:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_nombre" runat="server" Width="159px"></asp:TextBox>
        <br/>
        <asp:Label ID="Label5" runat="server" Text="Apellidos:"></asp:Label>
         &nbsp;&nbsp;
         <asp:TextBox ID="tb_apellidos" runat="server" Width="160px"></asp:TextBox>
         <br/>
         <asp:Label ID="Label6" runat="server" Text="Direccion:"></asp:Label>
         &nbsp;&nbsp;
         <asp:TextBox ID="tb_direccion" runat="server" style="margin-left: 0px" Width="153px"></asp:TextBox>
         <br/>
        <asp:Label ID="Label7" runat="server" Text="Correo:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_correo" runat="server" Width="165px"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_telefono" runat="server" Width="163px"></asp:TextBox>
        <br/>
        <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
        <br/>
        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
        <br/><br/>
    <div>
        
        <asp:Label ID="Label9" runat="server" Text="Datos del Estudiante"></asp:Label>
         <br/><br/>
         <asp:Label ID="Label11" runat="server" Text="Cedula:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_cedula_estu" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Nombre:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_nombre_estu" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="Apellidos:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="tb_apellidos_estu" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label14" runat="server" Text="Grado:" ></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_grado_estu" runat="server" CssClass="form-control"></asp:TextBox>
        
        <br />
        <asp:Button ID="btn_insert_estudiante" runat="server" OnClick="btn_insert_estudiante_Click" Text="Agregar" />
        <br/>
        <asp:Label ID="Label15" runat="server" Text=".."></asp:Label>
    </div>
    </form>
 </div>   
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="js/script.js"></script>
    </body>
</html>
