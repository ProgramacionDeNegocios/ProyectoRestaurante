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

        //Modulo proveedor
        private static void ValidarProveedor
    (
    string nombre,
    string telefono,
    string direccion
    )
        {
            if (telefono.Length != 9 || nombre.Length == 0 || direccion.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar un proveedor. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un proveedor:\n" +
                    "Nombre   : Pedro\n" +
                    "Telefono  :  9898-9678"+
                    "Direccion : Piedra dura",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarProveedor(string nombre, string telefono, string direccion)
        {
            try
            {
                ValidarProveedor(nombre, telefono, direccion);
                Clases.Proveedor proveedor = new Clases.Proveedor(
                    nombre,
                    telefono,
                    direccion
                    );
                proveedor.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarProveedor(int id,string nombre, string telefono, string direccion) {
            try
            {
                ValidarProveedor(nombre, telefono, direccion);
                Clases.Proveedor proveedor = new Clases.Proveedor(
                    id,
                    nombre,
                    telefono,
                    direccion);
                proveedor.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }
        public static void EliminarProveedor(int id) {
            try
            {
                Clases.Proveedor proveedor = new Clases.Proveedor(
                    id);
                proveedor.Eliminar();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void AgregarUsuario() { }
        public static void ModificarUsuario() { }
        public static void EliminarUsuario() { }

        //Modulo de Areas
         private static void ValidarArea
         (
            string nombre,
            int numeroMesas
         )
         {
            if ( nombre.Length == 0 || numeroMesas == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar una Area. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar una area:\n" +
                    "Nombre   : Area Familiar\n" +
                    "Número Mesas : 10",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
         }
        public static void AgregarAreas(string nombre, int numeroMesas) {
            try
            {
                ValidarArea(nombre, numeroMesas);
                Clases.Areas area = new Clases.Areas(
                    nombre,
                    numeroMesas
                    );
                area.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarAreas(int id, string nombre, int numeroMesas) {
            try
            {
                ValidarArea(nombre, numeroMesas);
                Clases.Areas area = new Clases.Areas(
                    id,
                    nombre,
                    numeroMesas
                    );
                area.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarAreas(int id) {
            try
            {
                //ValidarArea(id);
                Clases.Areas area = new Clases.Areas(
                    id
                    );
                area.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
