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

        public void ActualizarEstadoMesa(int idMesa, int idEstadoComanda)
        {
            bool bandera = true;
            Mesa mesa = mesaDAL.BuscarMesa(idMesa);
            ComandaDAL comanDAL = new ComandaDAL();
            List<Comanda> comandas=comanDAL.ListaComandas(idMesa);
            foreach (Comanda item in comandas)
            {
                if (item.IdEstadoComanda == 1)
                {
                    mesa.IdEstadoMesa = 3;
                    break;
                }
                if (item.IdEstadoComanda == 2 || item.IdEstadoComanda == 3)
                {
                    mesa.IdEstadoMesa = 2;
                    bandera = false;
                }

                if (item.IdEstadoComanda == 4 && bandera)
                    mesa.IdEstadoMesa = 4;
            }
            mesaDAL.ActualizarMesa(mesa);
        }
    }
}
