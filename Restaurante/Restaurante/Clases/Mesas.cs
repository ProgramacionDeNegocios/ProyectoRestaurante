using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Mesas
    {
        public int Id { set; get; }
        public int IdArea { set; get; }
        public string Estado { set; get; }
        public Mesas() { }
        ~Mesas() { }
        public Mesas(int idArea, string estado)
        {
            IdArea = idArea;
            Estado = estado;
        }

        public Mesas(int id, int idArea, string estado)
        {
            Id = id;
            IdArea = idArea;
            Estado = estado;
        }
        public Mesas(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_InsertarMesa", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idArea", SqlDbType.NVarChar, 21));
                cmd.Parameters["idArea"].Value = IdArea;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.TinyInt));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Exepcion(ex.Message, ex, "Clase_Mesas");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexion conexion = new Clases.Conexion();
            SqlCommand cmd = new SqlCommand("SP_ModificarMesa", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("idArea", SqlDbType.NVarChar, 21));
                cmd.Parameters["idArea"].Value = IdArea;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.TinyInt));
                cmd.Parameters["estado"].Value = Estado;
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
    }
}
