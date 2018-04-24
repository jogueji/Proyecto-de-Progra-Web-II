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
                                    <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" Style="display: initial; width: 20%" min="1" max="100">1</asp:TextBox>
                                    <asp:DropDownList ID="ddlProducto" runat="server" AutoPostBack="True" Style="display: initial; width: 70%"></asp:DropDownList>
                                   
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" Text="Este dato es requerido" ControlToValidate="txtCantidad" ForeColor="Red"></asp:RequiredFieldValidator></span>
                                <br />
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MinimumValue="1" MaximumValue="20" Text="La cantidad debe ser entre 1 y 20" ControlToValidate="txtCantidad" ForeColor="Red"></asp:RangeValidator> </div>
                            <div>
                                <span>
                                    <asp:TextBox ID="txtDescripcion" placeholder="Descripción" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDescripcion" Text="Este dato es requerido" ForeColor="Red"></asp:RequiredFieldValidator></span>
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
                
            </ContentTemplate>
        </asp:UpdatePanel>
        </div>
</asp:Content>
