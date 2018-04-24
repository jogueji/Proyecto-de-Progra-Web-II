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
    public class DetalleFacturaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public DetalleFacturaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsetarFactura(DetalleFactura detalleFactura)
        {
            _db.Insert<DetalleFactura>(detalleFactura);
        }
    }
}
