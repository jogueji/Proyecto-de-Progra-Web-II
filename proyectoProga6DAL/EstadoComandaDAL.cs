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
    public class EstadoComandaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public EstadoComandaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public string DescripcionEstadoComanda(int id)
        {
            return _db.Select<EstadoComanda>(a => a.IdEstadoComanda== id).FirstOrDefault().Descripcion;
        }

        public List<EstadoComanda> Lista()
        {
            return _db.Select<EstadoComanda>(a=>a.IdEstadoComanda!=5);
        }
    }
}
