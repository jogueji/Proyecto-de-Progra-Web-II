using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;
using ServiceStack.OrmLite;
using System.Data;

namespace proyectoProga6DAL
{
    public class UsuarioDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public UsuarioDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                        SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public Usuario BuscarUsuario(String nombUsu, String contrasenna)
        {
            return _db.Select<Usuario>(a => a.NombreUsuario == nombUsu && a.Contrasenna == contrasenna).LastOrDefault();
        }

        public List<Usuario> ListaUsuarios()
        {
            return _db.Select<Usuario>(a => a.IdUsuario!=0);
        }

        public Usuario BuscarUsuario(int idUsuario)
        {
            return _db.Select<Usuario>(a=>a.IdUsuario==idUsuario).LastOrDefault();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            _db.Insert<Usuario>(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _db.Update<Usuario>(usuario);
        }
    }
}
