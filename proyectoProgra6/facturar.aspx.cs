using proyectoProgra6BLL;
using proyectoProgra6Entidades;
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
                    for (int i = anno; i < anno + 10; i++)
                    {
                        ddlAnno.Items.Add(i.ToString());
                    }
                    txtDetalle.Text = detalleFacturaBLL.Detalles(Int32.Parse(Request.QueryString["idMesa"]), Session["usuario"].ToString());
                    ddlTipoPago_SelectedIndexChanged(null, null);
                }
            }
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {

            int idMesa = Int32.Parse(Request.QueryString["idMesa"]);
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = "";
            Factura fact = new Factura()
            {
                Fecha = DateTime.Now,
                IdMesa = idMesa,
                IdTipoPago = Int32.Parse(ddlTipoPago.SelectedValue),
                PagoTarjeta = decimal.Parse(txtPagoTarjeta.Text),
                PagoEfectivo = decimal.Parse(txtPagoEfectivo.Text),
                IdUsuario = Int32.Parse(Session["idUsuario"].ToString())
            };
            if (fact.IdTipoPago != 3 && IsValid)
            {
                TarjetaBLL tarjBLL = new TarjetaBLL();
                Tarjeta tarj = new Tarjeta()
                {
                    IdTarjeta = txtNumeroTar.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                    AnnoCaduca = Int32.Parse(ddlAnno.SelectedValue),
                    MesCaduca = Int32.Parse(ddlMes.SelectedValue)
                };
                if (tarjBLL.ValidarTarjeta(tarj))
                {
                    if (!tarjBLL.Existe(tarj.IdTarjeta))
                    {
                        tarjBLL.InsertarTarjeta(tarj);
                    }
                    fact.IdTarjeta = tarj.IdTarjeta;
                }
                else
                {
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Verifique los datos de la tarjeta";
                }
            }
            if (textoMensajeError.InnerHtml == "")
            {
                facturaBLL.GuardarFactura(fact);
                MesaBLL mesaBLL = new MesaBLL();
                mesaBLL.ActualizarMesa(0,idMesa, 1);
                ComandaBLL comandaBLL = new ComandaBLL();
                comandaBLL.CerrarComandas(idMesa);
                Response.Redirect("menuPrincipal.aspx");
            }   
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("menuPrincipal.aspx");
            Response.Redirect("facturar.aspx?idMesa=" + Request.QueryString["idMesa"]);
        }

        protected void ddlTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = "";
            decimal total = facturaBLL.TotalFactura(Int32.Parse(Request.QueryString["idMesa"]));
            int valor = Int32.Parse(ddlTipoPago.SelectedItem.Value);
            if (valor == 1)
            {
                tarjeta.Visible = true;
                efectivo.Visible = true;
                txtNumeroTar.Text = "";
                txtCodigo.Text = "";
                txtPagoTarjeta.Text = (total / 2).ToString();
                txtPagoEfectivo.Text = (total / 2).ToString();
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
                txtPagoTarjeta.Text = total.ToString();
                txtPagoEfectivo.Text = "0";
                txtPagoTarjeta.Enabled = false;
                ddlMes.SelectedIndex = 0;
                ddlAnno.SelectedIndex = 0;
            }

            if (valor == 3)
            {
                tarjeta.Visible = false;
                efectivo.Visible = true;
                txtPagoEfectivo.Text = total.ToString();
                txtPagoTarjeta.Text = "0";
                txtPagoEfectivo.Enabled = false;
                
            }
        }

        protected void txtPagoTarjeta_TextChanged(object sender, EventArgs e)
        {
            decimal total = facturaBLL.TotalFactura(Int32.Parse(Request.QueryString["idMesa"]));
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = "";
            try
            {
                decimal totalTarjeta = decimal.Parse(txtPagoTarjeta.Text);
                if (totalTarjeta <= total)
                    txtPagoEfectivo.Text = (total - totalTarjeta).ToString();
                else
                {
                    txtPagoTarjeta.Text = (total - decimal.Parse(txtPagoEfectivo.Text)).ToString();
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Digite un valor menor al total";
                }
            }
            catch
            {
                txtPagoTarjeta.Text = (total - decimal.Parse(txtPagoEfectivo.Text)).ToString();
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Digite un valor numerico";
            }
        }

        protected void txtPagoEfectivo_TextChanged(object sender, EventArgs e)
        {
            decimal total = facturaBLL.TotalFactura(Int32.Parse(Request.QueryString["idMesa"]));
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = "";
            try
            {
                decimal totalEfectivo = decimal.Parse(txtPagoEfectivo.Text);
                if (totalEfectivo >= total)
                    txtPagoTarjeta.Text = (total - totalEfectivo).ToString();
                else
                {
                    txtPagoEfectivo.Text = (total - decimal.Parse(txtPagoTarjeta.Text)).ToString();
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Digite un valor menor al total";
                }
            }
            catch
            {
                txtPagoEfectivo.Text = (total - decimal.Parse(txtPagoTarjeta.Text)).ToString();
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Digite un valor numerico";
            }
        }
    }
}
