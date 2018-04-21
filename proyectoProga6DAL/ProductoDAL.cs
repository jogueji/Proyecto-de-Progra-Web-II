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
    public class ProductoDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public ProductoDAL()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void InsertarProducto(Producto pro)
        {
            _db.Insert<Producto>(pro);
        }

        public List<Producto> ListaProductosAct()
        {
            return _db.Select<Producto>(a=>a.Estado==true);
        }

        public List<Producto> ListaProductos()
        {
            return _db.Select<Producto>();
        }

        public Producto BuscarProducto(int id)
        {
            return _db.Select<Producto>(a => a.IdProducto == id).FirstOrDefault() ;
        }

        public void ActualizarProducto(Producto pro)
        {
            _db.Update<Producto>(pro);
        }

        public List<Producto> ListaProductosXTipo(int idTipoProducto)
        {
            return _db.Select<Producto>(a => a.IdTipoProducto== idTipoProducto);
        }
    }
}
