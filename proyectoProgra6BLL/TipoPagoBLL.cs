using proyectoProga6DAL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class TipoPagoBLL
    {
        private TipoPagoDAL tipoPagoDAL;
        public TipoPagoBLL()
        {
            tipoPagoDAL = new TipoPagoDAL();
        }

        public List<TipoPago> ListaTipoPago()
        {
            return tipoPagoDAL.ListaTipoPago();
        }
    }
}
