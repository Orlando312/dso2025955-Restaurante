using CuaCrudClase1.Acceso_a_base_de_datos;
using CuaCrudClase1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CuaCrudClase1.Controladoras
{
    public class ControladoraProductos
    {
        private readonly DBQualityEntities _context;

        public ControladoraProductos()
        {
            _context = new DBQualityEntities();
        }

        public void InsertarProducto(EProductos producto)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_RegistrarProducto @Nombre, @Descripcion, @Precio, @Estado",
                new SqlParameter("@Nombre", producto.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Descripcion", producto.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@Precio", producto.Precio),
                new SqlParameter("@Estado", producto.Estado ?? (object)DBNull.Value)
            );
        }

        public EProductos ObtenerProductoPorId(int productoId)
        {
            var parametro = new SqlParameter("@ProductoID", productoId);

            return _context.Database.SqlQuery<EProductos>(
                "EXEC sp_ObtenerProductoPorId @ProductoID", parametro).FirstOrDefault();
        }

        public void ActualizarProducto(EProductos producto)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_ActualizarProducto @ProductoID, @Nombre, @Descripcion, @Precio, @Estado",
                new SqlParameter("@ProductoID", producto.ProductoID),
                new SqlParameter("@Nombre", producto.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Descripcion", producto.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@Precio", producto.Precio),
                new SqlParameter("@Estado", producto.Estado ?? (object)DBNull.Value)
            );
        }

        public void EliminarProducto(int productoId)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_EliminarProducto @ProductoID",
                new SqlParameter("@ProductoID", productoId)
            );
        }

        public List<EProductos> ObtenerProductos()
        {
            return _context.Database.SqlQuery<EProductos>(
                "EXEC sp_ObtenerProductos").ToList();
        }

        public void ActualizarEstadoProducto(int productoId, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_ActualizarEstadoProducto @ProductoID, @Estado",
                new SqlParameter("@ProductoID", productoId),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }
    }
}