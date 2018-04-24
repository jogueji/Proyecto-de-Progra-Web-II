<%@ Page Title="Reporte Ventas por Fechas" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="reporte2.aspx.cs" Inherits="proyectoProgra6.Reportes.reporte2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="col_1_of_3 contact_1_of_3">
            <div class="contact-form">
                <p color="white">Seleccione las fechas:</p>
                
                <div>
                    <span>
                        <asp:Label ID="Label1" runat="server" Text="Fecha Inicial:  " ForeColor="#FF9900"></asp:Label>
                        <asp:TextBox ID="txtFechaInicial" runat="server"></asp:TextBox>   
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtFechaInicial" ForeColor="Red">Debe ingesar una fecha.</asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Fecha Final:  " ForeColor="#FF9900"></asp:Label>  
                        <asp:TextBox ID="txtFechaFinal" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtFechaFinal" ForeColor="Red">Debe ingesar una fecha.</asp:RequiredFieldValidator>
                        <ajaxToolkit:CalendarExtender Format="dd/MM/yyyy" ID="cleCalendarioFechaInicial" runat="server" TargetControlID="txtFechaInicial" />
                        <ajaxToolkit:CalendarExtender Format="dd/MM/yyyy"  ID="cleCalendarioFechaFinal" runat="server" TargetControlID="txtFechaFinal" />
                        <br />
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                         </span>
                </div>
            </div>
        </div>
    </div>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1010px">
        <LocalReport ReportPath="ReporteVentas.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSetVentas" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" TypeName="proyectoProgra6.DataSetJyJTableAdapters.VentaTableAdapter"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="proyectoProgra6.DataSetJyJTableAdapters.ComandaTableAdapter"></asp:ObjectDataSource>
</asp:Content>
