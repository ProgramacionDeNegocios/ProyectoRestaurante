using System;


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
