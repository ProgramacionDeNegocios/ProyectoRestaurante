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
        public Usuario(string nombre, string apellido, string clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
        }

        public Usuario(string usuario, string nombre, string apellido, string clave)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
        }

        public void ObtenerUsuario (string usuarioRe){
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, nombre, apellido, usuario, clave FROM Acceso.Usuarios WHERE usuario = '" + usuarioRe  + "';";
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
                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del usuario", excepcion.Message));
                ex.HelpLink = "OscarToledo.com";
                ex.Source = "Clase_Usuario";
                throw ex;
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

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            //colocar el nombre del area a la cual pertenece el usuario en el strin de conexion
            string sql = @"SELECT   Acceso.Usuarios.id          as Código,
                                    Acceso.Usuarios.nombre      as Nombre, 
                                    Acceso.Usuarios.apellido    as Apellido, 
                                    Acceso.Usuarios.usuario     as Usuario
                            FROM Acceso.Usuarios;";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Acceso.Usuarios");
                DataTable dt = ds.Tables["Acceso.Usuarios"];
                DataView dv = new DataView(dt,
                    "",
                    "Código",
                    DataViewRowState.Unchanged);
                return dv;
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
        public static DataTable GetDataTableUsuarios()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = "select usuario FROM Acceso.Usuarios";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
   
}
