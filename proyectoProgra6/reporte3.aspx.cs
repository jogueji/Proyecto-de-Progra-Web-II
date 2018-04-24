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
    public partial class reporte3 : System.Web.UI.Page
    {
        TipoPagoBLL tipoPagoBLL = new TipoPagoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                ddlTipoPago.DataSource = tipoPagoBLL.ListaTipoPago();
                ddlTipoPago.DataTextField = "Descripcion";
                ddlTipoPago.DataValueField = "IdTipoPago";
                ddlTipoPago.DataBind();
               cargarParametro();
            }
        }
        private void cargarParametro()
        {
            ReportParameter rp = new ReportParameter("TipoPago", ddlTipoPago.SelectedItem.Text);
            ReportViewer1.LocalReport.SetParameters(rp);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void ddlTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarParametro();
        }
    }
}