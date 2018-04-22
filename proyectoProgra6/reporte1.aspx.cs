using Microsoft.Reporting.WebForms;
using proyectoProgra6BLL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6.Reportes
{
    public partial class reporte1 : System.Web.UI.Page
    {
        TipoProductoBLL tipoProductoBLL = new TipoProductoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //List<TipoProducto> tipos= 
                //tipos.Insert(0, new TipoProducto() { IdTipoProducto = tipos.Count + 1, Descripcion = "Todos" });
                ddlTipoProducto.DataSource = tipoProductoBLL.ListaTipoProducto();
                ddlTipoProducto.DataTextField = "Descripcion";
                ddlTipoProducto.DataValueField = "IdTipoProducto";
                ddlTipoProducto.DataBind();
                cargarParametro();
            }

        }

        protected void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarParametro();
        }

        private void cargarParametro()
        {
            ReportParameter rp = new ReportParameter("TipoProducto", ddlTipoProducto.SelectedItem.Text);
            rptProducto.LocalReport.SetParameters(rp);
            rptProducto.LocalReport.Refresh();
        }
    }
}