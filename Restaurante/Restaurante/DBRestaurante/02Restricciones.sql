USE DBRestaurante
GO

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
		PRIMARY KEY NONCLUSTERED (id, idArea)
GO

ALTER TABLE Restaurante.Meseros
	ADD CONSTRAINT PK_Restaurante_Meseros_id
		PRIMARY KEY NONCLUSTERED (id)
GO

ALTER TABLE Restaurante.Pedidos
	ADD CONSTRAINT PK_Restaurante_Pedidos_id$Y$idMesa
		PRIMARY KEY NONCLUSTERED (id, idMesa)
GO

ALTER TABLE Restaurante.MenuBebidas
	ADD CONSTRAINT PK_Restaurante_MenuBebidas_id
		PRIMARY KEY (id)
GO

ALTER TABLE Restaurante.PedidoBebidas
	ADD CONSTRAINT PK_Restaurante_PedidoBebidas_idPedido$Y$idBebida
		PRIMARY KEY(idPedido, idBebida)
GO

ALTER TABLE Restaurante.MenuPlato
	ADD CONSTRAINT PK_Restaurante_MenuPlato_idPlato
		PRIMARY KEY (idPlato)
GO

ALTER TABLE Restaurante.PedidoPlato
	ADD CONSTRAINT PK_Restaurante_PedidosPlato_idPedido$Y$idPlato
		PRIMARY KEY (idPedido, idPlato)