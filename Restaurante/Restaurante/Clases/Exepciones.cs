using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Restaurante.Clases
{
    class Exepciones: Exception
    {
        public Exepciones(string msgError, Exception e)
            :base(msgError, e)
        {
            this.HelpLink = "http://msdn.microsoft.com";
            this.Source = "Clase_Conexion";
        }
    }
}
