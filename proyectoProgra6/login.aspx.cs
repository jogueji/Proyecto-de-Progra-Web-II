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
    public partial class login : System.Web.UI.Page
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idUsuario"] = null;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsu = txtNombre.Text.Trim();
            string contrasenna = txtContrasenna.Text.Trim();
            if (nombreUsu == "" || contrasenna == "")
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Debe llenar todos los campos!";
            }
            else
            {



                if (usuarioBLL.VerificarUsuario(nombreUsu, contrasenna))
                {
                    Usuario usu = usuarioBLL.BuscarUsuario(nombreUsu, contrasenna);
                    Session["idUsuario"] = usu.IdUsuario;
                    Session["tipoUsuario"] = usu.IdTipoUsuario;
                    Session["usuario"] = usu.Nombre + " " + usu.Apellidos;
                    Response.Redirect("inicio.aspx");
                }
                else
                {
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Usuario y/o contraseña incorrectos, inténtelo de nuevo.";
                }
            }
        }
    }
}