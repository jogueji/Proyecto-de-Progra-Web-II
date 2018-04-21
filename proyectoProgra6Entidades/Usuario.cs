using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6Entidades
{
    public class Usuario

    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contrasenna { get; set; }
        public int IdTipoUsuario { get; set; }
        public bool Estado { get; set; }



    }
}
