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
    public class DetalleComandaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public DetalleComandaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void InsertarDetalleComanda(DetalleComanda detalleComanda)
        {
            _db.Insert<DetalleComanda>(detalleComanda);
        }

        public List<DetalleComanda> ListaDetalleComandas(int idComanda)
        {
            return _db.Select<DetalleComanda>(a => a.IdComanda == idComanda);
        }
    }
}
