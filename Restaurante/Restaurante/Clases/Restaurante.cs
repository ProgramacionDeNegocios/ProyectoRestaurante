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
                decimal cantidad,
                decimal cantidadminima,
                int idtipounidad,
                string descripcion,
                int idproveedor
                )
        {
            if (nombre.Length == 0 || costo < 0 || cantidad < 0 || cantidadminima < 0 || idtipounidad <= 0 || descripcion.Length == 0 || idproveedor <= 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el insumo. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el insumo\n" +
                    "Nombre   : Tomate\n" +
                    "Costo    : 12.00\n" +
                    "Cantidad : 12.00\n" +
                    "Cantidad Minima    : 2.00\n" +
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
            decimal cantidad,
            decimal cantidadminima,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, cantidad, cantidadminima, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    nombre,
                    costo,
                    cantidad,
                    cantidadminima,
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
            decimal cantidad,
            decimal cantidadminima,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, cantidad, cantidadminima, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    id,
                    nombre,
                    costo,
                    cantidad,
                    cantidadminima,
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

        private static void ValidarInventario
                (
                string descripcion,
                decimal costo,
                decimal precioventa,
                decimal cantidad,
                decimal cantidadminima,
                int idcategoria,
                int idtipoproducto,
                int idproveedor
                )
        {
            if (descripcion.Length == 0 || costo < 0 || precioventa < 0 || cantidad < 0 || cantidadminima <0 || idcategoria <0 || idtipoproducto < 0 ||idproveedor < 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el Inventario\n" +
                    "Producto : Pescado Frito\n" +
                    "Costo    : 80.00\n" +
                    "Precio Venta   : 100.00\n" +
                    "Cantidad   : 20\n" +
                    "Cantidad Min   : 10\n" +
                    "Categoria   : Plato\n" +
                    "Tipo Producto : Elaborado\n" +
                    "Proveedor : Don Edgardo",
                    new Exception(),
                    "Clase_Inventario"
                    );
            }
        }
        
        public static void AgregarInventario
            (
            string descripcion,
            decimal costo,
            decimal precioventa,
            decimal cantidad,
            decimal cantidadminima,
            int idcategoria,
            int idtipoproducto,
            int idproveedor
            )
        {
            try
            {
                ValidarInventario(descripcion, costo, precioventa, cantidad, cantidadminima, idcategoria, idtipoproducto, idproveedor);
                Clases.Inventario inventario = new Clases.Inventario(
                    descripcion,
                    costo,
                    precioventa,
                    cantidad,
                    cantidadminima,
                    idcategoria,
                    idtipoproducto,
                    idproveedor);
                inventario.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInventario
            (
            int id,
            string descripcion,
            decimal costo,
            decimal precioventa,
            decimal cantidad,
            decimal cantidadminima,
            int idcategoria,
            int idtipoproducto,
            int idproveedor
            )
        {
            try
            {
                ValidarInventario(descripcion, costo, precioventa, cantidad, cantidadminima, idcategoria, idtipoproducto, idproveedor);
                Clases.Inventario inventario = new Clases.Inventario(
                    id,
                    descripcion,
                    costo,
                    precioventa,
                    cantidad,
                    cantidadminima,
                    idcategoria,
                    idtipoproducto,
                    idproveedor);
                inventario.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarInventario
            (
            int id
            )
        {
            try
            {
                Clases.Inventario inventario = new Clases.Inventario(
                    id);
                inventario.Eliminar();
                               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarTipoProducto
         (
            string nombre

         )
        {
            if (nombre.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar un Tipo de Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un tipo de Producto:\n" +
                    "Nombre   : Elaborado\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarTipoProducto
            (
            string nombre
            )
        {
            try
            {
                ValidarTipoProducto(nombre);
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    nombre
                    );
                tipoproducto.Agregar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarTipoProducto
            (
            int id,
            string nombre
            )
        {
            try
            {
                ValidarTipoProducto(nombre);
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    id,
                    nombre
                    );
                tipoproducto.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarTipoProducto
            (
            int id
            )
        {
            try
            {
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    id
                    );
                tipoproducto.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarCategoriaProducto
         (
            string nombre

         )
        {
            if (nombre.Length == 0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar una Categoria de Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar una Categoria de Producto:\n" +
                    "Nombre   : Bebida\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarCategoriaProducto
            (
            string nombre
            )
        {
            try
            {
                ValidarCategoriaProducto(nombre);
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    nombre
                    );
                categoria.Agregar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarCategoriaProducto
            (
            int id,
            string nombre
            )
        {
            try
            {
                ValidarCategoriaProducto(nombre);
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    id,
                    nombre
                    );
                categoria.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarCategoriaProducto
            (
            int id
            )
        {
            try
            {
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    id
                    );
                categoria.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarInsumoProducto
                (
                int idInsumo,
                int idInventario,
                decimal cantidad
                )
        {
            if (idInsumo <= 0 || idInventario <=0 || cantidad <0)
            {
                throw new Clases.Exepcion
                    (
                    "Error al insertar el insumo del Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el insumo del Producto\n" +
                    "idInsumo  : Tomate\n" +
                    "idInventario   : Pescado\n" +
                    "Cantidad : 4",
                    new Exception(),
                    "Clase_Insumo"
                    );
            }
        }
        public static void AgregarInsumoProducto
            (
            int idInsumo,
            int idInventario,
            decimal cantidad
            )
        {
            try
            {
                ValidarInsumoProducto(idInsumo, idInventario, cantidad);
                Clases.InsumosProductos insumoproducto = new Clases.InsumosProductos(
                    idInsumo,
                    idInventario,
                    cantidad
                    );
                insumoproducto.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInsumoProducto
            (
            int idInsumoProducto,
            int idInsumo,
            int idInventario,
            decimal cantidad
            )
        {
            try
            {
                ValidarInsumoProducto(idInsumo, idInventario, cantidad);
                Clases.InsumosProductos insumoproducto = new Clases.InsumosProductos(
                    idInsumoProducto,
                    idInsumo,
                    idInventario,
                    cantidad
                    );
                insumoproducto.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInsumoProducto
            (
            int idInsumoProducto,
            int idInventario
            )
        {
            try
            {
                Clases.InsumosProductos insumoproducto = new Clases.InsumosProductos(
                    idInsumoProducto,
                    idInventario
                    );
                insumoproducto.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
