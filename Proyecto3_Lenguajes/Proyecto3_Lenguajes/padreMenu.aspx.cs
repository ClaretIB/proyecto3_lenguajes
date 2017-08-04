using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto3_Lenguajes
{
    public partial class padreMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_pago_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagoMatricula.aspx", false);
        }

        protected void btn_notas_Click(object sender, EventArgs e)
        {

        }
    }
}