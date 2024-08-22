using CuaCrudClase1.Controladoras;
using CuaCrudClase1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaCrudClase1.Interfaces.Productos
{
    public partial class RegistrarProductos : System.Web.UI.Page
    {
        ControladoraProductos cProductos = new ControladoraProductos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void RegistrarProducto_OnClick(object sender, EventArgs e)
        {
            EProductos eProductos = new EProductos
            {
                Nombre = txtNombreProducto.Text,
                Descripcion = txtDescripcionProducto.Text,
                Precio = decimal.Parse(txtPrecioProducto.Text),
                FechaActualizacion = DateTime.Now,
                FechaRegistro = DateTime.Now,
                Estado = "Activo"
            };
            cProductos.InsertarProducto(eProductos);
        }
    }
}