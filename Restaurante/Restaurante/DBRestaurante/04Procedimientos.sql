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

CREATE PROCEDURE SP_InsertarTipoAcceso
(
	@departamento NVARCHAR(20)
	--pendientes los parametros de los modulos 
	--que contendra el sistema
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Acceso.TipoAcceso.departamento) FROM Acceso.TipoAcceso WHERE departamento = @departamento;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un departamento con el nombre  "%s"', 16, 1, @departamento);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(departamento)
				VALUES(	@departamento)
			RETURN 1
		END
END
GO
EXEC SP_InsertarTipoAcceso 'Cocina'
select * from Acceso.TipoAcceso


CREATE PROCEDURE SP_ModificarTipoAcceso
(
	@id INT,
	@departamento VARCHAR(20)
	--pendientes los parametros de los modulos 
	--que contendra el sistema
	
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Acceso.TipoAcceso.id) FROM Acceso.TipoAcceso WHERE id=@id;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el departamento con el id %d', 16, 1, @id);
			RETURN 0
		END 	
	ELSE
		BEGIN
			--ANTES DE REALIZAR LA INSERCION VERIFICAR QUE EL NOMBRE NUEVO DEL
			--DEPARTAMENTO A MODIFICAR NO ESTE EN EL SISTEMA
			UPDATE Acceso.TipoAcceso
				SET 	departamento=@departamento
					WHERE id=@id;
			RETURN 1
		END
END
GO
exec SP_ModificarTipoAcceso 21,'Meseros'
select * from Acceso.TipoAcceso

CREATE PROCEDURE SP_EliminarTipoAcceso
(
	@id INT
)
AS 
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(Acceso.TipoAcceso.id) FROM Acceso.TipoAcceso WHERE id=@id;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el departamento con el id %d"', 16, 1, @id);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Acceso.TipoAcceso WHERE id=@id;
				RETURN 1
			END
END
GO
exec SP_EliminarTipoAcceso 11
select * from Acceso.TipoAcceso


CREATE PROCEDURE SP_AgregarProveedor
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarProveedor
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarProveedor
(
	@idProveedor INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarMesero
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarMesero
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarMesero
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_InsertarArea
(
	@nombre VARCHAR(50)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Areas.nombre) FROM Restaurante.Areas WHERE nombre=@nombre;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe una area con el nombre "%s"', 16, 1,@nombre);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.Areas(nombre)
				VALUES(@nombre)
			RETURN 1
		END
END
GO

exec SP_InsertarArea 'Terraza'
select * from Restaurante.Areas

CREATE PROCEDURE SP_ModificarArea
(
	@id INT,
	@nombre VARCHAR(50)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.Areas.id) FROM Restaurante.Areas WHERE id=@id;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ninguna Area con el id "%d"', 16, 1, @id);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.Areas
				SET 	nombre = @nombre
					WHERE id = @id;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarArea
(
	@id INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.Areas.id) FROM Restaurante.Areas WHERE id=@id;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ninguna Area con el id "%d"', 16, 1, @id);
			RETURN 0
		END 	
	ELSE
		BEGIN
			DELETE FROM Restaurante.Areas	WHERE id = @id;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_AgregarMesa
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarMesa
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarMesa
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarPedido
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarPedido
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarPedido
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarFactura
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
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
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarInventario
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarInsumo
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
				VALUES(	<variable1>, <variable2>,...,<Variable3>)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarInsumo
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE <esquema.tabla>
				SET 	<campos=variables>
					WHERE <condicion>;
			RETURN 1
		END
	
	END
END
GO

CREATE PROCEDURE SP_EliminarInsumo
(
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
				RETURN 1
			END
END
GO
