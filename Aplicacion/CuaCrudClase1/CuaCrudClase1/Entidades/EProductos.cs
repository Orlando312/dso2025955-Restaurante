using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaCrudClase1.Entidades
{
    public class EProductos
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}