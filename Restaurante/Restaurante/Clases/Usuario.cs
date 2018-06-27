using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int idArea { get; set; }

        public void ObtenerUsuario (string usuarioRe, string claveRe){
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, usuario, clave, idAcceso FROM Acceso.Usuarios WHERE usuario = '" + usuarioRe + "' AND clave = '" + claveRe + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.id = dr.GetInt32(0);
                    this.usuario = dr.GetString(1);
                    this.clave = dr.GetString(2);
                    this.idArea = dr.GetInt32(3);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

    }
}
