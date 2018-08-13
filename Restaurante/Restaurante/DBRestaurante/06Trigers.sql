USE DBRestaurante
GO

-- Trigger que verifica el formato del codigo de articulo y dependiendo de ello, manda el articulo al tipo al que pertenece. --
-- Trigger que verifica si un articulo esta excento de impuesto. --
-- Trigger que resta la cantidad comprada al stock de un articulo y verifica que ese stock restante no sea menor a la cantida minima.
ALTER TRIGGER Facturacion.DetalleFactura$Insert
ON Facturacion.DetalleFactura
AFTER INSERT AS
BEGIN
	SET NOCOUNT ON
	-- En caso de que el cliente haya modificado el conteo
	-- de fila para filas insertadas o actualizadas por el trigger
	SET ROWCOUNT 0
	-- Establecer el conteo de filas a cero.
	-- Variable que contiene el mensaje de error
	DECLARE @msg VARCHAR(2000),
		    -- Filas afectadas por el trigger
			@rowsAffected INT = (SELECT COUNT(*) FROM inserted)
	-- Si no existen filas afectadas no hay necesidad de continuar
	IF @rowsAffected = 0 RETURN;
	BEGIN TRY
			-- [sección de modificacion]
			--Comparamos la cantidad en stock con la cantidad a vender para comprar si hay suficientes para realizar la venta
			DECLARE @stock INT
					SELECT @stock = Stock FROM Inventario.Articulos
					INNER JOIN inserted 
					ON inserted.CodigoArticulo = Articulos.Codigo
					WHERE Articulos.Codigo = inserted.CodigoArticulo
			DECLARE @Cantidad INT
			SELECT @Cantidad = CantidadArticulo FROM inserted
			IF(@stock> = @Cantidad)
				UPDATE Inventario.Articulos 
				SET Stock = Stock-@Cantidad
				FROM Inventario.Articulos
				INNER JOIN inserted
				ON inserted.CodigoArticulo = Articulos.Codigo
				WHERE Articulos.Codigo = inserted.CodigoArticulo
			ELSE
				BEGIN
					--Si la cantidad a vender es mayor al stock del libro que muestre un error
					RAISERROR ('LA CANTIDAD DEL STOCK ES INSUFICIENTE PARA LA VENTA',16,1)
				END
	END TRY
			BEGIN CATCH
				IF @@TRANCOUNT > 0
					ROLLBACK TRANSACTION;
					THROW;
			END CATCH
END
GO



CREATE TRIGGER Facturacion.DetalleFactura$Delete
ON Facturacion.DetalleFactura
AFTER Delete AS
BEGIN
	SET NOCOUNT ON
	-- En caso de que el cliente haya modificado el conteo
	-- de fila para filas insertadas o actualizadas por el trigger
	SET ROWCOUNT 0
	-- Establecer el conteo de filas a cero.

	-- Variable que contiene el mensaje de error
	DECLARE @msg VARCHAR(2000),
		    -- Filas afectadas por el trigger
			@rowsAffected INT = (SELECT COUNT(*) FROM deleted)
	-- Si no existen filas afectadas no hay necesidad de continuar
	IF @rowsAffected = 0 RETURN;
	BEGIN TRY
			-- [sección de modificacion]
			--Comparamos la cantidad en stock con la cantidad a vender para comprar si hay suficientes para realizar la venta
			DECLARE @stock2 INT
			SELECT @stock2 = Stock FROM Inventario.Articulos
					INNER JOIN deleted
					ON deleted.CodigoArticulo = Articulos.Codigo
					WHERE Articulos.Codigo = deleted.CodigoArticulo
			DECLARE @Cantidad INT
			SELECT @Cantidad = CantidadArticulo FROM deleted
			IF( @Cantidad>=1)
				UPDATE Inventario.Articulos 
				SET Stock = Stock + @Cantidad
				FROM Inventario.Articulos
				INNER JOIN deleted
				ON deleted.CodigoArticulo = Articulos.Codigo
				WHERE Articulos.Codigo = deleted.CodigoArticulo
			ELSE
				BEGIN
					RAISERROR ('NO SE PUEDE REALIZAR DEVOLUCIÓN',16,1)
			END							
	END TRY
			BEGIN CATCH
				IF @@TRANCOUNT > 0
					ROLLBACK TRANSACTION;
					THROW;
			END CATCH
END
GO
-------------------------------------------------------------------------------------------
CREATE TRIGGER Facturacion.Factura$Update
ON Facturacion.Factura
AFTER UPDATE AS
BEGIN
	SET NOCOUNT ON
	-- En caso de que el cliente haya modificado el conteo
	-- de fila para filas insertadas o actualizadas por el trigger
	SET ROWCOUNT 0
	-- Establecer el conteo de filas a cero.
	-- Variable que contiene el mensaje de error
	DECLARE @msg VARCHAR(2000),
		    -- Filas afectadas por el trigger
			@rowsAffected  INT = (SELECT COUNT(*) FROM deleted),
			@rowsAffected2 INT = (SELECT COUNT(*) FROM inserted);

	-- Si no existen filas afectadas no hay necesidad de continuar
	IF @rowsAffected = 0 RETURN;
	BEGIN TRY
	
		IF UPDATE(ImporteISV)
			BEGIN
				DECLARE @Importe DECIMAL(10,2)
				SELECT @Importe = ImporteISV FROM deleted

				UPDATE Facturacion.Factura
				SET Factura.ImporteISV = inserted.ImporteISV + @Importe
				FROM Facturacion.Factura
				JOIN inserted
				ON inserted.Numero = Factura.Numero
				WHERE Factura.Numero = inserted.Numero
		END

		IF UPDATE(Impuesto)
			BEGIN
				DECLARE @Impuesto DECIMAL(10,2)
				SELECT @Impuesto = Impuesto FROM deleted

				UPDATE Facturacion.Factura
				SET Factura.Impuesto = inserted.Impuesto + @Impuesto	
				FROM Facturacion.Factura
				JOIN inserted
				ON inserted.Numero = Factura.Numero	
				WHERE Factura.Numero = inserted.Numero
		END

		IF UPDATE (Total)
			BEGIN
				DECLARE @Total DECIMAL(10,2)
				SELECT @Total = Total FROM deleted

				UPDATE Facturacion.Factura
				SET Factura.Total = inserted.Total + @Total
				FROM Facturacion.Factura				
				JOIN inserted
				ON inserted.Numero = Factura.Numero
				WHERE Factura.Numero = inserted.Numero
		END

		ELSE
				BEGIN
					RAISERROR ('NO SE PUEDE REALIZAR LA TRANSACCION',16,1)
		END
	END TRY
			BEGIN CATCH
				IF @@TRANCOUNT > 0
					ROLLBACK TRANSACTION;
					THROW;
			END CATCH
END
GO