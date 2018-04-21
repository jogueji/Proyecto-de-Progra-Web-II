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
    public partial class mesas : System.Web.UI.Page
    {
        private MesaBLL mesaBLL = new MesaBLL();
        private EstadoMesaBLL estadoBLL = new EstadoMesaBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoUsuario"]) != null)
            {
                if ((int)(Session["tipoUsuario"]) != 1)
                    Response.Write("<script languaje=javascript>window.alert('El usuario no tiene privilegios para accesar a esta pagina');window.location.href='login.aspx'</script>");
            }
            if (!IsPostBack)
                RefrescarLista();
        }
        protected void dgvMesas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvMesas.EditIndex = e.NewEditIndex;
            RefrescarLista();
        }
        protected void dgvMesas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvMesas.EditIndex = -1;
            RefrescarLista();
        }

        protected void dgvMesas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvMesas.PageIndex = e.NewPageIndex;
            RefrescarLista();
        }
        protected void dgvMesas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.Estado = ((CheckBox)(dgvMesas.Rows[e.RowIndex].Cells[3].Controls[0])).Checked;
            mesa.Capacidad = Int32.Parse(((TextBox)(dgvMesas.Rows[e.RowIndex].Cells[2].Controls[0])).Text);
            mesa.IdMesa = Int32.Parse((dgvMesas.Rows[e.RowIndex].Cells[1]).Text);
            mesaBLL.ActualizarMesa(mesa);
            dgvMesas.EditIndex = -1;
            RefrescarLista();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            mesaBLL.InsertarMesa(new Mesa()
            {
                IdEstadoMesa = 1,
                Capacidad = Int32.Parse(txtCantidad.Text.Trim()),
                Estado = chkEstado.Checked
            });
            dgvMesas.EditIndex = -1;
            Response.Redirect("mesas.aspx");
        }

        protected void RefrescarLista()
        {
            dgvMesas.DataSource = mesaBLL.ListaMesas();
            dgvMesas.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("mesas.aspx");
        }
    }
}