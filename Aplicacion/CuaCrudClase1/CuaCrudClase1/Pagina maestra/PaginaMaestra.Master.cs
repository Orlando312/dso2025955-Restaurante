using CuaCrudClase1.Acceso_a_base_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaCrudClase1.Pagina_maestra
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios eUsuarios = new Usuarios();
            eUsuarios = Session["UsuarioSesion"] as Usuarios;
            if (eUsuarios!=null)
            {
            lblNombre.Text = eUsuarios.Nombre;
            lblCuenta.Text = eUsuarios.Cuenta;
            lblEstado.Text = eUsuarios.Estado;
            }
        }
        protected void VerProductos_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("~/Interfaces/Productos/GestionProductos.aspx");
        }
        protected void IniciarSesion_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("~/Interfaces/InicioSession/InicioSesion.aspx");
        }

    }
}