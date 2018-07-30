using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Insumos
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public decimal Costo { set; get; }
        public int IdTipoUnidad { set; get; }
        public string Descripcion { set; get; }
        public int IdProveedor { set; get; }

        ~Insumos() { }

        public Insumos(int id, string nombre, decimal costo, int idtipounidad, string descripcion, int proveedor)
        {
            Id = id;
            Nombre = nombre;
            Costo = costo;
            IdTipoUnidad = idtipounidad;
            Descripcion = descripcion;
            IdProveedor = proveedor;
        }

        public Insumos(string nombre, decimal costo, int idtipounidad, string descripcion, int proveedor)
        {
            Nombre = nombre;
            Costo = costo;
            IdTipoUnidad = idtipounidad;
            Descripcion = descripcion;
            IdProveedor = proveedor;
        }

        public Insumos(int id)
        {
            Id = id;
        }

        public Insumos()
        {

        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal ));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = IdTipoUnidad;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 200));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = IdTipoUnidad;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 200));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = Id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerInsumo(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idInsumo, nombre, costo, idTipoUnidad, descripcion, idProveedor FROM Restaurante.Insumos WHERE idInsumo = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Costo = dr.GetDecimal(2);
                    IdTipoUnidad = dr.GetInt32(3);
                    Descripcion = dr.GetString(4);
                    IdProveedor = dr.GetInt32(5);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Insumo", ex.Message), ex, "Clase_Insumo"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = @"SELECT   Restaurante.Insumos.idInsumo        as Código,
                                    Restaurante.Insumos.nombre          as Insumo,
                                    Restaurante.Insumos.costo           as Costo, 
                                    Restaurante.TipoUnidad.descripcion  as Unidad,
                                    Restaurante.Insumos.descripcion     as Descripción,
                                    Restaurante.Proveedores.nombre      as Proveedor
                            FROM Restaurante.Proveedores
                            INNER JOIN Restaurante.Insumos
                            ON Restaurante.Proveedores.idProveedor = Restaurante.Insumos.idProveedor
                            INNER JOIN Restaurante.TipoUnidad
                            ON Restaurante.TipoUnidad.idTipoUnidad = Restaurante.Insumos.idTipoUnidad";
            //Hacer inner join idtipoUnidad
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Insumos");
                DataTable dt = ds.Tables["Restaurante.Insumos"];
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
