<%@ Page Title="Comanda" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="comanda.aspx.cs" Inherits="proyectoProgra6.comanda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contact">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="section group">
                    <div class="col_1_of_3 contact_1_of_3">
                        <div class="contact-form"></div>
                    </div>
                    <div class="col_1_of_3 contact_1_of_3">
                        <div class="contact-form">
                            <p>Tipo de Producto</p>
                            <div>
                                <span>
                                    <asp:DropDownList ID="ddlTipoProducto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoProducto_SelectedIndexChanged1"></asp:DropDownList>
                                </span>
                            </div>
                            <p>Producto</p>
                            <div>
                                <span>
                                    <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" Style="display: initial; width: 10%" min="1">1</asp:TextBox>
                                    <asp:DropDownList ID="ddlProducto" runat="server" AutoPostBack="True" Style="display: initial; width: 80%"></asp:DropDownList>
                                </span>
                            </div>
                            <div>
                                <span>
                                    <asp:TextBox ID="txtDescripcion" placeholder="Descripción" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </span>
                            </div>
                            <div>
                                <span>
                                    <center>
                                        <asp:Button ID="btnAdd" runat="server" Text="Añadir" OnClick="btnAdd_Click" />
                                    </center>
                                </span>
                            </div>
                            <div>
                                <span>
                                    <center>
                                        <asp:ListBox ID="lstDetalleComanda" runat="server"></asp:ListBox>
                                    </center>
                                </span>
                            </div>
                            <div>
                                <span>
                                    <center>
                                        <asp:Button ID="btnElimnar" runat="server" Text="Eliminar" Enabled="False" OnClick="btnElimnar_Click" />
                                    </center>
                                </span>
                            </div>
                            <div>
                                <span>
                                    <center>
                                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
                            </center>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
