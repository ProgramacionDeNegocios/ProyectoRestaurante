using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarMesero() { }
        public static void EliminarMesero() { }

        public static void AgregarProveedor() { }
        public static void ModificarProveedor() { }
        public static void EliminarProveedor() { }

        public static void AgregarUsuario() { }
        public static void ModificarUsuario() { }
        public static void EliminarUsuario() { }

        private static void ValidarTipoUnidad
         (
            string descripcion

         )
        {
            if (descripcion.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar un Tipo de Unidad. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un tipo de unidad:\n" +
                    "Descripción   : libras\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarTipoUnidad
            (
            string descripcion
            )
        {
            try
            {
                ValidarTipoUnidad(descripcion);
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                    descripcion
                    );
                tipounidad.Agregar();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarTipoUnidad
            (
            int id,
            string descripcion
            )
        {
            try
            {
                ValidarTipoUnidad(descripcion);
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                    id,
                    descripcion
                    );
                tipounidad.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarTipoUnidad
            (
            int id
            )
        {
            try
            {
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                     id
                     );
                tipounidad.Eliminar();
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
