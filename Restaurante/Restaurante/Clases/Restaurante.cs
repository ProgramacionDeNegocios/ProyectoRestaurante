using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Clases
{
    class Restaurante
    {
        public Restaurante() { }

        private static void ValidarMesero
            (
            string identidad,
            string nombre,
            string apellido
            )
        {
            if (identidad.Length != 15 || nombre.Length == 0 || apellido.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el mesero. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar a el mesero:\n" +
                    "Identidad: 1234-1234-12345\n" +
                    "Nombre   : Pedro\n" +
                    "Apellido : Picapiedra",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }
        public static void AgregarMesero
            (
            string identidad,
            string nombre,
            string apellido
            )
        {
            try
            {
                ValidarMesero(identidad, nombre, apellido);
                    Clases.Mesero mesero = new Clases.Mesero(
                        identidad,
                        nombre,
                        apellido
                        );
                    mesero.Agregar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarMesero() { }
        public static void EliminarMesero() { }

        public static void AgregarProveedor() {  }
        public static void ModificarProveedor() { }
        public static void EliminarProveedor() { }

        public static void AgregarUsuario() { }
        public static void ModificarUsuario() { }
        public static void EliminarUsuario() { }
    }
}
