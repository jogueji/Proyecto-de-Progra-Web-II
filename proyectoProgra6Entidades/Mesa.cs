using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Mesa
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdMesa{ get; set; }
        public int Capacidad{ get; set; }
        public int IdEstadoMesa{ get; set; }
        public Boolean Estado{ get; set; }
        public int IdUsuario { get; set; }
    }
}
