using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Interfaces
{
    public interface IUsuarioDAL
    {
        Usuario existeUsuario(string pId);
        void insertarUsuario(Usuario pUsuario);
        void borrarUsuario(string pId);
        void actualizarUsuario(Usuario pUsuario);
        void activarUsuario(string pId);
        void inactivarUsuario(string pId);
        List<Usuario> listaUsuarios();
        void cambiarContrasenna(string pId, string pNuevaContrasenna);
    }
}
