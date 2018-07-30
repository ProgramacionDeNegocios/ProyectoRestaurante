using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class TipoUnidad
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public TipoUnidad() { }
        ~TipoUnidad() { }

        public TipoUnidad(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoUnidad(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public TipoUnidad(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_InsertarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_TipoUnidad");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_TipoUnidad");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = Id;
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

        public void ObtenerTipoUnidad(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idTipoUnidad, descripcion FROM Restaurante.TipoUnidad WHERE idTipoUnidad = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Unidad", ex.Message), ex, "Clase_TipoUnidad"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = @"SELECT   Restaurante.TipoUnidad.idTipoUnidad     as Código,
                                    Restaurante.TipoUnidad.descripcion      as Descripción
                            FROM Restaurante.TipoUnidad";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.TipoUnidad");
                DataTable dt = ds.Tables["Restaurante.TipoUnidad"];
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

        public void ObtenerTipoUnidadPorNombre(string nombreTipoUnidad)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idTipoUnidad, descripcion FROM Restaurante.TipoUnidad WHERE descripcion = '" + nombreTipoUnidad + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Unidad", ex.Message), ex, "Clase_TipoUnidad"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
    }
}
