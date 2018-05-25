using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class Conexion
    {
        // Creamos el string de conexion.
        public SqlConnection conn = new SqlConnection(@"server = (local)\SQLEXPRESS;
                integrated security = true; database = DBRestaurante;");

        //Creamos el metodo para abrir la conecion con la base de datos
        public void Abrir()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        //Creamos el metodo para cerrar la conexion con la base de datos.
        public void Cerrar()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
