using Proyecto3_LenguajesData.Business;
using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto3_Lenguajes
{
    public partial class matricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//postback = ir atras
            {
                EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            }
        }
        Boolean exite = false;
        protected void Button2_Click(object sender, EventArgs e)
        {
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            
            if (Int32.Parse(encargadoBusiness.getEncargado(tb_cedula.Text).ToString()) == -1)
            {
                Label10.Text = "El padre de familia no existe por favor llene  el formulario que esta acontinuacion";
               
            }
            else
            {
                Label10.Text = "El encargado ya existe por favor pase a llenar el formulario del nino";
                exite = true;
            }
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);

            Encargado encargado = new Encargado();
            encargado.Cedula = tb_cedula.Text;
            encargado.Nombre = tb_nombre.Text;
            encargado.Apellidos = tb_apellidos.Text;
            encargado.Correo = tb_correo.Text;
            encargado.Direccion = tb_direccion.Text;
            encargado.Telefono = tb_telefono.Text;

            encargadoBusiness.insertarEncargado(encargado);
            Label16.Text = "Encargado Insertado con exito"; 
                      
        }

        protected void btn_insert_estudiante_Click(object sender, EventArgs e)
        {
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);

            Estudiante estudiante = new Estudiante();
            estudiante.Cedula = tb_cedula_estu.Text;
            estudiante.Nombre = tb_nombre_estu.Text;
            estudiante.Apellidos = tb_apellidos_estu.Text;
            estudiante.Encargado = tb_cedula.Text;
            estudiante.Grado = tb_grado_estu.Text;
            estudianteBusiness.InsertarEstudiante(estudiante);
            Label15.Text = "Estudiante insertado con exito";
            

            if (!exite)
            {
                EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
                Encargado encargado = encargadoBusiness.obtenerEncargado(tb_cedula.Text);
                String mensaje = "Su hijo(a) " + tb_nombre_estu.Text + " ha sido matricula." + "\n"+
                    "Datos para pagar la matricula via pagina web: \n"+"Usuario: "+ tb_cedula.Text+"\n"+
                    "Contrasena: "+ "http://localhost:49503/password.aspx?valor="+encargado.Id;
                CCorreo correo = new CCorreo(tb_correo.Text, "Confirmacion matricula", mensaje);
                if (correo.Estado)
                {
                    Label15.Text= "correo enviado";
                }else
                {
                    Label15.Text = "Error correo"+correo.Merror;
                }
            }

            tb_cedula.Text = ""; tb_nombre.Text = ""; tb_apellidos.Text = ""; tb_correo.Text = ""; tb_direccion.Text = "";
            tb_telefono.Text = ""; Label16.Text = ""; Label10.Text = "";
            tb_cedula_estu.Text = ""; tb_nombre_estu.Text = ""; tb_apellidos_estu.Text = "";
            tb_cedula.Text = ""; tb_grado_estu.Text = ""; 
        }
    }
}