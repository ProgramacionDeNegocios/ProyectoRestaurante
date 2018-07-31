using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Proveedor
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
        public Proveedor() { }
        public Proveedor(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

        public Proveedor(int id, string nombre, string telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
        public Proveedor(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_AgregarProveedor", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("telefono", SqlDbType.NVarChar, 9));
                cmd.Parameters["telefono"].Value = Telefono;
                cmd.Parameters.Add(new SqlParameter("direccion", SqlDbType.NVarChar, 300));
                cmd.Parameters["direccion"].Value = Direccion;
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
            SqlCommand cmd = new SqlCommand("SP_ModificarProveedor", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("telefono", SqlDbType.NVarChar, 9));
                cmd.Parameters["telefono"].Value = this.Telefono;
                cmd.Parameters.Add(new SqlParameter("direccion", SqlDbType.NVarChar, 300));
                cmd.Parameters["direccion"].Value = this.Direccion;
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
            SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = Id;
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

        public void ObtenerProveedor(int id)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idProveedor, nombre, telefono, direccion FROM Restaurante.Proveedores WHERE idProveedor = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Telefono = dr.GetString(2);
                    Direccion = dr.GetString(3);
                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del proveedor", excepcion.Message));
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
            //colocar el nombre del area a la cual pertenece el usuario en el strin de conexion
            string sql = @"SELECT   Restaurante.Proveedores.idProveedor          as Código,
                                    Restaurante.Proveedores.nombre      as Proveedor, 
                                    Restaurante.Proveedores.telefono    as Teléfono,
                                    Restaurante.Proveedores.direccion   as Direccion
                            FROM Restaurante.Proveedores";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Proveedores");
                DataTable dt = ds.Tables["Restaurante.Proveedores"];
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

        public void ObtenerProveedorPorNombre(string nombreProveedor)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT idProveedor, nombre FROM Restaurante.Proveedores WHERE nombre = '" + nombreProveedor + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del proveedor", excepcion.Message));
                ex.Source = "Clase_Usuario";
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }

        }



    }
}
