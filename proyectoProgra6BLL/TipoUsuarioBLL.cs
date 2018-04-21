using proyectoProga6DAL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class TipoUsuarioBLL
    {
        private TipoUsuarioDAL tipoUsuarioDAL;
        public TipoUsuarioBLL()
        {
            tipoUsuarioDAL = new TipoUsuarioDAL();
        }

        public List<TipoUsuario> ListaTipoUsuario()
        {
            return tipoUsuarioDAL.ListaTipoUsuario();
        }

        public string DescripcionTipoUsuario(int id)
        {
            return tipoUsuarioDAL.DescripcionTipoUsuario(id);
        }
    }
}
