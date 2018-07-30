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
        public string Identidad { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public Mesero() { }
        ~Mesero() { }
        public Mesero(string identidad, string nombre, string apellido)
        {
            Identidad = identidad;
            Nombre = nombre;
            Apellido = apellido;

        }

        public Mesero(int id, string identidad, string nombre, string apellido)
        {
            Id = id;
            Identidad = identidad;
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
                cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.NVarChar, 15));
                cmd.Parameters["identidad"].Value = Identidad;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = Apellido;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Mesero");
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
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.NVarChar, 15));
                cmd.Parameters["identidad"].Value = Identidad;
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
            string sql = @"SELECT id, identidad, nombre, apellido FROM Restaurante.Meseros WHERE id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Identidad = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    Apellido = dr.GetString(3);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Mesero", ex.Message), ex, "Clase_Meseros"); ;
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
            string sql = @"SELECT   Restaurante.Meseros.id          as Código,
                                    Restaurante.Meseros.identidad   as Identidad,
                                    Restaurante.Meseros.nombre      as Mesero, 
                                    Restaurante.Meseros.apellido    as Apellido
                            FROM Restaurante.Meseros";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Meseros");
                DataTable dt = ds.Tables["Restaurante.Meseros"];
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
