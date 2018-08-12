using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class CategoriaProducto
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public CategoriaProducto() { }
        ~CategoriaProducto() { }

        public CategoriaProducto(string descripcion)
        {
            Descripcion = descripcion;
        }

        public CategoriaProducto(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public CategoriaProducto(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_InsertarCategoriaProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarCategoriaProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["decripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarCategoriaProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = Id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerCategoriaProducto(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idCategoria, descripcion FROM Restaurante.CategoriaProducto WHERE idCategoria = '" + id + "';";
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
                   "no podemos obtener la informacion de la Categoría del Producto", ex.Message), ex, "Clase_Categorias"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = @"SELECT   Restaurante.CategoriaProducto.idCategoria     as Código,
                                    Restaurante.CategoriaProducto.descripcion     as Descripción
                            FROM Restaurante.CategoriaProducto";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.CategoriaProducto");
                DataTable dt = ds.Tables["Restaurante.CategoriaProducto"];
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

        public void ObtenerCategoriaProductoPorNombre(string nombreCategoria)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idCategoria, descripcion FROM Restaurante.CategoriaProducto WHERE nombre = '" + nombreCategoria + "';";
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
                   "no podemos obtener la informacion de la Categoria del Producto", ex.Message), ex, "Clase_CategoriaProducto"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

    }
}
