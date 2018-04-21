using proyectoProgra6Entidades;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProga6DAL
{
    public class TipoUsuarioDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public TipoUsuarioDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<TipoUsuario> ListaTipoUsuario()
        {
            return _db.Select<TipoUsuario>();
        }

        public string DescripcionTipoUsuario(int id)
        {
            return _db.Select<TipoUsuario>(a => a.IdTipoUsuario== id).FirstOrDefault<TipoUsuario>().Descripcion;
        }
    }
}
