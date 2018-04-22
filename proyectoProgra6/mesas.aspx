<%@ Page Title="Mesas" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="mesas.aspx.cs" Inherits="proyectoProgra6.mesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="section group">
            <div class="col_1_of_3 contact_1_of_3">
                <div class="contact-form">
                    <p>Capacidad</p>
                    <div>
                        <span>
                            <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" min="1" max="20">1</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="La capacidad es requerida" ForeColor="Red" ControlToValidate="txtCantidad">Este dato es requerido</asp:RequiredFieldValidator> </span>
                    </div>
                    <div>
                        <span>
                            <p>Estado</p>
                            <asp:CheckBox ID="chkEstado" runat="server" Checked="True" />
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
            <div class="col_1_of_3 contact_2_of_3">
                <div class="contact-form">
                    <h3>Lista Mesas</h3>
                    <asp:GridView ID="dgvMesas" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="dgvMesas_RowCancelingEdit" OnRowUpdating="dgvMesas_RowUpdating" AllowPaging="True" 
                        OnRowEditing="dgvMesas_RowEditing"  BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                         CellPadding="3" CellSpacing="2" OnPageIndexChanging="dgvMesas_PageIndexChanging">
                        <Columns>
                            <asp:CommandField ShowEditButton="True" />
                            <asp:BoundField DataField="IdMesa" HeaderText="Numero de mesa" ReadOnly="True" />
                            <asp:BoundField DataField="Capacidad" HeaderText="Capacidad" />
                            <asp:CheckBoxField DataField="Estado" HeaderText="Activo" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
