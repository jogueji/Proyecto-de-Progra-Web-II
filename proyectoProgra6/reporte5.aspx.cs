using Microsoft.Reporting.WebForms;
using proyectoProgra6BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6.Reportes
{
    public partial class reporte5 : System.Web.UI.Page
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //List<Mesero> tipos= 
                //tipos.Insert(0, new Mesero() { IdMesero = tipos.Count + 1, Descripcion = "Todos" });
                ddlMesero.DataSource = usuarioBLL.ListaUsuarios();
                ddlMesero.DataTextField = "NombreUsuario";
                ddlMesero.DataValueField = "NombreUsuario";
                ddlMesero.DataBind();
                cargarParametro();
            }

        }

        private void cargarParametro()
        {
            ReportParameter rp = new ReportParameter("Mesero", ddlMesero.SelectedItem.Text);
            rptMesero.LocalReport.SetParameters(rp);
            rptMesero.LocalReport.Refresh();
        }

        protected void ddlMesero_SelectedIndexChanged1(object sender, EventArgs e)
        {
            cargarParametro();
        }
    }
}