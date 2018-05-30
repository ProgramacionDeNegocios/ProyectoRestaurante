USE master
GO

DROP DATABASE DBRestaurante
GO

CREATE DATABASE DBRestaurante
GO

USE DBRestaurante
GO

CREATE SCHEMA Restaurante
GO

/*
	contiene todos los usuarios que manejaran el sistema en las diferentes
	areas del restaurante, teniendo acceso solo a lo pertinente segun sea
	es tipo de idArea de esa seccion

	esta tabla es manejada solo por el administrador principal
*/
CREATE TABLE Restaurante.Usuarios(
	id  INT IDENTITY (1,100) NOT NULL, --index de los usuarios
	nombre NVARCHAR(25) NOT NULL,	--primer nombre del usuario
	apellido NVARCHAR(25) NOT NULL, --primer apellido del usuario
	usuario NVARCHAR(20) NOT NULL,	--Primera letra del nombre en mayusculas más el apellido
							--eje: Pedro Picapiedra (PPicapiedra)
	clave NVARCHAR(20) NOT NULL, --clace de acceso
	idArea INT  NOT NULL--codigo del area de trabajo a la cual pertenece
);
GO


/*
	contiene las diferentes areas que contiene el restaurante

	ejemplo: area verde, segunda planta, piscina, primera planta
*/
CREATE TABLE Restaurante.Areas(
	id INT IDENTITY(1,100) NOT NULL, -- index de la tupla
	nombre NVARCHAR(50) NOT NULL --nombre del area dentro del restaurante
);
GO

/*
	cada area tiene relacionadas cierta cantidad de mesas que 
	van insertadas en esta tabla
*/
CREATE TABLE Restaurante.Mesas(
	idMeza INT IDENTITY (1, 100) NOT NULL, --index de las mesas
	idArea INT NOT NULL,
	estado NVARCHAR(21) NOT NULL --estados que puede tener una mesa
						--libre, ocupado, reservado, saliendo
);
GO


/*
	contiene la informacion de las personas que serviran la comida
*/
CREATE TABLE Restaurante.Meseros(
	idMesero INT IDENTITY(1,10) NOT NULL,	--index del mesero
	nombre NVARCHAR (25) NOT NULL,			--primer nombre
	apellido NVARCHAR (25) NOT NULL			--primer apellido
);
GO

/*
	contienen los pedidos que se van generando,
	a que mesa se dirige el pedido y el mesero que 
	los esta atendiendo
*/
CREATE TABLE Restaurante.Pedidos(
	idPedido INT IDENTITY (1, 100000) NOT NULL,	--index del pedido
	Fecha DATETIME NOT NULL,						--fecha y hora en la que se realizo el pedido 
	idMesa INT NOT NULL,							--identificador de la mesa donde se entregara el pedido
	NombreCliente NVARCHAR (20),		--nombre de la persona que realizo el pedido
	idMesero INT NOT NULL						--identificador del mesero que atendera la mesa
);
GO


/*
	contiene todas las bebidas disponibles en el menu con su
	respectivo precio y la descripcion exacta del producto
*/
CREATE TABLE Restaurante.MenuBebidas(
	idBebida INT IDENTITY (1,99) NOT NULL, --index de la bebida
	descripcion NVARCHAR(60) NOT NULL,	--descripcion exacta del producto
	precio INT
);
GO

/*
	agregamos los pedidos de bebida en nuestro pedido original,
	creamos esta tabla para tratar a los refrescos por aparte de
	los insumos alimenticios
*/
CREATE TABLE Restaurante.PedidoBebidas(
	idPedidoBebida INT IDENTITY (1, 100000) NOT NULL,
	idPedido INT NOT NULL,
	idBebida INT NOT NULL,
	cantidad INT NOT NULL
);
GO


/*
	contiene todas las bebidas disponibles en el menu con su
	respectivo precio y la descripcion exacta del producto
*/
CREATE TABLE Restaurante.MenuPlato(
	idPlaro INT IDENTITY (1,99) NOT NULL, --index del plato
	descripcion NVARCHAR(60) NOT NULL,	--descripcion exacta del plato
	precio INT
);
GO


/*
	agregamos los pedidos de comida en nuestro pedido original,
	creamos esta tabla para tratar a los alimentos por aparte de
	las bebidas
*/
CREATE TABLE Restaurante.PedidoPlato(
	idPedidoPlato INT IDENTITY (1, 100000) NOT NULL,
	idPedido INT NOT NULL,
	idPlato INT NOT NULL,
	cantidad INT NOT NULL
);
GO


/*
	el id del pedido de la bebida esta demas ya que lo podemos hacer solamente 
	con el id del pedido ya que es el mismo pedido

	consultar con los compañeros ¿si lo vamos a quitar?
*/