<%@ Page Title="Lista comandas" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="listaComandas.aspx.cs" Inherits="proyectoProgra6.listaComandas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="section group">
            <div class="col_1_of_3 contact_2_of_3">
                <div class="contact-form">
                    <asp:GridView ID="dgvComandas" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="dgvComandas_RowCancelingEdit" OnRowUpdating="dgvComandas_RowUpdating" AllowPaging="True"
                        OnRowEditing="dgvComandas_RowEditing" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                        CellPadding="3" CellSpacing="2" OnPageIndexChanging="dgvComandas_PageIndexChanging" OnRowDataBound="dgvComandas_RowDataBound">
                        <Columns>
                            <asp:CommandField ShowEditButton="True" />
                            <asp:BoundField DataField="IdComanda" HeaderText="Comanda" ReadOnly="True" />
                            <asp:BoundField DataField="IdMesa" HeaderText="Mesa" ReadOnly="True" />
                            <asp:TemplateField HeaderText="Nombre de usuario">
                                <ItemTemplate>
                                    <asp:Label ID="lblUsuario" runat="server" Text='<%#nombUsuario(Eval("IdUsuario"))%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Fecha" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Fecha de creación" ReadOnly="True" />
                            <asp:TemplateField HeaderText="Estado">
                                <ItemTemplate>
                                    <asp:Label ID="lblEstado" runat="server" Text='<%# descripEstadoComanda(Eval("IdEstadoComanda")) %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList ID="ddlEstado" runat="server">
                                    </asp:DropDownList>
                                </EditItemTemplate>
                            </asp:TemplateField>
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
