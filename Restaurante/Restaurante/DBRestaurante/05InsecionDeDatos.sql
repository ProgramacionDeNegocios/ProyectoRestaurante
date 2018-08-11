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
EXEC SP_InsertarUsuario 'eduardo','calix','nose', 1
EXEC SP_InsertarUsuario 'sonia','villeda','ninguna', 1


-- Ejecutar el SP de inserción con datos Incorrectos
EXEC Facturacion.SPFacturas '1006-1962-48813';
-- Ejecutar el SP de inserción con datos correctos
EXEC Facturacion.SPFacturas '1006-1962-48813',1002;


--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Acceso.Usuarios
SELECT * FROM Acceso.TipoAcceso
