using proyectoProga6DAL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoProgra6BLL
{
    public class DetalleFacturaBLL
    {
        private DetalleFacturaDAL detalleFacturaDAL;
        public decimal total { get; set; }
        public DetalleFacturaBLL()
        {
            detalleFacturaDAL = new DetalleFacturaDAL();
        }

        public string Detalles(int idMesa,string nombreUsuario)
        {
            total = 0;
            ProductoDAL proDAL = new ProductoDAL();
            string cadena = "Mesa #"+idMesa+"\nMesero: "+nombreUsuario+"\nFecha: "+DateTime.Now.ToString("dd/MM/yy")+"\n";
            List<DetalleFactura> lista = ListaDetalleFactura(idMesa);
            foreach (DetalleFactura item in lista)
            {
                cadena+=item.Cantidad+" "+proDAL.BuscarProducto(item.IdProducto).Nombre+"(s)-"+item.Subtotal.ToString("#.00")+"\n";
                total+=item.Subtotal;
            }
            cadena += "Total:" + total.ToString("#.00");
            return cadena;
        }

        public List<DetalleFactura> ListaDetalleFactura(int idMesa)
        {
            ProductoBLL proBLL = new ProductoBLL();
            ComandaBLL comandaBLL = new ComandaBLL();
            DetalleComandaBLL detalleComandaBLL = new DetalleComandaBLL();
            List<Comanda> comandas = comandaBLL.ListaComandas(idMesa);
            List<DetalleComanda> detalleComandas;
            List<DetalleFactura> detallesFactura=new List<DetalleFactura>();
            DetalleFactura detalleFactura;
            foreach (Comanda comanda in comandas)
            {
                detalleComandas = detalleComandaBLL.ListaDetalleComanda(comanda.IdComanda);
                foreach (DetalleComanda item in detalleComandas)
                {
                    detalleFactura = detallesFactura.Find(a => a.IdProducto == item.IdProducto);
                    if (detalleFactura == null)
                    {
                        detallesFactura.Add(new DetalleFactura() { IdProducto = item.IdProducto, Cantidad = item.Cantidad });
                    }
                    else
                    {
                        detallesFactura.Find(a => a.IdProducto == item.IdProducto).Cantidad = detalleFactura.Cantidad+item.Cantidad;
                    }
                }
            }
            for (int i = 0; i < detallesFactura.Count; i++)
            {
                detallesFactura.ElementAt(i).Subtotal = proBLL.BuscarProducto(detallesFactura.ElementAt(i).IdProducto).Precio * detallesFactura.ElementAt(i).Cantidad;
            }
            return detallesFactura;
        }

        public decimal TotalFactura(int idMesa)
        {
            decimal total = 0;
            List<DetalleFactura> lista = ListaDetalleFactura(idMesa);
            foreach (DetalleFactura item in lista)
            {
                total += item.Subtotal;
            }
            return total;
        }
    }
}
