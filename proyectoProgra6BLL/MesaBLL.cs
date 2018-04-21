using proyectoProga6DAL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class MesaBLL
    {
        private MesaDAL mesaDAL;
        public MesaBLL()
        {
            mesaDAL = new MesaDAL();
        }
        public List<Mesa> ListaMesas()
        {
            return mesaDAL.ListaMesas();
        }
        public List<Mesa> ListaMesasActivas(int idUsuario)
        {
            return mesaDAL.ListaMesasActivas(idUsuario);            
        }
        public void InsertarMesa(Mesa mesa)
        {
            mesaDAL.InsertarMesa(mesa);
        }

        public void ActualizarMesa(Mesa mesa)
        {
            Mesa mesaVieja = mesaDAL.BuscarMesa(mesa.IdMesa);
            mesa.IdEstadoMesa= mesaVieja.IdEstadoMesa;
            mesa.IdUsuario = mesaVieja.IdUsuario;
            mesaDAL.ActualizarMesa(mesa);
        }

        public void ActualizarMesa(int idUsuario, int idMesa,int idEstadoMesa)
        {
            Mesa mesa= mesaDAL.BuscarMesa(idMesa);
            mesa.IdUsuario = idUsuario;
            mesa.IdEstadoMesa = idEstadoMesa;
            mesaDAL.ActualizarMesa(mesa);
        }
    }
}
