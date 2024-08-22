<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina maestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EditarProductos.aspx.cs" Inherits="CuaCrudClase1.Interfaces.Productos.EditarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-5">
            <h2>Editar Producto</h2>
            <div class="form-group">
                <asp:Label runat="server" Text="Nombre del Producto"></asp:Label>
                <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Descripción"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescripcionProducto" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Precio"></asp:Label>
                <asp:TextBox runat="server" ID="txtPrecioProducto" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button runat="server" Text="Guardar Cambios" OnClick="GuardarCambios_OnClick" CssClass="btn btn-primary" />
            </div>
        </div>
</asp:Content>
