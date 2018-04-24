using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6.Reportes
{
    public partial class reporte2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime fechaHoy = new DateTime ();
            //cleCalendarioFechaFinal.SelectedDate = fechaHoy


            //cleCalendarioFechaFinal.SelectedDate = 
          //ReportParameter[] rp = new ReportParameter[] { new ReportParameter("FechaInicial", "12/12/18"), new ReportParameter ("FechaFinal","13/12/18")};
          //ReportViewer1.LocalReport.SetParameters(rp);
          // ReportViewer1.LocalReport.Refresh();
        }
    }
}