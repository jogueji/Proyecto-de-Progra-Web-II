using proyectoProgra6BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6
{
    public partial class facturar : System.Web.UI.Page
    {
        private TipoPagoBLL tipoPagoBLL = new TipoPagoBLL();
        private DetalleFacturaBLL detalleFacturaBLL = new DetalleFacturaBLL();
        private FacturaBLL facturaBLL = new FacturaBLL();
        private TarjetaBLL tarjetaBLL = new TarjetaBLL();
        protected decimal total=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idMesa"] == null)
                Response.Write("<script languaje=javascript>window.alert('Seleccione la mesa a la que se le desea ver las comandas');window.location.href='menuPrincipal.aspx'</script>");
            else
            {
                if (!IsPostBack)
                {
                    ddlTipoPago.DataSource = tipoPagoBLL.ListaTipoPago();
                    ddlTipoPago.DataTextField = "Descripcion";
                    ddlTipoPago.DataValueField = "IdTipoPago";
                    ddlTipoPago.DataBind();
                    int anno = DateTime.Now.Year - 2000;
                    for (int i = anno; i < anno+10; i++)
                    {
                        ddlAnno.Items.Add(i.ToString());
                    }
                    txtDetalle.Text = detalleFacturaBLL.Detalles(Int32.Parse(Request.QueryString["idMesa"]),Session["usuario"].ToString());
                }
            }
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("facturar.aspx");
        }

        protected void ddlTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Int32.Parse(ddlTipoPago.SelectedItem.Value);
            if (valor == 1)
            {
                tarjeta.Visible = true;
                efectivo.Visible = true;
                txtNumeroTar.Text = "";
                txtCodigo.Text = "";
                txtPagoTarjeta.Text=(total/2).ToString("#,00");
                txtPagoEfectivo.Text=(total / 2).ToString("#,00");
                txtPagoTarjeta.Enabled = true;
                txtPagoEfectivo.Enabled = true;
                ddlMes.SelectedIndex = 0;
                ddlAnno.SelectedIndex = 0;
            }
            if (valor == 2)
            {
                tarjeta.Visible = true;
                efectivo.Visible = false;
                txtNumeroTar.Text = "";
                txtCodigo.Text = "";
                txtPagoTarjeta.Text= total.ToString("#,00");
                txtPagoTarjeta.Enabled = false;
                ddlMes.SelectedIndex = 0;
                ddlAnno.SelectedIndex = 0;
            }

            if (valor == 3)
            {
                tarjeta.Visible = false;
                efectivo.Visible = true;
                txtPagoEfectivo.Enabled = false;
                txtPagoEfectivo.Text= total.ToString("#,00");
            }
        }
    }
}