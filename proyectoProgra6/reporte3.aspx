<%@ Page Title="Reporte Segun Tipo de Pago" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="reporte3.aspx.cs" Inherits="proyectoProgra6.Reportes.reporte3" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="col_1_of_3 contact_1_of_3">
            <div class="contact-form">
                <p>Tipo de Pago</p>
                <div>
                    <span>
                        <asp:DropDownList ID="ddlTipoPago" runat="server" OnSelectedIndexChanged="ddlTipoPago_SelectedIndexChanged"></asp:DropDownList>
                    </span>
                </div>
            </div>
        </div>
    </div>


    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="663px">
        <LocalReport ReportPath="ReporteTipoPago.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetTipoPago" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="proyectoProgra6.DataSetJyJTableAdapters.VentaTableAdapter"></asp:ObjectDataSource>


</asp:Content>
