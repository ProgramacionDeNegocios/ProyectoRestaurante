IF EXISTS(SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'DBRestaurante')
    BEGIN
		USE MASTER
        DROP DATABASE DBRestaurante 
    END
GO

CREATE DATABASE DBRestaurante
GO

USE DBRestaurante
GO

CREATE SCHEMA Restaurante --contiene todas las tablas del sistemas
GO

CREATE SCHEMA Utilidad --contiene las funciones que realizaremos
GO

CREATE SCHEMA Acceso --Contiene la informacion de acceso de los usuarios
GO

/*
	contiene todos los usuarios que manejaran el sistema en las diferentes
	areas del restaurante, teniendo acceso solo a lo pertinente segun sea
	es tipo de idArea de esa seccion

	esta tabla es manejada solo por el administrador principal
*/
IF OBJECT_ID('Acceso.Usuarios')	IS NOT NULL
	DROP TABLE Acceso.Usuarios
ELSE
	BEGIN
		CREATE TABLE Acceso.Usuarios(
			id  INT IDENTITY (1,100) NOT NULL, --index de los usuarios
			nombre NVARCHAR(25) NOT NULL,	--primer nombre del usuario
			apellido NVARCHAR(25) NOT NULL, --primer apellido del usuario
			usuario NVARCHAR(26) NOT NULL,	--Primera letra del nombre en mayusculas más el apellido
									--eje: Pedro Picapiedra (PPicapiedra)
			clave NVARCHAR(20) NOT NULL, --clave de acceso
			departamento INT  NOT NULL--codigo del area de trabajo a la cual pertenece
		);
	END
GO

/*
	esta tabla controlara los modulos que seran disponibles por cada departamento
*/
IF OBJECT_ID('Acceso.TipoAcceso')	IS NOT NULL
	DROP TABLE Acceso.TipoAcceso
ELSE
	BEGIN
		CREATE TABLE Acceso.TipoAcceso(
			id INT IDENTITY (1,10) NOT NULL,
			departamento NVARCHAR(20),
			moduloUsuario BIT
			/*
				falta colorcar los campos de los modulos a los cuales tendra acceso
			*/
		);
	END
GO


/*
	contiene las diferentes areas que contiene el restaurante

	ejemplo: area verde, segunda planta, piscina, primera planta
*/
IF OBJECT_ID('Restaurante.Areas')	IS NOT NULL
	DROP TABLE Restaurante.Areas
ELSE
	BEGIN
		CREATE TABLE Restaurante.Areas(
			id INT IDENTITY(1,100) NOT NULL, -- index de la tupla
			nombre NVARCHAR(50) NOT NULL --nombre del area dentro del restaurante
		);
	END
GO

/*
	cada area tiene relacionadas cierta cantidad de mesas que 
	van insertadas en esta tabla
*/
IF OBJECT_ID('Restaurante.Mesas')	IS NOT NULL
	DROP TABLE Restaurante.Mesas
ELSE
	BEGIN
		CREATE TABLE Restaurante.Mesas(
			id INT IDENTITY (1, 100) NOT NULL, --index de las mesas
			idArea INT NOT NULL,
			estado NVARCHAR(21) NOT NULL --estados que puede tener una mesa
								--libre, ocupado, reservado, saliendo
		);
	END
GO

IF OBJECT_ID('Restaurante.MesasReservadas')	IS NOT NULL
	DROP TABLE Restaurante.MesasReservadas
ELSE
	BEGIN
		CREATE TABLE Restaurante.MesasReservadas(
			idMesaReservada INT IDENTITY(1,1) NOT NULL,
			idMesa INT,
			idReservacion INT
		)
	END
GO



IF OBJECT_ID('Restaurante.Reservacion')	IS NOT NULL
	DROP TABLE Restaurante.Reservacion
ELSE
	BEGIN
		CREATE TABLE Restaurante.Reservacion(
			idReservacion INT IDENTITY(1,1) NOT NULL,
			idUsuario INT NOT NULL,
			nombre NVARCHAR(50) NOT NULL,
			fechaReservacio date,
			fechaAgendada date,
		)
	END
GO

/*
	contiene la informacion de las personas que serviran la comida
*/
IF OBJECT_ID('Restaurante.Meseros')	IS NOT NULL
	DROP TABLE Restaurante.Meseros
ELSE
	BEGIN
		CREATE TABLE Restaurante.Meseros(
			id INT IDENTITY(1,10) NOT NULL,	--index del mesero
			nombre NVARCHAR (25) NOT NULL,			--primer nombre
			apellido NVARCHAR (25) NOT NULL			--primer apellido
		);
	END
GO

/*
	contienen los pedidos que se van generando,
	a que mesa se dirige el pedido y el mesero que 
	los esta atendiendo
*/
IF OBJECT_ID('Restaurante.Pedidos')	IS NOT NULL
	DROP TABLE Restaurante.Pedidos
ELSE
	BEGIN
		CREATE TABLE Restaurante.Pedidos(
			id INT IDENTITY (1, 100000) NOT NULL,	--index del pedido
			Fecha DATETIME NOT NULL,						--fecha y hora en la que se realizo el pedido 
			idMesa INT NOT NULL,							--identificador de la mesa donde se entregara el pedido
			NombreCliente NVARCHAR (50),		--nombre de la persona que realizo el pedido
			idMesero INT NOT NULL						--identificador del mesero que atendera la mesa
		);
	END
GO

IF OBJECT_ID('Restaurante.Facturas')	IS NOT NULL
	DROP TABLE Restaurante.Facturas
ELSE
	BEGIN
		CREATE TABLE Restaurante.Facturas(
			idFactura INT IDENTITY(1,1) NOT NULL,
			idPedido INT NOT NULL,
			idUsuario INT NOT NULL,
			iva DECIMAL(4,4),
			total DECIMAL NOT NULL
		);
	END
GO

IF OBJECT_ID('Restaurante.DetallePedidos')	IS NOT NULL
	DROP TABLE Restaurante.DetallePedidos
ELSE
	BEGIN
		CREATE TABLE Restaurante.DetallePedidos(
			idDetallePedido INT IDENTITY (1,1) NOT NULL,
			idPedido INT NOT NULL,
			idInventario INT NOT NULL,
			cantidad INT NOT NULL,
		);
	END
GO

IF OBJECT_ID('Restaurante.Inventario')	IS NOT NULL
	DROP TABLE Restaurante.Inventario
ELSE
	BEGIN
		CREATE TABLE Restaurante.Inventario(
			idInventario INT IDENTITY NOT NULL,
			descripcion	NVARCHAR(100) NOT NULL,
			costo DECIMAL(4,2) NOT NULL,
			precioVenta DECIMAL(4,2) NOT NULL,
			cantidad DECIMAL(4,2) NOT NULL,
			idTipoProducto INT NOT NULL,
			idInsumo INT NOT NULL,
			idProveedor INT NOT NULL
		);
	END
GO

IF OBJECT_ID('Restaurante.TipoProducto')	IS NOT NULL
	DROP TABLE Restaurante.TipoProducto
ELSE
	BEGIN
		CREATE TABLE Restaurante.TipoProducto(
			idTipoProducto INT IDENTITY NOT NULL,
			nombre NVARCHAR(100)
		);
	END
GO

IF OBJECT_ID('Restaurante.Insumos')	IS NOT NULL
	DROP TABLE Restaurante.Insumos
ELSE
	BEGIN
		CREATE TABLE Restaurante.Insumos(
			idInsumo INT IDENTITY NOT NULL,
			nombre NVARCHAR(100) NOT NULL,
			costo DECIMAL(4,2) NOT NULL,
			idTipoUnidad INT NOT NULL,
			descripcion NVARCHAR(200) NOT NULL,
			idProveedor INT
		);
	END
GO

IF OBJECT_ID('Restaurante.Proveedores')	IS NOT NULL
	DROP TABLE Restaurante.Proveedores
ELSE
	BEGIN
		CREATE TABLE Restaurante.Proveedores(
			idProveedor INT IDENTITY NOT NULL,
			nombre NVARCHAR(100) NOT NULL,
			telefono NVARCHAR(9) NOT NULL,
			direccion NVARCHAR(300)
		);
	END
GO

IF OBJECT_ID('Restaurante.TipoUnidad')	IS NOT NULL
	DROP TABLE Restaurante.TipoUnidad
ELSE
	BEGIN
		CREATE TABLE Restaurante.TipoUnidad(
			idTipoUnidad INT IDENTITY NOT NULL,
			descripcion NVARCHAR(100)
		);
	END
GO

IF OBJECT_ID('Restaurante.InsumosProductos')	IS NOT NULL
	DROP TABLE Restaurante.InsumosProductos
ELSE
	BEGIN
		CREATE TABLE Restaurante.InsumosProductos(
			idInsumoProducto INT IDENTITY(1,1) NOT NULL,
			idInsumo INT NOT NULL,
			idInventario INT NOT NULL
		);
	END
GO

