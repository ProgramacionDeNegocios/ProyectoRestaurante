using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class TipoAcceso
    {
        public int id { get; set; }
        public string departamento { get; set; }
        
        public void ObtenerPorDepartamento( string departamentoRe)
        {
            Conexion conexion = new Conexion();
            string sql = @"SELECT id, departamento FROM Acceso.TipoAcceso WHERE departamento = '" + departamentoRe + "'";
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
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
