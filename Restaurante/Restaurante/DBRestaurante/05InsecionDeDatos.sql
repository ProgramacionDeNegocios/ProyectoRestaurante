USE DBRestaurante
GO

--SP_InsertarUsuario(nombre, apellido, usuario, clave, tipoArea)
EXEC SP_InsertarUsuario 'oscar','toledo','','',1


--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Restaurante.Usuarios
SELECT * FROM Restaurante.Areas
