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
        public static void ModificarMesero(
            int id,
            string identidad,
            string nombre,
            string apellido) {
            try {
                ValidarMesero(identidad, nombre, apellido);
                Clases.Mesero mesero = new Clases.Mesero(
                    id,
                    identidad,
                    nombre,
                   apellido);
                mesero.Modificar();
            } catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void EliminarMesero(int id) {
            try {
                Clases.Mesero mesero = new Clases.Mesero(id);
                mesero.Eliminar();
            }
            catch (Exception ex) {
                throw ex;
            } }

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
                    "Telefono  :  9898-9678\n" +
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
        /// <summary>
        /// Modulo Usuario
        /// </summary>
        /// 

        private static void ValidarUsuarios
            (
            string nombre,
            string apellido,
            string clave
            )
        {
            if (apellido.Length == 0 || nombre.Length == 0 || clave.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el usuario \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un usuario:\n" +
                    "Nombre   : Pedro\n" +
                    "Apellido  :  Picapiedra\n" +
                    "Clave : yabadabadu",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }
        public static void AgregarUsuario(
            string nombre, 
            string apellido,
            string clave) {
            try
            {
                ValidarUsuarios(nombre, apellido, clave);
                Clases.Usuario usuario = new Clases.Usuario(
                    nombre,
                    apellido,
                    clave,
                    1
                    );
                usuario.Agregar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void ModificarUsuario(
            string usu,
            string nombre,
            string apellido,
            string clave)
        {
            try
            {
                ValidarUsuarios(nombre, apellido, clave);
                Clases.Usuario usuario = new Clases.Usuario(
                    usu,
                    nombre,
                    apellido,
                    clave,
                    1
                    );
                usuario.Modificar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void EliminarUsuario(string usu) {
            try
            {
                Clases.Usuario usuarios = new Clases.Usuario(usu);

            }
            catch (Exception es)
            {

                throw es ;
            }
        }

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
        private static void ValidarInsumo
                (
                string nombre,
                decimal costo,
                int idtipounidad,
                string descripcion,
                int idproveedor
                )
        {
            if (nombre.Length == 0 || costo < 0 || idtipounidad <= 0 || descripcion.Length == 0 || idproveedor <= 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el insumo. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el insumo\n" +
                    "Nombre   : Tomate\n" +
                    "Costo    : 12.00\n" +
                    "Unidad   : Libra\n" +
                    "Descripción   : Comprado Semanalmente\n" +
                    "Proveedor : Don Edgardo",
                    new Exception(),
                    "Clase_Insumo"
                    );
            }
        }
        public static void AgregarInsumo
            (
            string nombre,
            decimal costo,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    nombre,
                    costo,
                    idtipounidad,
                    descripcion,
                    idproveedor
                    );
                insumo.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInsumo
            (
            int id,
            string nombre,
            decimal costo,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    id,
                    nombre,
                    costo,
                    idtipounidad,
                    descripcion,
                    idproveedor)
                    ;
                insumo.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInsumo
            (
            int id
            )
        {
            try
            {
                Clases.Insumos insumo = new Clases.Insumos(
                    id
                    );
                insumo.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
