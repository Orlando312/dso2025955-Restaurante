using CuaCrudClase1.Acceso_a_base_de_datos;
using CuaCrudClase1.Controladoras;
using CuaCrudClase1.Interfaces.Productos;
using System;
using System.Collections.Generic;
using CuaCrudClase1.Entidades;  
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaCrudClase1.Interfaces.InicioSession
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        ControladoraUsuarios cUsuarios = new ControladoraUsuarios();
        EUsuarios EUsuarios = new EUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void IniciarSesion_OnClick(object sender, EventArgs e)
        {
            string usuario = txtCuenta.Text;
            string clave = txtClave.Text;
            bool esValido= cUsuarios.AutenticarUsuario(usuario, clave);
            if (esValido)
            {
                EUsuarios = cUsuarios.ObtenerUsuarioPorCuentaYClave(usuario,clave);
                Session["UsuarioSesion"] = EUsuarios;
            }
            else
            {
            }
        }
        protected void RegistrarUsuario_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("~/Interfaces/Usuario/RegistroUsuario.aspx");
        }
        
        protected void Volver_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("~/Interfaces/Productos/GestionProductos.aspx");
        }

    }
}