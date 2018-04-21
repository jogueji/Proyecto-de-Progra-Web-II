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
    public partial class listaComandas : System.Web.UI.Page
    {
        private ComandaBLL comandaBLL = new ComandaBLL();
        private EstadoComandaBLL estadoComandaBLL = new EstadoComandaBLL();
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idMesa"] == null)
                Response.Write("<script languaje=javascript>window.alert('Seleccione la mesa a la que se le desea ver las comandas');window.location.href='menuPrincipal.aspx'</script>");
            if (!IsPostBack)
            {

                RefrescarLista();
            }

        }

        protected void RefrescarLista()
        {
            dgvComandas.DataSource = comandaBLL.ListaComandas(Int32.Parse(Request.QueryString["idMesa"]));
            dgvComandas.DataBind();
        }

        protected void dgvComandas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvComandas.EditIndex = -1;
            RefrescarLista();
        }

        protected void dgvComandas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvComandas.EditIndex = e.NewEditIndex;
            RefrescarLista();
        }

        protected void dgvComandas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Comanda comanda = new Comanda()
            {
                IdComanda = Int32.Parse((dgvComandas.Rows[e.RowIndex].Cells[2]).Text),
                IdEstadoComanda= Int32.Parse(((DropDownList)dgvComandas.Rows[e.RowIndex].FindControl("ddlEstado")).SelectedValue)
            };
            comandaBLL.ActualizarComanda(comanda);
            MesaBLL mesaBLL = new MesaBLL();
            mesaBLL.ActualizarEstadoMesa(Int32.Parse(Request.QueryString["idMesa"]),comanda.IdEstadoComanda);
            dgvComandas.EditIndex = -1;
            RefrescarLista();
        }

        protected void dgvComandas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvComandas.PageIndex = e.NewPageIndex;
            RefrescarLista();
        }

        protected String descripEstadoComanda(object id)
        {
            int num = (int)id;
            return estadoComandaBLL.DescripcionEstadoComanda(num);
        }
        protected String nombUsuario(object id)
        {
            int num = (int)id;
            return usuarioBLL.NombreUsuario(num);
        }
        protected void dgvComandas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddlEstado = (e.Row.FindControl("ddlEstado") as DropDownList);

                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    ddlEstado.DataSource = estadoComandaBLL.Lista();
                    ddlEstado.DataValueField= "IdEstadoComanda";
                    ddlEstado.DataTextField= "Descripcion";
                    ddlEstado.SelectedValue = DataBinder.Eval(e.Row.DataItem, "IdEstadoComanda").ToString();
                    ddlEstado.DataBind();
                }
            }
        }

        protected void dgvComandas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "detalle")
            {
                txtDetalle.Visible = true;
                txtDetalle.Text=comandaBLL.DetalleComanda(Int32.Parse(dgvComandas.Rows[Int32.Parse(e.CommandArgument.ToString())].Cells[2].Text));
            }
        }
    }
}