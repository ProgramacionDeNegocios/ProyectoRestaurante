using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Areas
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int NumeroMesas { set; get; }
        public Areas() { }
        ~Areas() { }
        public Areas(string nombre, int numeroMesas)
        {
            Nombre = nombre;
            NumeroMesas = numeroMesas;
        }

        public Areas(int id, string nombre, int numeroMesas)
        {
            Id = id;
            Nombre = nombre;
            NumeroMesas = numeroMesas;
        }
        public Areas(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_InsertarArea", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 50));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("numeroMesas", SqlDbType.TinyInt));
                cmd.Parameters["numeroMesas"].Value = NumeroMesas;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Areas");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarArea", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 50));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("numeroMesas", SqlDbType.TinyInt));
                cmd.Parameters["numeroMesas"].Value = NumeroMesas;
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
            SqlCommand cmd = new SqlCommand("SP_EliminarArea", conexion.conexion);
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

        public void ObtenerAreas(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, nombre, numeroMesas  FROM Restaurante.Areas WHERE id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt16(0);
                    Nombre = dr.GetString(1);
                    NumeroMesas = dr.GetInt16(2);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Areas", ex.Message), ex, "Clase_Areas"); ;
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
            string sql = @"SELECT   Restaurante.Areas.id          as Código,
                                    Restaurante.Areas.nombre      as Areas, 
                                    Restaurante.Areas.numeroMesas   as Número Mesas
                            FROM Restaurante.Areas";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Areas");
                DataTable dt = ds.Tables["Restaurante.Areas"];
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
