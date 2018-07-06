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

        public Usuario(string usuario)
        {
            this.usuario = usuario;
        }
        public Usuario(string nombre, string apellido, string clave, int departamento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.departamento = departamento;
        }

        public Usuario(string usuario, string nombre, string apellido, string clave, int departamento)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.departamento = departamento;
        }

        public void ObtenerUsuario (string usuarioRe){
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, nombre, apellido, usuario, clave, departamento FROM Acceso.Usuarios WHERE usuario = '" + usuarioRe  + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.id = dr.GetInt32(0);
                    this.nombre = dr.GetString(1);
                    this.apellido = dr.GetString(2);
                    this.usuario = dr.GetString(3);
                    this.clave = dr.GetString(4);
                    this.departamento = dr.GetInt32(5);
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
                cmd.Parameters["nombre"].Value = this.nombre;
                cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = this.apellido;
                cmd.Parameters.Add(new SqlParameter("Clave", SqlDbType.NVarChar, 20));
                cmd.Parameters["clave"].Value = this.clave;
                cmd.Parameters.Add(new SqlParameter("Departamento", SqlDbType.Int));
                cmd.Parameters["departamento"].Value = this.departamento;
                cmd.ExecuteNonQuery();

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("UsuarioAnterior", SqlDbType.VarChar, 26));
                cmd.Parameters["usuarioAnterior"].Value = this.usuario;
                cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = this.nombre;
                cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = this.apellido;
                cmd.Parameters.Add(new SqlParameter("Clave", SqlDbType.NVarChar, 20));
                cmd.Parameters["clave"].Value = this.clave;
                cmd.Parameters.Add(new SqlParameter("Departamento", SqlDbType.Int));
                cmd.Parameters["departamento"].Value = this.departamento;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Usuario", SqlDbType.VarChar, 26));
                cmd.Parameters["usuario"].Value = this.usuario;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
   
}
