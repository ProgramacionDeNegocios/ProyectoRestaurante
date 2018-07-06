USE DBRestaurante
GO

CREATE PROCEDURE SP_BuscarUsuario
(
	@usuario NVARCHAR(25)
)
AS
BEGIN
	DECLARE @existe INT
	SELECT @existe = COUNT(Restaurante.Usuarios.usuario) FROM Restaurante.Usuarios WHERE usuario = @usuario;
	RETURN @existe;
END
GO

CREATE PROCEDURE SP_InsertarUsuario
(
	@nombre	NVARCHAR(25),
	@apellido NVARCHAR(25),
	@clave NVARCHAR(20),
	@departamento INT

)
AS
BEGIN
	DECLARE @existe int;
	DECLARE @Usuario nVarchar(26);
	SET @existe = 0;
	IF (@nombre = '' OR @apellido = '')
		BEGIN
			RAISERROR(N'Hay campos abligatorios sin llenar', 16, 1, @nombre, @apellido);
			RETURN 0
		END
	ELSE
		BEGIN
			SET @usuario = UPPER(LEFT(@nombre, 1)) + Utilidad.NombrePropios(@apellido)

			SELECT @existe = COUNT(Acceso.Usuarios.usuario) FROM Acceso.Usuarios WHERE usuario = @usuario;
			IF (@existe > 0)
				BEGIN
					RAISERROR(N'Ya existe un usuario con el nombre  "%s %s"', 16, 1, @nombre, @apellido);
					RETURN 0
				END 	
			ELSE
				BEGIN
					INSERT INTO Acceso.Usuarios(nombre, apellido, usuario, clave, departamento)
						VALUES (	Utilidad.NombrePropios(@nombre),
									Utilidad.NombrePropios(@apellido), 
									@usuario, 
									@clave, 
									@departamento)
					RETURN 1
				END
			
		END
END
GO

CREATE PROCEDURE SP_ModificarUsuario
(
	@usuarioAnterior NVARCHAR(26),
	@nombre	NVARCHAR(25),
	@apellido NVARCHAR(25),
	@clave NVARCHAR(20),
	@departamento INT

)
AS
BEGIN
	DECLARE @existe int;
	DECLARE @Usuario nVarchar(26);
	SET @existe = 0;
	IF (@nombre = '' OR @apellido = '')
		BEGIN
			RAISERROR(N'Hay campos abligatorios sin llenar', 16, 1, @nombre, @apellido);
			RETURN 0
		END
	ELSE
		BEGIN
			SET @usuario = UPPER(LEFT(@nombre, 1)) + Utilidad.NombrePropios(@apellido)

			SELECT @existe = COUNT(Acceso.Usuarios.usuario) FROM Acceso.Usuarios WHERE usuario = @usuarioAnterior;
			IF (@existe = 0)
				BEGIN
					RAISERROR(N'No existe un usuario con el nombre  "%s %s"', 16, 1, @nombre, @apellido);
					RETURN 0
				END 	
			ELSE
				BEGIN
					UPDATE Acceso.Usuarios
						SET 	nombre = Utilidad.NombrePropios(@nombre),
								apellido = Utilidad.NombrePropios(@apellido), 
								usuario =	@usuario, 
								clave =	@clave, 
								departamento = @departamento
							WHERE usuario = @usuarioAnterior;
					RETURN 1
				END
			
		END
END
GO

CREATE PROCEDURE SP_EliminarUsuario
(
	@usuario NVARCHAR(26)

)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

			SELECT @existe = COUNT(Acceso.Usuarios.usuario) FROM Acceso.Usuarios WHERE usuario = @usuario;
			IF (@existe = 0)
				BEGIN
					RAISERROR(N'No existe un usuario con el nombre "', 16, 1);
					RETURN 0
				END 	
			ELSE
				BEGIN
					DELETE FROM Acceso.Usuarios	WHERE usuario = @usuario;
					RETURN 1
				END
			
		
END
GO

EXEC SP_EliminarUsuario  'GGfg'

