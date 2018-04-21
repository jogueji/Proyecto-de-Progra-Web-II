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
    public class ComandaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public ComandaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public int InsertarComanda(Comanda comanda)
        {
            _db.Insert<Comanda>(comanda);
            return _db.Select<Comanda>().Last().IdComanda;
        }

        public List<Comanda> ListaComandas(int idMesa)
        {
            return _db.Select<Comanda>(a=>a.IdMesa==idMesa &&a.IdEstadoComanda!=5);
        }
    }
}
