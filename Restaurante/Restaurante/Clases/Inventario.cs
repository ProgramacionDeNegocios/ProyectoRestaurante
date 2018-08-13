using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restaurante.Clases
{
    class Inventario
    {
        public int IdInventario { set; get; }
        public string Descripcion { set; get; }
        public decimal Costo { set; get; }
        public decimal PrecioVenta { set; get; }
        public decimal Cantidad { set; get; }
        public decimal CantidadMinima { set; get; }
        public int IdCategoria { set; get; }
        public int IdTipoProducto { set; get; }
        public int IdProveedor { set; get; }

        public Inventario() { }

        public Inventario(string descripcion, decimal costo, decimal precioventa, decimal cantidad, decimal cantidadminima, int categoria, int idtipoproducto, int idproveedor)
        {
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioventa;
            Cantidad = cantidad;
            CantidadMinima = cantidadminima;
            IdCategoria = categoria;
            IdTipoProducto = idtipoproducto;
            IdProveedor = idproveedor;
        }

        public Inventario(int idinventario, string descripcion, decimal costo, decimal precioventa, decimal cantidad, decimal cantidadminima, int categoria, int idtipoproducto, int idproveedor)
        {
            IdInventario = idinventario;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioventa;
            Cantidad = cantidad;
            CantidadMinima = cantidadminima;
            IdCategoria = categoria;
            IdTipoProducto = idtipoproducto;
            IdProveedor = idproveedor;
        }

        public Inventario(int id)
        {
            IdInventario = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarInventario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("precioVenta", SqlDbType.Decimal));
                cmd.Parameters["precioVenta"].Value = PrecioVenta;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Decimal));
                cmd.Parameters["cantidadMinima"].Value = CantidadMinima;
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = IdCategoria;
                cmd.Parameters.Add(new SqlParameter("idTipoProducto", SqlDbType.Int));
                cmd.Parameters["idTipoProducto"].Value = IdTipoProducto;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;
                MessageBox.Show("hata aui esta bueno");
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Inventario");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarInventario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("precioVenta", SqlDbType.Decimal));
                cmd.Parameters["precioVenta"].Value = PrecioVenta;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Decimal));
                cmd.Parameters["cantidadMinima"].Value = CantidadMinima;
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = IdCategoria;
                cmd.Parameters.Add(new SqlParameter("idTipoProducto", SqlDbType.Int));
                cmd.Parameters["idTipoProducto"].Value = IdTipoProducto;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Inventario");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_EliminarInventario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Inventario");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerInventario(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idInventario, descripcion, costo, precioVenta, cantidad, cantidadMinima, idCategoria, idTipoProducto, idProveedor FROM Restaurante.Inventario WHERE idInventario = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdInventario = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                    Costo = dr.GetDecimal(2);
                    PrecioVenta = dr.GetDecimal(3);
                    Cantidad = dr.GetDecimal(4);
                    CantidadMinima = dr.GetDecimal(5);
                    IdCategoria = dr.GetInt32(6);
                    IdTipoProducto = dr.GetInt32(7);
                    IdProveedor = dr.GetInt32(8);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_Inventario"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public void ObtenerIdInventario(string descripcion)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idInventario FROM Restaurante.Inventario WHERE descripcion = '" + descripcion + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdInventario = dr.GetInt32(0);
  
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener el id del Producto", ex.Message), ex, "Clase_Inventario"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = @"SELECT   Restaurante.Inventario.idInventario         as Código,
                                    Restaurante.Inventario.descripcion          as Nombre,
                                    Restaurante.Inventario.costo                as Costo,
                                    Restaurante.Inventario.precioVenta          as PrecioVenta,
                                    Restaurante.Inventario.cantidad             as Cantidad,
                                    Restaurante.Inventario.cantidadMinima       as CantidadMin,
                                    Restaurante.CategoriaProducto.descripcion   as Categoría,
                                    Restaurante.TipoProducto.nombre             as TipoProducto,
                                    Restaurante.Proveedores.nombre              as Proveedor
                            FROM Restaurante.Proveedores
                            INNER JOIN Restaurante.Inventario
                            ON Restaurante.Proveedores.idProveedor = Restaurante.Inventario.idProveedor
                            INNER JOIN Restaurante.TipoProducto
                            ON Restaurante.TipoProducto.idTipoProducto = Restaurante.Inventario.idTipoProducto
                            INNER JOIN Restaurante.CategoriaProducto
                            ON Restaurante.CategoriaProducto.idCategoria = Restaurante.Inventario.idCategoria";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Inventario");
                DataTable dt = ds.Tables["Restaurante.Inventario"];
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
