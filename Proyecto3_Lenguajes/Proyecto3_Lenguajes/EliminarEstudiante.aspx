<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarEstudiante.aspx.cs" Inherits="Proyecto3_Lenguajes.EliminarEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="css/estilos.css"/>
    <style type="text/css">
        #form1 {
            height: 1126px;
            width: 443px;
        }
    </style>
</head>
<body>
    <div>
    <form id="form1" runat="server">
    
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#0066CC" Text="Ediar Estudiante"></asp:Label>
        <br />
        <br/>

        <asp:Label ID="Label5" runat="server" Text="Cedula del estudiante:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <br />
        <asp:Button ID="btn_consultar" runat="server" OnClick="btn_consultar_Click" Text="Consultar" CssClass="btn btn-primary"/>
        <hr />
        <asp:Label ID="Label4" runat="server" Text="Actualizar" Font-Bold="True" ForeColor="#0099CC"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" ForeColor="#0099CC" Text="Informacion del Estudiante"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="ID:"></asp:Label>
        <asp:Label ID="Lb_id" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Nombre:"></asp:Label>
        <asp:Label ID="Lb_nombre" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Cedula:"></asp:Label>
        <asp:Label ID="lb_cedula" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lb_grado" runat="server" Text="Grado:"></asp:Label>
        <asp:TextBox ID="Tb_grado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" ForeColor="#0099CC" Text="Informacion del Encargado"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label11" runat="server" Text="ID:"></asp:Label>
        <asp:Label ID="lb_id_encargado" runat="server" Text="Label"></asp:Label>
       
        <br />
        <asp:Label ID="Label12" runat="server" Text="Cedula:"></asp:Label>
        <asp:Label ID="lb_cedula_encar" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label14" runat="server" Text="Nombre:"></asp:Label>
        <asp:Label ID="lb_nombre_encar" runat="server" Text="Label"></asp:Label>
        
        <br />
        <asp:Label ID="Label15" runat="server" Text="Apellidos:"></asp:Label>
        <asp:Label ID="lb_apellidos_encarga" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label16" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="tb_direccion_enca" runat="server"  Height="22px"></asp:TextBox>
        <br />
        <asp:Label ID="Label17" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="tb_tel_encarga" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label19" runat="server" Text="Correo:"></asp:Label>
        <asp:TextBox ID="tb_correo_encargado" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_actualizar" runat="server" OnClick="btn_actualizar_Click" Text="Actualizar" CssClass="btn btn-primary"/>
        <asp:Label ID="Label20" runat="server" Text="Label" ForeColor="#009933"></asp:Label>
        <br />
        <br />
        <hr />
        <br />
        <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="#006699" Text="Eliminar "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" ForeColor="#0099CC" Text="Eliminar Estudiante"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Eliminar el estudiante buscado"></asp:Label>
        <br />
        <asp:Button ID="Eliminar" runat="server" OnClick="Eliminar_Click" Text="Eliminar" CssClass="btn btn-primary"/>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="#009933"></asp:Label>
      
        <br />
        <br />
        <asp:Label ID="Label23" runat="server" ForeColor="#0099CC" Text="Eliminar Encargado"></asp:Label>
        <br />
        <asp:Label ID="Label24" runat="server" Text="Para eliminar el Encargo actual debe asignar otro"></asp:Label>
        <br />
        <asp:Label ID="Label25" runat="server" Text="Cedula:"></asp:Label>
        <asp:TextBox ID="tb_ceEncar" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label26" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="tb_nombreEncar" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label27" runat="server" Text="Apellidos:"></asp:Label>
        <asp:TextBox ID="tb_apeEncar" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label28" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="tb_dirEnca" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label29" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="tb_telEnca" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label30" runat="server" Text="Correo:"></asp:Label>
        <asp:TextBox ID="tb_coreEnca" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_agrega_elimina_encar" runat="server" Text="Cambiar encargado" CssClass="btn btn-primary" OnClick="btn_agrega_elimina_encar_Click"/>
      
        <asp:Label ID="Label33" runat="server" ForeColor="#009933" Text="Label"></asp:Label>
      
        <br />
        <br />
        <asp:Label ID="Label31" runat="server" Text="Desea eliminar el encargado anterior"></asp:Label>
        <br />
        <asp:Button ID="btn_eliminar" runat="server" OnClick="btn_eliminar_Click" Text="Eliminar" />
      
        <br />
        <asp:Label ID="Label32" runat="server" ForeColor="#009933" Text="Label"></asp:Label>
      
    </form>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="js/JavaScript.js"></script>
    </body>
</html>
