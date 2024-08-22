using CuaCrudClase1.Acceso_a_base_de_datos;
using System;
using CuaCrudClase1.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CuaCrudClase1.Controladoras
{
    public class ControladoraUsuarios
    {
        private readonly DBQualityEntities _context;
        EUsuarios usuario = new EUsuarios();

        public ControladoraUsuarios()
        {
            _context = new DBQualityEntities();
        }

        public void InsertarUsuario(EUsuarios usuario)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_RegistrarUsuario @Nombre, @Cuenta, @Clave, @Estado",
                new SqlParameter("@Nombre", usuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Cuenta", usuario.Cuenta ?? (object)DBNull.Value),
                new SqlParameter("@Clave", usuario.Clave ?? (object)DBNull.Value),
                new SqlParameter("@Estado", usuario.Estado ?? (object)DBNull.Value)
            );
        }

        public EUsuarios ObtenerUsuarioPorId(int usuarioId)
        {
            var parametro = new SqlParameter("@UsuarioID", usuarioId);

            return _context.Database.SqlQuery<EUsuarios>(
                "EXEC sp_ObtenerUsuarioPorId @UsuarioID", parametro).FirstOrDefault();
        }

        public void ActualizarUsuario(EUsuarios usuario)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_ActualizarUsuario @UsuarioID, @Nombre, @Cuenta, @Clave, @Estado",
                new SqlParameter("@UsuarioID", usuario.UsuarioID),
                new SqlParameter("@Nombre", usuario.Nombre ?? (object)DBNull.Value),
                new SqlParameter("@Cuenta", usuario.Cuenta ?? (object)DBNull.Value),
                new SqlParameter("@Clave", usuario.Clave ?? (object)DBNull.Value),
                new SqlParameter("@Estado", usuario.Estado ?? (object)DBNull.Value)
            );
        }

        public void EliminarUsuario(int usuarioId)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_EliminarUsuario @UsuarioID",
                new SqlParameter("@UsuarioID", usuarioId)
            );
        }

        public List<EUsuarios> ObtenerUsuarios()
        {
            return _context.Database.SqlQuery<EUsuarios>(
                "EXEC sp_ObtenerUsuarios").ToList();
        }

        public void ActualizarEstadoUsuario(int usuarioId, string estado)
        {
            _context.Database.ExecuteSqlCommand(
                "EXEC sp_ActualizarEstadoUsuario @UsuarioID, @Estado",
                new SqlParameter("@UsuarioID", usuarioId),
                new SqlParameter("@Estado", estado ?? (object)DBNull.Value)
            );
        }

        public bool AutenticarUsuario(string cuenta, string clave)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@Cuenta", cuenta),
                new SqlParameter("@Clave", clave)
            };

            var resultado = _context.Database.SqlQuery<int>(
                "EXEC sp_AutenticarUsuario @Cuenta, @Clave", parametros).FirstOrDefault();

            return resultado == 1;
        }

        public int? ObtenerIdUsuario(string cuenta, string clave)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@Cuenta", cuenta),
                new SqlParameter("@Clave", clave)
            };

            var idUsuario = _context.Database.SqlQuery<int>(
                "EXEC sp_ObtenerIdUsuario @Cuenta, @Clave", parametros).FirstOrDefault();

            return idUsuario != default(int) ? idUsuario : (int?)null;
        }
        public EUsuarios ObtenerUsuarioPorCuentaYClave(string cuenta, string clave)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@Cuenta", cuenta),
                new SqlParameter("@Clave", clave)
            };

            return _context.Database.SqlQuery<EUsuarios>(
                "EXEC sp_ObtenerUsuarioPorCuentaYClave @Cuenta, @Clave", parametros).FirstOrDefault();
        }
    }
}