using proyectoProgra6BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;
using proyectoProga6DAL;

namespace proyectoProgra6BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL;
        public UsuarioBLL()
        {
            usuarioDAL = new UsuarioDAL();
        }

        public bool VerificarUsuario(String nombUsuario, String contrasenna)
        {
            Usuario usu= usuarioDAL.BuscarUsuario(nombUsuario, contrasenna);
            if (usu == null)
                return false;
            return (usu.NombreUsuario == nombUsuario && usu.Contrasenna == contrasenna&& usu.Estado);
        }
        public Usuario BuscarUsuario(String nombUsuario, String contrasenna)
        {
            return usuarioDAL.BuscarUsuario(nombUsuario, contrasenna); 
        }

        public List<Usuario> ListaUsuarios()
        {
            return usuarioDAL.ListaUsuarios();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            usuarioDAL.InsertarUsuario(usuario);
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            usuarioDAL.ActualizarUsuario(usuario);
        }

        public Usuario BuscarUsuario(int idUsuario)
        {
            return usuarioDAL.BuscarUsuario(idUsuario);
        }
        public Usuario BuscarUsuarioPorNombre(string nombreUsuario)
        {
            return usuarioDAL.BuscarUsuarioPorNombre(nombreUsuario);
        }

        public string NombreUsuario(int idUsuario)
        {
            Usuario usu = usuarioDAL.BuscarUsuario(idUsuario);
            return usu.Nombre+" "+usu.Apellidos;
        }
    }
}

