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
    public partial class EliminarEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            }
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            estudianteBusiness.EliminarEstudiante(Int32.Parse(Lb_id.Text));
            Label3.Text = "Estudiante eliminado con exito";
        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            Estudiante estudiante =estudianteBusiness.GetEstudiante(TextBox1.Text);
            Lb_id.Text= estudiante.Id.ToString();
            Lb_nombre.Text = estudiante.Nombre +" "+estudiante.Apellidos;
            lb_cedula.Text = estudiante.Cedula;
            Tb_grado.Text = estudiante.Grado;
            lb_cedula_encar.Text = estudiante.Encargado;
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            Encargado encar = encargadoBusiness.obtenerEncargado(lb_cedula_encar.Text);
            lb_id_encargado.Text = encar.Id.ToString();
            lb_nombre_encar.Text = encar.Nombre;
            lb_apellidos_encarga.Text = encar.Apellidos;
            tb_direccion_enca.Text = encar.Direccion;
            tb_tel_encarga.Text = encar.Telefono;
            tb_correo_encargado.Text = encar.Correo;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            Estudiante est = new Estudiante();
            est.Id = Int32.Parse(Lb_id.Text);
            est.Grado = Tb_grado.Text;
            estudianteBusiness.ActualizarEstudiante(est);
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            Encargado enca = new Encargado();
            enca.Id = Int32.Parse(lb_id_encargado.Text);
            enca.Direccion = tb_direccion_enca.Text;
            enca.Telefono = tb_tel_encarga.Text;
            enca.Correo = tb_correo_encargado.Text;
            encargadoBusiness.ActualizarEncargado(enca);
            Label20.Text = "Actualizacion exitosa";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btn_agrega_elimina_encar_Click(object sender, EventArgs e)
        {
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            if (Int32.Parse(encargadoBusiness.getEncargado(tb_ceEncar.Text).ToString()) == -1)
            {
                Encargado encargado = new Encargado();
                encargado.Cedula = tb_ceEncar.Text;
                encargado.Nombre = tb_nombreEncar.Text;
                encargado.Apellidos = tb_apeEncar.Text;
                encargado.Correo = tb_coreEnca.Text;
                encargado.Direccion = tb_dirEnca.Text;
                encargado.Telefono = tb_telEnca.Text;

                encargadoBusiness.insertarEncargado(encargado);
                
                EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
                estudianteBusiness.cambiarEncargado(Int32.Parse(Lb_id.Text), tb_ceEncar.Text);

                Encargado encarga = encargadoBusiness.obtenerEncargado(tb_ceEncar.Text);
                String mensaje = "Su hijo(a) " + Lb_nombre.Text + " ha sido matricula." + "\n" +
                    "Datos para pagar la matricula via pagina web: \n" + "Usuario: " + tb_ceEncar.Text + "\n" +
                    "Contrasena: " + "http://localhost:49503/password.aspx?valor=" + encarga.Id;
                CCorreo correo = new CCorreo(tb_coreEnca.Text, "Confirmacion matricula", mensaje);

                Label33.Text = "Encargado cambiado con exito";
            }else
            {
                Label33.Text = "El encargado ya existia, sus datos ha sido tomados";
            }
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
            LinkedList<Estudiante> le = estudianteBusiness.GetAllEstudiantes();
            int estado =0;
            foreach (var item in le)
            {
                if (item.Encargado.ToString() ==lb_cedula_encar.Text)
                {
                    estado = 1;
                }
            }
            if (estado == 0)
            {
                EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
                encargadoBusiness.EliminarEncargado(Int32.Parse(lb_id_encargado.Text));
                Label32.Text = "Encargado eliminado con exito";
            }else
            {
                Label32.Text = "Encargado tiene asociado otro(s) estudiantes, no puede eliminarse";
            }
            
        }
    }
}