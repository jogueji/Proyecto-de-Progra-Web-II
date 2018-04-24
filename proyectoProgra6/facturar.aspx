<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="facturar.aspx.cs" Inherits="proyectoProgra6.facturar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="section group">
            <div class="col_1_of_3 contact_1_of_3">
                <div class="contact-form"></div>
            </div>
            <div class="col_1_of_3 contact_1_of_3">
                <div class="contact-form">
                    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong id="textoMensajeError" runat="server"></strong>
                    </div>
                    <p>Tipo de Pago</p>
                    <div>
                        <span>
                            <asp:DropDownList ID="ddlTipoPago" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoPago_SelectedIndexChanged"></asp:DropDownList>
                        </span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtDetalle" runat="server" TextMode="MultiLine" Enabled="false"></asp:TextBox>
                        </span>
                    </div>
                    <div id="tarjeta" runat="server">
                        <div>
                            <span>
                                <asp:TextBox ID="txtNumeroTar" PlaceHolder="Numero de la tarjeta" runat="server"></asp:TextBox>
                            </span>
                        </div>
                        <div>
                            <span>
                                <asp:TextBox ID="txtCodigo" PlaceHolder="Codigo de la tarjeta" runat="server"></asp:TextBox>
                            </span>
                        </div>
                        <p>Mes de caducación</p>
                        <div>
                            <span>
                                <asp:DropDownList ID="ddlMes" runat="server">
                                    <asp:ListItem Value="01"></asp:ListItem>
                                    <asp:ListItem Value="02"></asp:ListItem>
                                    <asp:ListItem Value="03"></asp:ListItem>
                                    <asp:ListItem Value="04"></asp:ListItem>
                                    <asp:ListItem Value="05"></asp:ListItem>
                                    <asp:ListItem Value="06"></asp:ListItem>
                                    <asp:ListItem Value="07"></asp:ListItem>
                                    <asp:ListItem Value="08"></asp:ListItem>
                                    <asp:ListItem Value="09"></asp:ListItem>
                                    <asp:ListItem Value="10"></asp:ListItem>
                                    <asp:ListItem Value="11"></asp:ListItem>
                                    <asp:ListItem Value="12"></asp:ListItem>
                            </asp:DropDownList>
                            </span>
                        </div>
                        <p>Año de caducación</p>
                        <div>
                            <span>
                                <asp:DropDownList ID="ddlAnno" runat="server"></asp:DropDownList>
                            </span>
                        </div>
                        <p>Total tarjeta</p>
                        <div>
                            <span>
                                <asp:TextBox ID="txtPagoTarjeta" Text="0" runat="server"></asp:TextBox>
                            </span>
                        </div>
                    </div>
                    <div id="efectivo" runat="server">
                        <p>Total Efectivo</p>
                        <div>
                            <span>
                                <asp:TextBox ID="txtPagoEfectivo" Text="0" runat="server"></asp:TextBox>
                            </span>
                        </div>
                    </div>
                    <div>
                        <span>
                            <center>
                                <asp:Button ID="btnPagar" runat="server" Text="Pagar" OnClick="btnPagar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                            </center>
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
