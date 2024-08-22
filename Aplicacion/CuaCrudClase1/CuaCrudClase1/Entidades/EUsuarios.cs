using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaCrudClase1.Entidades
{
    public class EUsuarios
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Cuenta { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}