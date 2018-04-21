using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;
using proyectoProga6DAL;

namespace proyectoProgra6BLL
{
    public class ComandaBLL
    {
        private ComandaDAL comandaDAL;
        public ComandaBLL()
        {
            comandaDAL = new ComandaDAL();
        }

        public int InsertarComanda(Comanda comanda)
        {
            return comandaDAL.InsertarComanda(comanda);
        }

        public List<Comanda> ListaComandas(int idMesa)
        {
            return comandaDAL.ListaComandas(idMesa);
        }
    }
}