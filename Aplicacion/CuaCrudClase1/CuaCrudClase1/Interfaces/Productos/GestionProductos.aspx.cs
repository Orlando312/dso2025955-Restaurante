using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaCrudClase1.Controladoras;
using CuaCrudClase1.Acceso_a_base_de_datos;
using CuaCrudClase1.Entidades;

namespace CuaCrudClase1.Interfaces.Productos
{
    public partial class GestionProductos : System.Web.UI.Page
    {
        ControladoraProductos CProductos= new ControladoraProductos();
        ControladoraUsuarios CUsuarios = new ControladoraUsuarios();
        Usuarios Usuarios = new Usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            List<EProductos> productos = CProductos.ObtenerProductos();
            gvProductos.DataSource = productos;
            gvProductos.DataBind();
        }

        protected void gvProductos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvProductos.Rows[index];
                int productoID = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect($"EditarProductos.aspx?ProductoID={productoID}");
            }
        }

        protected void RegistrarProducto_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarProductos.aspx");
        }
    }
}

