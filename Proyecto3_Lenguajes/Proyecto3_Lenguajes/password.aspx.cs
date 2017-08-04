using Proyecto3_LenguajesData.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto3_Lenguajes
{
    public partial class password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//postback = ir atras
            {
               Label3.Text= Request.QueryString["valor"];
            }
        }

        protected void btn_guar_contra_Click(object sender, EventArgs e)
        {
            if (tb_contrasena.Text == tb_rep_contrasena.Text)
            {
                EncargadoBusiness encargadoBusiness = new EncargadoBusiness(WebConfigurationManager.ConnectionStrings["ProyectoLenguajes"].ConnectionString);
                encargadoBusiness.ActualizarContrasena(tb_contrasena.Text, Int32.Parse(Request.QueryString["valor"]));
                Label3.Text = "Contrasena Gurdada";
            }
            else
            {
                Label3.Text = "Las contrasenas no son iguales por favor verifique";
            }
        }
    }
}