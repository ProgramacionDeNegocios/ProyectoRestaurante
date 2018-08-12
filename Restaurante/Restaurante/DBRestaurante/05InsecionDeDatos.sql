USE DBRestaurante
GO
--hacer store procedure para la incersion de areas
insert into Acceso.Roles
	(
		nombreRol, 
		agregarUsuario, modificarUsuario, eliminarUsuario
		)
	VALUES
		(	'Administrador',
			1, 1, 1
			);


--SP_InsertarUsuario(nombre, apellido, usuario, clave, tipoArea)
EXEC SP_InsertarUsuario 'oscar','toledo','ninguna', 1

--SP_Proveedor()
EXEC SP_AgregarProveedor 'Pedro','9889-8987','Siguatepeque'

--SP_InsertarTipoUnidad
EXEC SP_InsertarTipoUnidad 'Onza'

--SP_InsertarTipoProducto
EXEC SP_InsertarTipoProducto 'Elaborado'

--SP_InsertarCategoriaProducto
EXEC SP_InsertarCategoriaProducto 'Bebida'

--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Acceso.Usuarios
SELECT * FROM Acceso.TipoAcceso
