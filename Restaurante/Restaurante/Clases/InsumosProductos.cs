using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class InsumosProductos
    {
        public int IdInsumoProducto { set; get; }
        public int IdInsumo { set; get; }
        public int IdInventario { set; get; }
        public InsumosProductos() { }
        ~InsumosProductos() { }

        public InsumosProductos(int idinsumo, int idinventario)
        {
            IdInsumo = idinsumo;
            IdInventario = idinventario;
        }

        public InsumosProductos(int idinsumoproducto, int idinsumo, int idinventario)
        {
            IdInsumoProducto = idinsumoproducto;
            IdInsumo = idinsumo;
            IdInventario = idinventario;
        }

        public InsumosProductos(int idinsumoproducto)
        {
            IdInsumoProducto = idinsumoproducto;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = IdInsumo;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInsumo;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumoProducto", SqlDbType.Int));
                cmd.Parameters["idInsumoProducto"].Value = IdInsumoProducto;
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = IdInsumo;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInsumo;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumoProducto", SqlDbType.Int));
                cmd.Parameters["idInsumoProducto"].Value = IdInsumoProducto;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerInsumosProductos(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idInsumoProducto, idInsumo, idInventario FROM Restaurante.InsumosProductos WHERE idInsumoProducto = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdInsumoProducto = dr.GetInt32(0);
                    IdInsumo = dr.GetInt32(1);
                    IdInventario = dr.GetInt32(2);
                }
            }
            catch (Exception ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_InsumosProductos"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = @"SELECT   Restaurante.InsumosProductos.idInsumoProducto    as Código,
                                    Restaurante.InsumosProductos.idInsumo            as Insumo,
                                    Restaurante.InsumosProductos.idInventario        as Producto
                            FROM Restaurante.TipoUnidad";

            //string sql2 = @"SELECT  Restaurante.InsumosProductos.idInsumoProducto    as Código,
            //                        Restaurante.Insumos.nombre                       as Insumo,
            //                        Restaurante.Inventario.descripcion               as Producto                                    
            //                 FROM Restaurante.Inventario
            //                 INNER JOIN Restaurante.InsumosProductos
            //                 ON Restaurante.Inventario.idInventario = Restaurante.InsumosProductos.idInventario
            //                 INNER JOIN Restaurante.Insumos
            //                 ON Restaurante.Insumos.idInsumo = Restaurante.InsumosProductos.idInsumo";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.InsumosProductos");
                DataTable dt = ds.Tables["Restaurante.InsumosProductos"];
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
