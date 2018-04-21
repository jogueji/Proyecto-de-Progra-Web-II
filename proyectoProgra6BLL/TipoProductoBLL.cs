using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;
using proyectoProga6DAL;

namespace proyectoProgra6BLL
{
    public class TipoProductoBLL
    {
        private TipoProductoDAL tipoProductoDAL;
        public TipoProductoBLL()
        {
            tipoProductoDAL = new TipoProductoDAL();
        }

        public List<TipoProducto> ListaTipoProducto()
        {
            return tipoProductoDAL.ListaTipoProducto();
        }

        public string DescripcionTipoProducto(int id)
        {
            return tipoProductoDAL.DescripcionTipoProducto(id);
        }
    }
}
