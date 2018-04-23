using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Factura
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdFactura{ get; set; }
        public int IdMesa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public double Total{ get; set; }
        public int IdTipoPago{ get; set; }
        public double PagoTarjeta { get; set; }
        public double PagoEfectivo{ get; set; }
        public int IdTarjeta{ get; set; }
    }
}
