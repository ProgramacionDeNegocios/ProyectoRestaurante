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




--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Acceso.Usuarios
SELECT * FROM Acceso.TipoAcceso
