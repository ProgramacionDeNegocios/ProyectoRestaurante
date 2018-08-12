USE DBRestaurante
GO


--sin terminar
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
	@idRol INT
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
					INSERT INTO Acceso.Usuarios(nombre, apellido, usuario, clave, idRol)
						VALUES (	Utilidad.NombrePropios(@nombre),
									Utilidad.NombrePropios(@apellido), 
									@usuario, 
									@clave, 
									@idRol)
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
	@idRol INT

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
								idRol = @idRol
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

CREATE PROCEDURE SP_AgregarProveedor
(
	@nombre NVARCHAR(100),
	@telefono NVARCHAR(9),
	@direccion NVARCHAR(300)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Proveedores.idProveedor) FROM Restaurante.Proveedores WHERE nombre = @nombre;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un proveedor con el nombre  "%s"', 16, 1, @nombre);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.Proveedores(nombre, telefono, direccion)
				VALUES(@nombre, @telefono, @direccion)
			RETURN 1
		END
END
GO



CREATE PROCEDURE SP_ModificarProveedor
(
	@idProveedor INT,
	@nombre NVARCHAR(100),
	@telefono NVARCHAR(9),
	@direccion NVARCHAR(300)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Proveedores.idProveedor) FROM Restaurante.Proveedores WHERE idProveedor = @idProveedor;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el proveedor con el id %d"', 16, 1, @idProveedor);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.Proveedores
				SET 	nombre = @nombre,
						telefono = @telefono,
						direccion = @direccion
					WHERE idProveedor = @idProveedor;
			RETURN 1
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
		SELECT @existe = COUNT(Restaurante.Proveedores.idProveedor) FROM Restaurante.Proveedores WHERE idProveedor = @idProveedor;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el proveedor con el id %d"', 16, 1, @idProveedor);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Restaurante.Proveedores	WHERE idProveedor = @idProveedor;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarMesero
(
	@identidad NVARCHAR(15),
	@nombre NVARCHAR(25),
	@apellido NVARCHAR(25)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Meseros.identidad) FROM Restaurante.Meseros WHERE identidad = @identidad;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe Un mesero con la identidad %s"', 16, 1, @identidad);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.Meseros(identidad, nombre, apellido)
				VALUES(	@identidad, @nombre, @apellido)
			RETURN 1
		END
END
GO


CREATE PROCEDURE SP_ModificarMesero
(
	@id INT,
	@identidad NVARCHAR(25),
	@nombre NVARCHAR(25),
	@apellido NVARCHAR(25)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Meseros.identidad) FROM Restaurante.Meseros WHERE identidad=@id;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el mesero con la identidad %s"', 16, 1, @identidad);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.Meseros
				SET 	
						identidad = @identidad,
						nombre = @nombre,
						apellido = @apellido
					WHERE id = @id;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarMesero
(
	@id INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
			SELECT @existe = COUNT(Restaurante.Meseros.id) FROM Restaurante.Meseros WHERE id=@id;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el mesero con el id %d"', 16, 1, @id);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Restaurante.Meseros	WHERE id=@id;
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

--CREATE PROCEDURE SP_AgregarMesa
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;

--	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
--	IF (@existe > 0)
--		BEGIN
--			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
--			RETURN 0
			
--		END
--	ELSE
--		BEGIN
--			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
--				VALUES(	<variable1>, <variable2>,...,<Variable3>)
--			RETURN 1
--		END
--END
--GO

--CREATE PROCEDURE SP_ModificarMesa
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;

--	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

--	IF (@existe = 0)
--		BEGIN
--			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
--			RETURN 0
--		END 	
--	ELSE
--		BEGIN
--			UPDATE <esquema.tabla>
--				SET 	<campos=variables>
--					WHERE <condicion>;
--			RETURN 1
--		END
	
--	END
--END
--GO

--CREATE PROCEDURE SP_EliminarMesa
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;
--		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
--		IF (@existe = 0)
--			BEGIN
--				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
--				RETURN 0
--			END 	
--		ELSE
--			BEGIN
--				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
--				RETURN 1
--			END
--END
--GO

--CREATE PROCEDURE SP_AgregarPedido
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;

--	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
--	IF (@existe > 0)
--		BEGIN
--			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
--			RETURN 0
			
--		END
--	ELSE
--		BEGIN
--			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
--				VALUES(	<variable1>, <variable2>,...,<Variable3>)
--			RETURN 1
--		END
--END
--GO

--CREATE PROCEDURE SP_ModificarPedido
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;

--	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;

--	IF (@existe = 0)
--		BEGIN
--			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
--			RETURN 0
--		END 	
--	ELSE
--		BEGIN
--			UPDATE <esquema.tabla>
--				SET 	<campos=variables>
--					WHERE <condicion>;
--			RETURN 1
--		END
	
--	END
--END
--GO

--CREATE PROCEDURE SP_EliminarPedido
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;
--		SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
--		IF (@existe = 0)
--			BEGIN
--				RAISERROR(N'aqui va el mensaje de error "', 16, 1);
--				RETURN 0
--			END 	
--		ELSE
--			BEGIN
--				DELETE FROM <Esquema.tabla>	WHERE <condicion>;
--				RETURN 1
--			END
--END
--GO

--CREATE PROCEDURE SP_AgregarFactura
--(
--)
--AS
--BEGIN
--	DECLARE @existe int;
--	SET @existe = 0;

--	SELECT @existe = COUNT(<esquema.tabla.campo>) FROM <Esquema.tabla> WHERE <condicion>;
--	IF (@existe > 0)
--		BEGIN
--			RAISERROR(N'Aqui va el mensaje de error"', 16, 1);
--			RETURN 0
			
--		END
--	ELSE
--		BEGIN
--			INSERT INTO Acceso.TipoAcceso(<campo1>, <campo2>,.... ,<campoN>)
--				VALUES(	<variable1>, <variable2>,...,<Variable3>)
--			RETURN 1
--		END
--END
--GO

CREATE PROCEDURE SP_AgregarInventario
(
	@descripcion NVARCHAR(100),
	@costo DECIMAL(8,2),
	@precioVenta DECIMAL(8,2),
	@cantidad DECIMAL(8,2),
	@idTipoProducto INT,
	@idProveedor INT

)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Inventario.idInventario) FROM Restaurante.Inventario WHERE descripcion = @descripcion;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un Insumo con el nombre %s"', 16, 1,@descripcion);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.Inventario(descripcion, costo, precioVenta, cantidad, idTipoProducto, idProveedor)
				VALUES(@descripcion, @costo, @precioVenta, @cantidad, @idTipoProducto, @idProveedor)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarInventario
(
	@idInventario INT,
	@descripcion NVARCHAR(100),
	@costo DECIMAL(8,2),
	@precioVenta DECIMAL(8,2),
	@cantidad DECIMAL(8,2),
	@idTipoProducto INT,
	@idProveedor INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Inventario.idInventario) FROM Restaurante.Inventario WHERE idInventario = @idInventario;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el Producto con el id %d"', 16, 1, @idInventario);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.Inventario
				SET 	descripcion = @descripcion,
						costo = @costo,
						precioVenta = @precioVenta,
						cantidad = @cantidad,
						idTipoProducto = @idTipoProducto,
						idProveedor = @idProveedor
					WHERE idInventario = @idInventario;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarInventario
(
	@idInventario INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(Restaurante.Inventario.idInventario) FROM Restaurante.Inventario WHERE idInventario = @idInventario;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el Producto con el id %d"', 16, 1, @idInventario);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Restaurante.Inventario WHERE idInventario = @idInventario;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_AgregarInsumo
(
	@nombre NVARCHAR(100),
	@costo DECIMAL(8,2),
	@idTipoUnidad INT,
	@descripcion NVARCHAR(200),
	@idProveedor INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Insumos.idInsumo) FROM Restaurante.Insumos WHERE nombre = @nombre;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un Insumo con el nombre %s"', 16, 1,@nombre);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.Insumos(nombre, costo, idTipoUnidad, descripcion, idProveedor)
				VALUES(@nombre, @costo, @idTipoUnidad, @descripcion, @idProveedor)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarInsumo
(
	@idInsumo INT,
	@nombre NVARCHAR(100),
	@costo DECIMAL(8,2),
	@idTipoUnidad INT,
	@descripcion NVARCHAR(200),
	@idProveedor INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.Insumos.IdInsumo) FROM Restaurante.Insumos WHERE IdInsumo = @idInsumo;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el insumo con el id %d"', 16, 1, @idInsumo);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.Insumos
				SET 	nombre = @nombre,
						costo = @costo,
						idTipoUnidad = @idTipoUnidad,
						descripcion = @descripcion,
						idProveedor = @idProveedor
					WHERE idInsumo = @idInsumo;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarInsumo
(
	@idInsumo INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(Restaurante.Insumos.IdInsumo) FROM Restaurante.Insumos WHERE IdInsumo = @idInsumo;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el insumo con el id %d"', 16, 1, @idInsumo);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Restaurante.Insumos WHERE idInsumo = @idInsumo;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_InsertarTipoUnidad
(
	@descripcion NVARCHAR(100)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.TipoUnidad.idTipoUnidad) FROM Restaurante.TipoUnidad WHERE descripcion=@descripcion;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un Tipo de Unidad con el nombre "%s"', 16, 1,@descripcion);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.TipoUnidad(descripcion)
				VALUES(@descripcion)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarTipoUnidad
(
	@idTipoUnidad INT,
	@descripcion NVARCHAR(100)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.TipoUnidad.idTipoUnidad) FROM Restaurante.TipoUnidad WHERE idTipoUnidad=@idTipoUnidad;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ningún Tipo de Unidad con el id "%d"', 16, 1, @idTipoUnidad);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.TipoUnidad
				SET 	descripcion = @descripcion
					WHERE idTipoUnidad = @idTipoUnidad;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarTipoUnidad
(
	@idTipoUnidad INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.TipoUnidad.idTipoUnidad) FROM Restaurante.TipoUnidad WHERE idTipoUnidad=@idTipoUnidad;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ningún Tipo de Unidad con el id "%d"', 16, 1, @idTipoUnidad);
			RETURN 0
		END 	
	ELSE
		BEGIN
			DELETE FROM Restaurante.TipoUnidad	WHERE idTipoUnidad = @idTipoUnidad;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_AgregarInsumosProductos
(
	@idInsumo INT,
	@idInventario INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.InsumosProductos.idInsumoProducto) FROM Restaurante.InsumosProductos WHERE idInsumo = @idInsumo AND idInventario = @idInventario;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe ese Insumo', 16, 1);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.InsumosProductos(idInsumo, idInventario)
				VALUES(@idInsumo, @idInventario)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarInsumosProductos
(
	@idInsumoProducto INT,
	@idInsumo INT,
	@idInventario INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.InsumosProductos.idInsumoProducto) FROM Restaurante.InsumosProductos WHERE idInsumoProducto = @idInsumoProducto;

	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe el insumo en el producto con el id %d"', 16, 1, @idInsumoProducto);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.InsumosProductos
				SET 	idInsumo = @idInsumo,
						idInventario = @idInventario
					WHERE idInsumoProducto = @idInsumoProducto;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarInsumosProductos
(
	@idInsumoProducto INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
		SELECT @existe = COUNT(Restaurante.InsumosProductos.idInsumoProducto) FROM Restaurante.InsumosProductos WHERE idInsumoProducto = @idInsumoProducto;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe el insumo con el id %d"', 16, 1, @idInsumoProducto);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Restaurante.InsumosProductos WHERE idInsumoProducto = @idInsumoProducto;
				RETURN 1
			END
END
GO

CREATE PROCEDURE SP_InsertarTipoProducto
(
	@nombre NVARCHAR(100)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;

	SELECT @existe = COUNT(Restaurante.TipoProducto.idTipoProducto) FROM Restaurante.TipoProducto WHERE nombre=@nombre;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un Tipo de Producto con el nombre "%s"', 16, 1,@nombre);
			RETURN 0
			
		END
	ELSE
		BEGIN
			INSERT INTO Restaurante.TipoProducto(nombre)
				VALUES(@nombre)
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_ModificarTipoProducto
(
	@idTipoProducto INT,
	@nombre NVARCHAR(100)
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.TipoProducto.idTipoProducto) FROM Restaurante.TipoProducto WHERE idTipoProducto=@idTipoProducto;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ningún Tipo de Producto con el id "%d"', 16, 1, @idTipoProducto);
			RETURN 0
		END 	
	ELSE
		BEGIN
			UPDATE Restaurante.TipoProducto
				SET 	nombre = @nombre
					WHERE idTipoProducto = @idTipoProducto;
			RETURN 1
		END
END
GO

CREATE PROCEDURE SP_EliminarTipoProducto
(
	@idTipoProducto INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
	SELECT @existe = COUNT(Restaurante.TipoProducto.idTipoProducto) FROM Restaurante.TipoProducto WHERE idTipoProducto=@idTipoProducto;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ningún Tipo de Producto con el id "%d"', 16, 1, @idTipoProducto);
			RETURN 0
		END 	
	ELSE
		BEGIN
			DELETE FROM Restaurante.TipoProducto WHERE idTipoProducto = @idTipoProducto;
			RETURN 1
		END
END
GO
