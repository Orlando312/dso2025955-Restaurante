using CuaCrudClase1.Controladoras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CuaCrudClase1.Entidades;

namespace CuaCrudClase1.Interfaces.Usuario
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        ControladoraUsuarios cUsuarios = new ControladoraUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegistrarUsuario_OnClick(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string cuenta = txbCuenta.Text;
            string contraseña = txbClave.Text;
            EUsuarios usuarios = new EUsuarios
            {
                UsuarioID = 0,
                Nombre = nombre,
                Cuenta = cuenta,
                Clave = contraseña,
                FechaActualizacion = DateTime.Now,
                FechaRegistro = DateTime.Now
            };
            cUsuarios.InsertarUsuario(usuarios);
        }
    }
}