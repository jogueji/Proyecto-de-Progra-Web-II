using proyectoProga6DAL;
using proyectoProgra6Entidades;
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
        DetalleFacturaBLL detalleFacturaBLL;
        public FacturaBLL()
        {
            detalleFacturaBLL = new DetalleFacturaBLL();
            facturaDAL = new FacturaDAL();
        }

        public decimal TotalFactura(int idMesa)
        {
            
            decimal total = 0;
            List<DetalleFactura> lista = detalleFacturaBLL.ListaDetalleFactura(idMesa);
            foreach (DetalleFactura item in lista)
            {
                total += item.Subtotal;
            }
            return total;
        }

        public void GuardarFactura(Factura fact)
        {
            int idFact=facturaDAL.InsetarFactura(fact);
            List<DetalleFactura> lista = detalleFacturaBLL.ListaDetalleFactura(fact.IdMesa);
            foreach (DetalleFactura item in lista)
            {
                item.IdFactura = idFact;
                detalleFacturaBLL.Insertar(item);
            }
        }
    }
}
