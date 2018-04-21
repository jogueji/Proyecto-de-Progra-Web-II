using proyectoProga6DAL;
using System.Collections.Generic;
using proyectoProgra6Entidades;

namespace proyectoProgra6BLL
{
    public class ProductoBLL
    {
        private ProductoDAL productoDAL;
        public ProductoBLL()
        {
            productoDAL = new ProductoDAL();
        }

        public void InsertarProducto(Producto pro)
        {
            productoDAL.InsertarProducto(pro);
        }

        public List<Producto> ListaProductosAct()
        {
            return productoDAL.ListaProductosAct();
        }

        public List<Producto> ListaProductos()
        {
            return productoDAL.ListaProductos();
        }

        public Producto BuscarProducto(int id)
        {
            return productoDAL.BuscarProducto(id);
        }

        public void ActualizarProducto(Producto pro)
        {
            productoDAL.ActualizarProducto(pro);
        }

        public List<Producto> ListaProductosXTipo(int idTipoProducto)
        {
            return productoDAL.ListaProductosXTipo(idTipoProducto);
        }
    }
}
