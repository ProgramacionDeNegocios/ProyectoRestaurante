using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Restaurante.Clases
{
    class Exepcion: Exception
    {
        
        public Exepcion(string msgError, Exception e, string lugar)
            :base(msgError, e)
        {
            this.Source = lugar;
        }
        public Exepcion(string msgError, Exception e)
            : base(msgError, e)
        {
        }
    }
}
