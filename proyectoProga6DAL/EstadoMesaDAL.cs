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
    public class EstadoMesaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public EstadoMesaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public string DescripcionEstadoMesa(int id)
        {
            return _db.Select<EstadoMesa>(a => a.IdEstadoMesa == id).FirstOrDefault().Descripcion;
        }
    }
}
