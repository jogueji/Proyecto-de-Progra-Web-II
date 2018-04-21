using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Producto
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdProducto { get; set; }
        public byte[] Imagen { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdTipoProducto { get; set; }
        public Boolean Estado { get; set; }
    }
}
