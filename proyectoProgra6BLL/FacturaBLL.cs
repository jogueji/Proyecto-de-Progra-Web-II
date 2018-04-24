using proyectoProga6DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class FacturaBLL
    {
        private FacturaDAL facturaDAL;
        public FacturaBLL()
        {
            facturaDAL = new FacturaDAL();
        }
    }
}
