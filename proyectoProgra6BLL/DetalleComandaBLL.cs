using proyectoProga6DAL;
using proyectoProgra6BLL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class DetalleComandaBLL
    {
        private DetalleComandaDAL detalleComandaDAL;
        public DetalleComandaBLL()
        {
            detalleComandaDAL = new DetalleComandaDAL();
        }

        public void InsertarDetalleComanda(DetalleComanda detalleComanda)
        {
            detalleComandaDAL.InsertarDetalleComanda(detalleComanda);
        }
    }
}
