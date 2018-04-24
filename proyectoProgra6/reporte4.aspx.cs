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
    public partial class reporte4 : System.Web.UI.Page
    {
        MesaBLL mesaBLL = new MesaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlIdMesa.DataSource = mesaBLL.ListaMesas();
                ddlIdMesa.DataTextField = "IdMesa";
                ddlIdMesa.DataValueField = "IdMesa";
                ddlIdMesa.DataBind();
                cargarParametro();
            }
        }
             private void cargarParametro()
        {
            ReportParameter rp = new ReportParameter("IdMesa", ddlIdMesa.SelectedItem.Value);
            ReportViewer1.LocalReport.SetParameters(rp);
            ReportViewer1.LocalReport.Refresh();
        }
    }
    }
