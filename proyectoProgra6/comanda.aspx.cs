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
    public partial class comanda : System.Web.UI.Page
    {
        private TipoProductoBLL tipoProductoBLL = new TipoProductoBLL();
        private ProductoBLL productoBLL = new ProductoBLL();
        private MesaBLL mesaBLL = new MesaBLL();
        private ComandaBLL comanadaBLL = new ComandaBLL();
        private DetalleComandaBLL detalleComandaBLL = new DetalleComandaBLL();

     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idMesa"] == null)
                Response.Write("<script languaje=javascript>window.alert('Seleccione la mesa a la que se le desea ver las comandas');window.location.href='menuPrincipal.aspx'</script>");
            else
            {
                if (!IsPostBack)
                {
                    Session["detallesComanda"] = new List<DetalleComanda>();
                    ddlTipoProducto.DataSource = tipoProductoBLL.ListaTipoProducto();
                    ddlTipoProducto.DataTextField = "Descripcion";
                    ddlTipoProducto.DataValueField = "IdTipoProducto";
                    ddlTipoProducto.DataBind();
                    refrescarProductos();
                }

            }
        }
        private void refrescarProductos()
        {
            ddlProducto.DataSource = productoBLL.ListaProductosXTipo(Int32.Parse(ddlTipoProducto.SelectedValue));
            ddlProducto.DataTextField = "Nombre";
            ddlProducto.DataValueField = "IdProducto";
            ddlProducto.DataBind();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = "Ingrese al menos un detalle comanda";
            if (lstDetalleComanda.Items.Count != 0)
            {
                Comanda comanda = new Comanda()
                {
                    IdMesa = Int32.Parse(Request.QueryString["idMesa"]),
                    IdEstadoComanda = 1,
                    Fecha = DateTime.Now,
                    IdUsuario = (int)Session["idUsuario"]
                };
                int idComanda = comanadaBLL.InsertarComanda(comanda);
                foreach (DetalleComanda item in ((List<DetalleComanda>)Session["detallesComanda"]))
                {
                    item.IdComanda = idComanda;
                    detalleComandaBLL.InsertarDetalleComanda(item);
                }
                mesaBLL.ActualizarMesa((int)Session["idUsuario"], comanda.IdMesa, 3);
                Response.Redirect("menuPrincipal.aspx");
            }
            else
            {
                mensajeError.Visible=true;
                textoMensajeError.InnerHtml = "Ingrese al menos un detalle comanda";

            }
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("menuPrincipal.aspx");
            Response.Redirect("comanda.aspx?idMesa="+ Request.QueryString["idMesa"]);
        }

        protected void ddlTipoProducto_SelectedIndexChanged1(object sender, EventArgs e)
        {
            refrescarProductos();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DetalleComanda detalleComanda = new DetalleComanda()
            {
                IdProducto = Int32.Parse(ddlProducto.SelectedValue),
                Cantidad = Int32.Parse(txtCantidad.Text.Trim()),
                Descripcion = txtDescripcion.Text.Trim()
            };
            ((List<DetalleComanda>)Session["detallesComanda"]).Add(detalleComanda);
            lstDetalleComanda.Items.Add(detalleComanda.Cantidad+"-"+ddlProducto.SelectedItem.Text+((detalleComanda.Descripcion=="")?"":("-"+detalleComanda.Descripcion)));
            ddlTipoProducto.SelectedIndex = 0;
            refrescarProductos();
            txtCantidad.Text = "1";
            txtDescripcion.Text = "";
            botonEliminarLista();
        }
        protected void btnElimnar_Click(object sender, EventArgs e)
        {
            ((List<DetalleComanda>)Session["detallesComanda"]).RemoveAt(lstDetalleComanda.SelectedIndex);
            lstDetalleComanda.Items.RemoveAt(lstDetalleComanda.SelectedIndex);
            botonEliminarLista();
        }

        protected void botonEliminarLista()
        {
            int i = lstDetalleComanda.Items.Count;
            if (i > 0)
            {
                lstDetalleComanda.SelectedIndex=i - 1;
                btnElimnar.Enabled = true;
            }
            else
            {
                btnElimnar.Enabled = false;
            }
            
        }
    }
}
