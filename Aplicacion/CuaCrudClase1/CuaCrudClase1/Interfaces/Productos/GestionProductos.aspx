<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina maestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="GestionProductos.aspx.cs" Inherits="CuaCrudClase1.Interfaces.Productos.GestionProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
            <h2>Gestión de Productos</h2>
            <div class="form-group">
                <asp:Button runat="server" Text="Registrar Nuevo Producto" OnClick="RegistrarProducto_OnClick" CssClass="btn btn-success" />
            </div>
            <hr />
            <h3>Lista de Productos</h3>
            <asp:GridView runat="server" ID="gvProductos" AutoGenerateColumns="False" CssClass="table table-striped" OnRowCommand="gvProductos_RowCommand">
                <Columns>
                    <asp:BoundField DataField="ProductoID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
                    <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
