<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="proyectoProgra6.usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="section group">
            <div class="col_1_of_3 contact_1_of_3">
                <div class="contact-form">
                     <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                <strong id="textoMensajeError" runat="server"></strong>
                            </div>
                    <div>
                        <asp:HiddenField ID="hdIdUsuario" runat="server" />
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtNombreUsuario" placeholder="Nombre de usuario" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtNombreUsuario" ForeColor="Red">Este dato es requerido</asp:RequiredFieldValidator> </span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtContrasenna" placeholder="Contraseña" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtContrasenna" ForeColor="Red">Este dato es requerido</asp:RequiredFieldValidator></span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtNombre" ForeColor="Red">Este dato es requerido</asp:RequiredFieldValidator></span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtApellidos" placeholder="Apellidos" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtApellidos" ForeColor="Red">Este dato es requerido</asp:RequiredFieldValidator></span>
                    </div>
                    <p>Tipo de Usuario</p>
                    <div>
                        <span>
                            <asp:DropDownList ID="ddlTipoUsuario" runat="server"></asp:DropDownList>
                        </span>
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
                <h3>Lista de Usuarios</h3>
                <asp:GridView ID="dgvUsuarios" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" DataKeyNames="IdUsuario" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowEditing="dgvUsuarios_RowEditing" HorizontalAlign="Center" RowStyle-HorizontalAlign="Center">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre de Usuario" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                        <asp:TemplateField HeaderText="Tipo de Usuario">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# descripTipoUsu(Eval("IdTipoUsuario")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CheckBoxField DataField="Estado" HeaderText="Estado" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
