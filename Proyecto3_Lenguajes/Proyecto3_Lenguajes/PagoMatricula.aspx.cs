using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto3_Lenguajes
{
    public partial class PagoMatricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_monto.Text =Session["monto"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = "Pago realizado exitosamente";
        }
    }
}