using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;

namespace proyectoProgra6Interfaces
{
    public interface IUsuarioBLL
    {
        Usuario existeUsuario(string pId);
        void insertarUsuario(Usuario pUsuario);
        void borrarUsuario(string pId);
        void actualizarUsuario(Usuario pUsuario);
        void activarUsuario(string pId);
        void inactivarUsuario(string pId);
        List<Usuario> listaUsuarios();
        void cambiarContrasenna(string pId, string pNuevaContrasenna);
        bool validarIngreso(string pNombreUsuario, string pContrasenna);
    }
}
