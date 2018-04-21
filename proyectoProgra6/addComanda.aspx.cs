using proyectoProgra6BLL;
using proyectoProgra6Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoProgra6
{
    public partial class addComanda : System.Web.UI.Page
    {
        private MesaBLL mesaBLL = new MesaBLL();
        protected String codigo;
        protected void Page_Load(object sender, EventArgs e)
        {
            codigo = "";
            EstadoMesaBLL estadoMesaBLL = new EstadoMesaBLL();
            string estadoMesa = "";
            int num=0;
            List<Mesa> mesas = mesaBLL.ListaMesasActivas();
            foreach (Mesa item in mesas)
            {
                estadoMesa = estadoMesaBLL.DescripcionEstadoMesa(item.IdEstadoMesa);
                if (num % 3==0)
                {
                    if (num != 0)
                    {
                        codigo += "</div>";
                    }
                    codigo += "<div class='section group'>";
                }
                codigo += "<div class='grid_1_of_3 events_1_of_3'><div class='event-time'><h4><span>Mesa #";
                codigo += item.IdMesa;
                codigo +="</span></h4><h4>";
                codigo += estadoMesa;
                codigo += "</h4></div><div class='event-img'><a href = 'comandas.aspx/idMesa=";
                codigo += item.IdMesa;
                codigo +="'><img src='images/mesa";
                codigo += estadoMesa;
                codigo+=".jpg' /><span>Añadir comanda</span></a></div></div>";
                num++;
            }
        }
    }
}