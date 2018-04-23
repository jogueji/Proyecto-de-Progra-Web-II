using proyectoProga6DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class TarjetaBLL
    {
        private TarjetaDAL tarjetaDAL;
        public TarjetaBLL()
        {
            tarjetaDAL = new TarjetaDAL();
        }
    }
}
