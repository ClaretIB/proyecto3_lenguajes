using Proyecto3_LenguajesData.Business;
using Proyecto3_LenguajesData.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto3_Lenguajes
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos cliente = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            DataSet tipoCambio = cliente.ObtenerIndicadoresEconomicos("317","20/02/2017", "20/02/2017", "Claret Ivankovich", "N");
            Label1.Text = "Codigo Indicador "+tipoCambio.Tables[0].Rows[0].ItemArray[0].ToString()+"-----"+
                          "Fecha consulta " + tipoCambio.Tables[0].Rows[0].ItemArray[1].ToString() + "------" +
                          "Valor tipo cambio " + tipoCambio.Tables[0].Rows[0].ItemArray[2].ToString();

           ServiceReference1.WSpgosClient pagos = new ServiceReference1.WSpgosClient();
           Label1.Text= pagos.pagoMatricula("7676", "888").nombre;
            
        }

        protected void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            String user = tb_user.Text;
            String pass = tb_contrasena.Text;
            ServiceReference1.WSpgosClient pagos = new ServiceReference1.WSpgosClient();
            if (pagos.pagoMatricula(user, pass).mensaje == "1")
            {
                Label1.Text = "entre";
                Session.Add("monto", pagos.pagoMatricula(user, pass).monto);
                Response.Redirect("padreMenu.aspx", false);
            }
            else
            {
                Response.Redirect("login.aspx", false);
                lb_resultado.Text = "Usuario o contrasena incorrectos";
            }
        }
    }
}