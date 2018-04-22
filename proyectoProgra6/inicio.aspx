<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="proyectoProgra6.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="events">
	        			<div class="section group">
                             <%if ((Session["tipoUsuario"]) != null)
                            {
                                if ((int)(Session["tipoUsuario"]) == 1)
                                {%>
							<div class="grid_1_of_3 events_1_of_3">
							  <div class="event-time">
                                  
								<h4><span>Mesas</span></h4>
								  <h4>Lista de Mesas</h4>
							  </div>
							     <div class="event-img">
								   <a href="mesas.aspx"><img src="images/tableImg.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
							<div class="grid_1_of_3 events_1_of_3">
								<div class="event-time">
								<h4><span>Productos</span></h4>
								  <h4>Lista de Productos</h4>
							  </div>
								<div class="event-img">
								    <a href="producto.aspx"><img src="images/productsImg.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
							<div class="grid_1_of_3 events_1_of_3">
								<div class="event-time">
								<h4><span>Usuarios</span></h4>
								  <h4>Lista de Usuarios</h4>
							  </div>

								<div class="event-img">
								    <a href="usuario.aspx"><img src="images/usersImg.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
					   </div>
           <%}
                            }%>
					   <div class="section group">
							<div class="grid_1_of_3 events_1_of_3">
							  <div class="event-time">
								<h4><span>Comandas</span></h4>
								  <h4>Comanda Nueva</h4>
							  </div>
								<div class="event-img">
								    <a href="comanda.aspx"><img src="images/comandaImg.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
							<div class="grid_1_of_3 events_1_of_3">
								<div class="event-time">
								<h4><span>Quienes Somos</span></h4>
								  <h4>Sobre Nosotros</h4>
							  </div>
								<div class="event-img">
								    <a href="about.aspx"><img src="images/aboutImg.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
                           <div class="grid_1_of_3 events_1_of_3">
								<div class="event-time">
								<h4><span>Reportes</span></h4>
								  <h4>Menu de Reportes</h4>
							  </div>
								<div class="event-img">
								    <a href="reportes.aspx"><img src="images/reporteImg2.png" alt="" /><span>Ir</span></a>
							   </div>
							</div>
							
					   </div>					   
	        		</div>
	        	</div>        
	        </div>
</asp:Content>
