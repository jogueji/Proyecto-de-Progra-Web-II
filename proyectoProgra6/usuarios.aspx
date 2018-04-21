<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="proyectoProgra6.usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="contact">
        <div class="section group">
            <div class="col_2_of_3 contact_2_of_3">
                <div class="contact-form">
                    <asp:GridView ID="dgvUsuarios" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="dgvUsuarios_RowCancelingEdit" OnRowEditing="dgvUsuarios_RowEditing"  BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                            <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" ReadOnly="True" />
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtNombre" runat="server" TextMode="Number"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Estado">
                                <ItemTemplate>
                                    <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("IdEstadoMesa") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CheckBoxField DataField="Estado" HeaderText="Activo" />
                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
