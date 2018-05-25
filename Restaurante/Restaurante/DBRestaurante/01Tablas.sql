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

CREATE TABLE Restaurante.Usuarios(
	id  INT IDENTITY (1,100), --index de la tupla
	usuario NVARCHAR(20), --primer nombre del usuario
	clave NVARCHAR(20), --clace de acceso
	idArea INT --codigo del area de trabajo a la cual pertenece
);
GO

CREATE TABLE Restaurante.Area(
	id INT IDENTITY(1,100), -- indes de la tupla
	nombre NVARCHAR(30) --nombre del area de trabajo
);
GO

INSERT INTO Restaurante.Usuarios
(
    usuario,
    clave,
    idArea
)
VALUES
(   N'Oscar', -- usuario - nvarchar(20)
    N'Ninguna', -- clave - nvarchar(20)
    1    -- idArea - int
)
GO

INSERT INTO Restaurante.Area
(
    nombre
)
VALUES
(N'Caja' -- nombre - nvarchar(30)
    )



--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Restaurante.Usuarios
SELECT * FROM Restaurante.Area
