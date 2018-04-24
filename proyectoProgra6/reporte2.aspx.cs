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
        string msjError = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DateTime fechaHoy = DateTime.Now;
            cleCalendarioFechaFinal.SelectedDate = fechaHoy;
            cleCalendarioFechaInicial.SelectedDate = fechaHoy.AddDays(-31);
        }
        private void cargarParametros()
        {
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("FechaInicial", txtFechaInicial.Text);
            parameters[1] = new ReportParameter("FechaFinal", txtFechaFinal.Text);
            this.ReportViewer1.LocalReport.SetParameters(parameters);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cleCalendarioFechaFinal.SelectedDate > DateTime.Now)
            {
                cleCalendarioFechaFinal.SelectedDate = DateTime.Now;
            }
            if (cleCalendarioFechaInicial.SelectedDate > DateTime.Now)
            {
                cleCalendarioFechaFinal.SelectedDate = DateTime.Now;
            }

            cargarParametros();
            
            }
    }
}