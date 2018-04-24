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
    public class TarjetaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public TarjetaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public Tarjeta BuscarTarjeta(string idTarjeta)
        {
            return _db.Select<Tarjeta>(a =>a.IdTarjeta==idTarjeta).LastOrDefault();
        }

        public void InsertarTarjeta(Tarjeta tarj)
        {
            _db.Insert<Tarjeta>(tarj);
        }
    }
}
