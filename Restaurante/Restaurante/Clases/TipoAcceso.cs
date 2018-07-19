using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class TipoAcceso
    {
        public int id { get; set; }
        public string departamento { get; set; }

        //Agregar las propediades para definir a los modulos a los que tenra acceso
        public TipoAcceso() { }

        public TipoAcceso(int id, string departamento)
        {
            this.id = id;
            this.departamento = departamento;
        }
        public void ObtenerAreaPorDepartamento( string departamentoRe)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, departamento FROM Acceso.TipoAcceso WHERE departamento = '" + departamentoRe + "'";
            Console.WriteLine(conexion.conexion);
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.id = dr.GetInt32(0);
                    this.departamento = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Agregar()
        {

        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }
        
        public static DataTable GetDataTableDepartamentos()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = "select departamento FROM Acceso.TipoAcceso";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
