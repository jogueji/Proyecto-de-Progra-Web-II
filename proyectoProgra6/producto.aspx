<%@ Page Title="Productos" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="proyectoProgra6.producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        var openFile = function (event) {
            var input = event.target;

            var reader = new FileReader();
            reader.onload = function () {
                var dataURL = reader.result;
                var output = document.getElementById('<%=imgProducto.ClientID%>');
                output.src = dataURL;
            };
            reader.readAsDataURL(input.files[0]);
        };
        function cambioImagen(img) {
            document.getElementById('<%=flImagen.ClientID%>').value = img.scr;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact">
        <div class="section group">
            <div class="col_1_of_3 contact_1_of_3">
                <div class="contact-form">
                    <div>
                        <asp:HiddenField ID="hdIdProducto" runat="server" />
                    </div>
                    <div>
                        <span>
                            <asp:Image Style="width: 70%; height: 70%" ID="imgProducto" runat="server" onchange="cambioImagen(this)"/>
                            <asp:FileUpload ID="flImagen" runat="server" accept="image/*" onchange="openFile(event)"/>
                        </span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este dato es requerido" ControlToValidate="txtNombre" Text="Este dato es requerido" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator></span>
                    </div>
                    <div>
                        <span>
                            <asp:TextBox ID="txtDescripcion" placeholder="Descripción" runat="server" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Este dato es requerido" ControlToValidate="txtDescripcion" Text="Este dato es requerido" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator></span>
                    </div>
                    <p>Precio</p>
                    <div>
                        <span>
                            <asp:TextBox ID="txtPrecio" Text="0" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Este dato es requerido" ControlToValidate="txtPrecio" Text="Este dato es requerido" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator></span>
                        <br />
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" MaximumValue="30000" MinimumValue="1" ControlToValidate="txtPrecio" Display="Dynamic" ForeColor="Red">El precio debe estar entre 1 y 30000 colones</asp:RangeValidator></div>
                    <p>Tipo de Producto</p>
                    <div>
                        <span>
                            <asp:DropDownList ID="ddlTipoProducto" runat="server"></asp:DropDownList>
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
                <h3>Lista de productos</h3>
                <asp:GridView ID="dgvProductos" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" DataKeyNames="IdProducto" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowEditing="dgvProductos_RowEditing" HorizontalAlign="Center" RowStyle-HorizontalAlign="Center">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        <asp:TemplateField HeaderText="Tipo de Producto">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# descripTipoPro(Eval("IdTipoProducto")) %>'></asp:Label>
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
