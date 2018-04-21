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

        public void ActualizarComanda(Comanda comanda)
        {
            Comanda coman=comandaDAL.BuscarComandaDAL(comanda.IdComanda);
            coman.IdEstadoComanda = comanda.IdEstadoComanda;
            comandaDAL.ActualizarComanda(coman);
        }

        public String DetalleComanda(int idComanda)
        {
            ProductoDAL proDAL = new ProductoDAL();
            String cadena = "Comanda #" + idComanda+"\n";
            DetalleComandaDAL detalleDAL = new DetalleComandaDAL();
            List<DetalleComanda> detalles =detalleDAL.ListaDetalleComandas(idComanda);
            foreach (DetalleComanda item in detalles)
            {
                cadena += item.Cantidad +" "+proDAL.BuscarProducto(item.IdProducto).Nombre+(item.Descripcion == "" ? "" : "-") + item.Descripcion+"\n";
            }
            return cadena;
        }
    }
}