
--DEFINICION DE LLAVES PRIMARIAS
ALTER TABLE Acceso.Usuarios
	ADD CONSTRAINT PK_Acceso_Usuarios_id
		PRIMARY KEY NONCLUSTERED(id);
GO

ALTER TABLE Acceso.TipoAcceso
	ADD CONSTRAINT PK_Acceso_TipoAcceso_id
		PRIMARY KEY NONCLUSTERED(id);
GO

ALTER TABLE Restaurante.Areas
	ADD CONSTRAINT PK_Restaurante_Areas_id
		PRIMARY KEY NONCLUSTERED (id)
GO

ALTER TABLE Restaurante.Mesas
	ADD CONSTRAINT PK_Restaurante_Mesas_id$Y$idArea
		PRIMARY KEY NONCLUSTERED (id)
GO

ALTER TABLE Restaurante.Meseros
	ADD CONSTRAINT PK_Restaurante_Meseros_id
		PRIMARY KEY NONCLUSTERED (id)
GO

ALTER TABLE Restaurante.MesasReservadas
	ADD CONSTRAINT PK_Restaurante_MesasReservadas_idMesaReservada
		PRIMARY KEY NONCLUSTERED (idMesaReservada)
GO 

ALTER TABLE Restaurante.Pedidos
	ADD CONSTRAINT PK_Restaurante_Pedidos_id
		PRIMARY KEY CLUSTERED (id)
GO 

ALTER TABLE Restaurante.Reservacion
	ADD CONSTRAINT PK_Restaurante_Reservacion_idReservacion
		PRIMARY KEY CLUSTERED (idReservacion)
GO

ALTER TABLE Restaurante.DetallePedidos
	ADD CONSTRAINT PK_Restaurante_DetallePedidos_idDetallePedidos
		PRIMARY KEY CLUSTERED (idDetallePedido)
GO

ALTER TABLE Restaurante.Facturas
	ADD CONSTRAINT PK_Restaurante_Factura_idFactura
		PRIMARY KEY CLUSTERED (idFactura)
GO

ALTER TABLE Restaurante.Inventario
	ADD CONSTRAINT PK_Restaurante_Inventario_idInventario
		PRIMARY KEY CLUSTERED(idInventario)
GO

ALTER TABLE Restaurante.TipoProducto
	ADD CONSTRAINT PK_Restaurante_TipoProducto_idTipoProducto
		PRIMARY KEY CLUSTERED(idTipoProducto)
GO

ALTER TABLE Restaurante.Insumos
	ADD CONSTRAINT PK_Restaurante_Insumos_idInsumo
		PRIMARY KEY CLUSTERED(idInsumo)
GO

ALTER TABLE Restaurante.Proveedores
	ADD CONSTRAINT PK_Restaurante_Proveedores_idProovedor
		PRIMARY KEY CLUSTERED(idProveedor)
GO

ALTER TABLE Restaurante.TipoUnidad
	ADD CONSTRAINT PK_Restaurante_TipoUnidad_idTipoUnidad
		PRIMARY KEY CLUSTERED(idTipoUnidad)
GO

ALTER TABLE Restaurante.InsumosProductos
	ADD CONSTRAINT PK_Restaurante_InsumosProductos_idInsumoProducto
		PRIMARY KEY CLUSTERED(idInsumoProducto)
GO




--DEFINICION DE LLAVES FORANEAS
ALTER TABLE Acceso.Usuarios
	ADD CONSTRAINT FK_Acceso_TipoAcceso_id$tiene$Acceso_Usuarios_id
		FOREIGN KEY	(idAcceso)
			REFERENCES Acceso.TipoAcceso(id);

ALTER TABLE Restaurante.Mesas
	ADD CONSTRAINT FK_Restaurante_Mesas_id$TieneUna$Restaurante_Areas_id
		FOREIGN KEY (idArea)
			REFERENCES Restaurante.Areas(id);

ALTER TABLE Restaurante.MesasReservadas
	ADD CONSTRAINT FK_Restaurante_MesasReservadas_id$TieneUna$Restaurante_Mesas_idMesa
		FOREIGN KEY (idMesa)
			REFERENCES Restaurante.Mesas(id);


ALTER TABLE Restaurante.Pedidos
	ADD CONSTRAINT FK_Restaurante_Pedido_idMesa$TieneUna$Restaurante_Mesas_id
		FOREIGN KEY	(idMesa)
			REFERENCES Restaurante.Mesas(id);
GO

ALTER TABLE Restaurante.MesasReservadas
	ADD CONSTRAINT FK_Restaurante_Reservacion_idReservacion$PuedeTener$MesasReservadas_idReservacion
		FOREIGN KEY (idReservacion)
			REFERENCES Restaurante.Reservacion(idReservacion)
GO

ALTER TABLE Restaurante.Pedidos
	ADD CONSTRAINT FK_Restaurante_Meseros_id$HacenMuchos$Pedidos_id
		FOREIGN KEY (idMesero)
			REFERENCES Restaurante.Meseros(id)
GO

ALTER TABLE	Restaurante.DetallePedidos
	ADD CONSTRAINT FK_Restaurante_DetallePedidos_idPedido$EstanEn$Restaurante_Pedidos_id
		FOREIGN KEY (idPedido)
			REFERENCES Restaurante.Pedidos(id)
GO

ALTER TABLE	Restaurante.Facturas
	ADD CONSTRAINT FK_Restaurante_Facturas_idFactura$TieneUn$Restaurante_Pedidos_idPedido
		FOREIGN KEY (idPedido)
			REFERENCES Restaurante.Pedidos(id)
GO

ALTER TABLE	Restaurante.DetallePedidos
	ADD CONSTRAINT FK_Restaurante_DetallePedidos_idPedido$EstanEn$Restaurante_Inventario_idinventario
		FOREIGN KEY (idInventario)
			REFERENCES Restaurante.Inventario(idInventario)
GO

ALTER TABLE	Restaurante.Inventario
	ADD CONSTRAINT FK_Restaurante_Inventario_idInventario$TienenUn$Restaurante_TipoProducto_idTipoPRoducto
		FOREIGN KEY (idTipoProducto)
			REFERENCES Restaurante.TipoProducto(idTipoProducto)
GO

ALTER TABLE	Restaurante.Insumos
	ADD CONSTRAINT FK_Restaurante_Proveedores_idProveedor$TienenVarios$Restaurante_Inventario_idInventario
		FOREIGN KEY (idProveedor)
			REFERENCES Restaurante.Proveedores(idProveedor)
GO

ALTER TABLE	Restaurante.Inventario
	ADD CONSTRAINT FK_Restaurante_Proveedores_idProveedor$TienenVarios$Restaurante_Insumo_idInsumo
		FOREIGN KEY (idProveedor)
			REFERENCES Restaurante.Proveedores(idProveedor)
GO

ALTER TABLE	Restaurante.Insumos
	ADD CONSTRAINT FK_Restaurante_Insumos_idInsumo$TienenUn$Restaurante_TipoUnidad_idTipoUnidad
		FOREIGN KEY (idTipoUnidad)
			REFERENCES Restaurante.TipoUnidad(idTipoUnidad)
GO

ALTER TABLE Restaurante.InsumosProductos
	ADD CONSTRAINT FK_Restaurante_InsumosProductos_idInsumoProducto$EstaEn$Restaurante_Insumos_idInsumo
		FOREIGN KEY	(idInsumo)
			REFERENCES Restaurante.Insumos(idInsumo);
GO

ALTER TABLE Restaurante.InsumosProductos
	ADD CONSTRAINT FK_Restaurante_InsumosProductos_idInsumoProducto$Tiene$Restaurante_Inventario_idInventario
		FOREIGN KEY	(idInventario)
			REFERENCES Restaurante.Inventario(idInventario);
GO