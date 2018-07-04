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
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int departamento { get; set; }

        public Usuario() { }

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
                    this.departamento = dr.GetInt32(3);
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
        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["Nombre"].Value = this.nombre;
                cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["Apellido"].Value = this.apellido;
                cmd.Parameters.Add(new SqlParameter("Clave", SqlDbType.NVarChar, 20));
                cmd.Parameters["Clave"].Value = this.clave;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
   
}
