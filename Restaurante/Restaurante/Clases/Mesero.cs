using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Mesero
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public Mesero() { }
        public Mesero(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

        }

        public Mesero(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Mesero(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = Apellido;
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

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = Apellido;
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
            SqlCommand cmd = new SqlCommand("SP_EliminarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = Id;
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

        public void ObtenerMesero(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, nombre, apellido FROM Restaurante.Meseroes WHERE id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Apellido = dr.GetString(2);

                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Mesero", excepcion.Message));
                ex.HelpLink = "OscarToledo.com";
                ex.Source = "Clase_Usuario";
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
            //colocar el nombre del area a la cual pertenece el usuario en el string de conexion
            string sql = @"SELECT   Restaurante.Mesero.id          as Código,
                                    Restaurante.Mesero.nombre      as Mesero, 
                                    Restaurante.Mesero.apellido    as Apellido
                            FROM Restaurante.Mesero";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Mesero");
                DataTable dt = ds.Tables["Restaurante.Mesero"];
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
    }
}
