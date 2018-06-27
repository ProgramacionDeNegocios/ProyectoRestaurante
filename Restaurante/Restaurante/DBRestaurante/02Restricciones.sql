
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