﻿using proyectoProga6DAL;
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
        public FacturaBLL()
        {
            facturaDAL = new FacturaDAL();
        }

        public decimal TotalFactura(int idMesa)
       {
           decimal total = 0;
            List<DetalleFactura> lista = ListaDetalleFactura(idMesa);
            foreach (DetalleFactura item in lista)
            {
                total += item.Subtotal;
            }
            return total;
        }
    }
}
