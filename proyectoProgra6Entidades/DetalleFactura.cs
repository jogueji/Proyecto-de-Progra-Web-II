using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class DetalleFactura
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdDetalleFactura { get; set; }
        public int IdFactura{ get; set; }
        public int IdProducto{ get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal{ get; set; }
    }
}
