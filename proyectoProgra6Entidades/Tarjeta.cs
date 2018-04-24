using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Tarjeta
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public string IdTarjeta{ get; set; }
        public string Codigo{ get; set; }
        public int MesCaduca { get; set; }
        public int AnnoCaduca{ get; set; }
    }
}
