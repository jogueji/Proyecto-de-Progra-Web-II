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
    public class TipoProductoDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public TipoProductoDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<TipoProducto> ListaTipoProducto()
        {
            return _db.Select<TipoProducto>();
        }

        public string DescripcionTipoProducto(int id)
        {
            return _db.Select<TipoProducto>(a=>a.IdTipoProducto==id).FirstOrDefault<TipoProducto>().Descripcion;
        }
    }
}
