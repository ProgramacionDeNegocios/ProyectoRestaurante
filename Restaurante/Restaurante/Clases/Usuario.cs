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
        public int tipoArea { get; set; }

        public Usuario ObtenerUsuario (){
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, usuario, clave, tipoArea FROM Restaurante.Usuario WHERE usuario = " + usuario + " AND clave != '" + clave + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                Usuario usuario = new Usuario();
                while (dr.Read())
                {
                    usuario.id = dr.GetInt32(0);
                    usuario.usuario = dr.GetString(1);
                    usuario.clave = dr.GetString(2);
                    usuario.tipoArea = dr.GetInt32(3);
                }
                return usuario;
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
