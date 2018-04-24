using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;
using System.Data;
using ServiceStack.OrmLite;

namespace proyectoProga6DAL
{
    public class FacturaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public FacturaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public int InsetarFactura(Factura factura)
        {
            _db.Insert<Factura>(factura);
            return _db.Select<Factura>().Last().IdFactura;
        }
    }
}
