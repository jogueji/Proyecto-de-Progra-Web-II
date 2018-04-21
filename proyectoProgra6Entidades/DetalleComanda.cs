using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class DetalleComanda
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdDetalleComanda{ get; set; }
        public int IdComanda { get; set; }
        public int IdProducto{ get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
