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
CREATE PROCEDURE SP_AgregarTipoAcceso
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarTipoAcceso
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarTipoAcceso
(
)
AS 
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarProveedor
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarProveedor
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarProveedor
(
	@idProveedor INT
)
AS
BEGIN
	DELETE FROM Restaurante.Proveedores WHERE idProveedor = @idProveedor;
END
GO

CREATE PROCEDURE SP_AgregarMesero
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarMesero
(
)
AS
BEGIN 
END
GO

CREATE PROCEDURE SP_EliminarMesero
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarArea
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarArea
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarArea
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarMesa
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarMesa
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarMesa
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarPedido
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarPedido
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarPedido
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarFactura
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarInventario
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarInventario
(
)
AS 
BEGIN 
END
GO

CREATE PROCEDURE SP_EliminarInventario
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_AgregarInsumo
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_ModificarInsumo
(
)
AS
BEGIN
END
GO

CREATE PROCEDURE SP_EliminarInsumo
(
)
AS
BEGIN
END
GO
