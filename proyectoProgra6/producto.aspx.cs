using proyectoProgra6BLL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6
{
    public partial class producto : System.Web.UI.Page
    {
        private TipoProductoBLL tipoProductoBLL = new TipoProductoBLL();
        private ProductoBLL productoBLL = new ProductoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoUsuario"]) != null)
            {
                if ((int)(Session["tipoUsuario"]) != 1)
                    Response.Write("<script languaje=javascript>window.alert('El usuario no tiene privilegios para accesar a esta pagina');window.location.href='login.aspx'</script>");
            }
            if (!IsPostBack)
            {   
                List<TipoProducto> tiposProducto = tipoProductoBLL.ListaTipoProducto();
                ddlTipoProducto.DataSource = tiposProducto;
                ddlTipoProducto.DataTextField = "Descripcion";
                ddlTipoProducto.DataValueField = "IdTipoProducto";
                ddlTipoProducto.DataBind();
                imgProducto.ImageUrl = "images/icon_food.png";
                RefrescarLista();
            }
        }
        protected void RefrescarLista()
        {
            dgvProductos.DataSource = productoBLL.ListaProductos();
            dgvProductos.DataBind();
        }
        protected String descripTipoPro(object id)
        {
            int num = (int)id;
            return tipoProductoBLL.DescripcionTipoProducto(num);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            byte[] cadenaBytes = null;
            if (flImagen.FileName != null && flImagen.FileName != "")
                cadenaBytes = flImagen.FileBytes;
            else
            {
                cadenaBytes = File.ReadAllBytes(Path.Combine(Server.MapPath("~/"), imgProducto.ImageUrl));
            }
            Producto pro = new Producto()
            {
                Nombre = txtNombre.Text.Trim(),
                Imagen = (byte[])cadenaBytes,
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = Decimal.Parse(txtPrecio.Text.Trim()),
                IdTipoProducto = Int32.Parse(ddlTipoProducto.SelectedValue),
                Estado = chkEstado.Checked
            };
            if (btnIngresar.Text == "Ingresar")  
                productoBLL.InsertarProducto(pro);
            else
            {
                pro.IdProducto = Int32.Parse(hdIdProducto.Value);
                productoBLL.ActualizarProducto(pro);
            }
            Response.Redirect("producto.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("producto.aspx");
        }

        protected void dgvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            btnIngresar.Text = "Modificar";
            Producto producto=productoBLL.BuscarProducto(Int32.Parse((dgvProductos.DataKeys[e.NewEditIndex].Values[0]).ToString()));
            hdIdProducto.Value = producto.IdProducto.ToString(); 
            txtNombre.Text= producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString();
            ddlTipoProducto.SelectedValue = producto.IdTipoProducto.ToString();
            chkEstado.Checked = producto.Estado;
            ImageConverter ic = new ImageConverter();
            Bitmap bitImg = new Bitmap((System.Drawing.Image)ic.ConvertFrom(producto.Imagen));
            String ruta = "images/" + producto.IdProducto + ".png";
            bitImg.Save(Path.Combine(Server.MapPath("~/"), ruta));
            imgProducto.ImageUrl = ruta;
            dgvProductos.EditIndex = -1;
            RefrescarLista();
        }
    }
}