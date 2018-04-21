using proyectoProga6DAL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class EstadoComandaBLL
    {
        private EstadoComandaDAL estadoComandaDAL;
        public EstadoComandaBLL()
        {
            estadoComandaDAL = new EstadoComandaDAL();
        }
        public string DescripcionEstadoComanda(int id)
        {
            return estadoComandaDAL.DescripcionEstadoComanda(id);
        }

        public List<EstadoComanda> Lista()
        {
            return estadoComandaDAL.Lista();
        }
    }
}
