using proyectoProgra6BLL;
using proyectoProgra6Entidades;
using System;
using System.Web.UI.WebControls;

namespace proyectoProgra6
{
    public partial class usuario : System.Web.UI.Page
    {
        private TipoUsuarioBLL tipoUsuarioBLL = new TipoUsuarioBLL();
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if ((Session["tipoUsuario"]) != null)
            {
                if ((int)(Session["tipoUsuario"]) != 1)
                    Response.Write("<script languaje=javascript>window.alert('El usuario no tiene privilegios para accesar a esta pagina');window.location.href='inicio.aspx'</script>");
            }
            if (!IsPostBack)
            {   
                ddlTipoUsuario.DataSource = tipoUsuarioBLL.ListaTipoUsuario();
                ddlTipoUsuario.DataTextField = "Descripcion";
                ddlTipoUsuario.DataValueField = "IdTipoUsuario";
                ddlTipoUsuario.DataBind();
                RefrescarLista();
            }
        }
        protected void RefrescarLista()
        {
            dgvUsuarios.DataSource = usuarioBLL.ListaUsuarios();
            dgvUsuarios.DataBind();
        }
        protected String descripTipoUsu(object id)
        {
            int num = (int)id;
            return tipoUsuarioBLL.DescripcionTipoUsuario(num);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string msjError = "";

            Usuario usu = new Usuario()
            {
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Contrasenna = txtContrasenna.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                IdTipoUsuario = Int32.Parse(ddlTipoUsuario.SelectedValue),
                Estado = chkEstado.Checked
            };
            if (btnIngresar.Text == "Ingresar")
            {
                if (usuarioBLL.BuscarUsuarioPorNombre(txtNombreUsuario.Text) == null)
                {
                    usuarioBLL.InsertarUsuario(usu);
                    Response.Redirect("usuario.aspx");
                }
                else
                {
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ya existe un usuario con este nombre de usuario!";
                }
            }

            else
            {
                usu.IdUsuario = Int32.Parse(hdIdUsuario.Value);
                usuarioBLL.ActualizarUsuario(usu);
                Response.Redirect("usuario.aspx");
            }
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("usuario.aspx");
        }

        protected void dgvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            btnIngresar.Text = "Modificar";
            Usuario usuario = usuarioBLL.BuscarUsuario(Int32.Parse((dgvUsuarios.DataKeys[e.NewEditIndex].Values[0]).ToString()));
            hdIdUsuario.Value = usuario.IdUsuario.ToString();
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtContrasenna.Text = usuario.Contrasenna;
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            ddlTipoUsuario.SelectedValue = usuario.IdTipoUsuario.ToString();
            chkEstado.Checked = usuario.Estado;
            dgvUsuarios.EditIndex = -1;
            RefrescarLista();
        }
    }
}