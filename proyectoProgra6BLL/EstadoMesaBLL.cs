using proyectoProga6DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class EstadoMesaBLL
    {
        private EstadoMesaDAL estadoMesaDAL;
        public EstadoMesaBLL()
        {
            estadoMesaDAL = new EstadoMesaDAL();
        }
        public string DescripcionEstadoMesa(int id)
        {
            return estadoMesaDAL.DescripcionEstadoMesa(id);
        }
    }
}
