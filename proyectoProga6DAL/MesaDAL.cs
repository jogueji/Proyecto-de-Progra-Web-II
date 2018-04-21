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
    public class MesaDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MesaDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarMesa(Mesa mesa)
        {
            _db.Insert<Mesa>(mesa);
        }

        public void ActualizarMesa(Mesa mesa)
        {
            _db.Update<Mesa>(mesa);
        }

        public List<Mesa> ListaMesas()
        {
            return _db.Select<Mesa>();
        }
        public Mesa BuscarMesa(int id)
        {
            return _db.Select<Mesa>(a =>a.IdMesa==id).FirstOrDefault();
        }
        public List<Mesa> ListaMesasActivas(int idUsuario)
        {
            return _db.Select<Mesa>(a=>(a.Estado==true&&(a.IdUsuario==idUsuario||a.IdUsuario ==0)));//hacer caso omiso a rayas verde
        }
    }
}
