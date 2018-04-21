using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUsuario"] == null)
                Response.Write("<script languaje=javascript>window.alert('Por favor ingrese un usuario');window.location.href='login.aspx'</script>");
        }
    }
}