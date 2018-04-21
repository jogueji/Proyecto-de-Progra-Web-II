using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Comanda
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdComanda { get; set; }
        public int IdMesa{ get; set; }
        public int IdUsuario{ get; set; }
        public DateTime Fecha { get; set; }
        public int IdEstadoComanda{ get; set; }
    }
}
