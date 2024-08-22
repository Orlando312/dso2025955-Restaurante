using CuaCrudClase1.Acceso_a_base_de_datos;
using CuaCrudClase1.Controladoras;
using CuaCrudClase1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaCrudClase1.Interfaces.Productos
{
    public partial class EditarProductos : System.Web.UI.Page
    {
        EProductos eProductos = new EProductos();

        ControladoraProductos cProductos = new ControladoraProductos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["ProductoID"] != null)
                {
                    int productoID = int.Parse(Request.QueryString["ProductoID"]);
                    CargarProducto(productoID);
                }
            }
        }

        private void CargarProducto(int productoID)
        {
            eProductos = cProductos.ObtenerProductoPorId(productoID);
            if (eProductos != null) {
                txtDescripcionProducto.Text = eProductos.Descripcion;
                txtNombreProducto.Text = eProductos.Nombre;
                txtPrecioProducto.Text = (eProductos.Precio).ToString();
            }
        }

        protected void GuardarCambios_OnClick(object sender, EventArgs e)
        {
            cProductos.ActualizarProducto(eProductos);
            Response.Redirect("GestionProductos.aspx");
        }

    }
}