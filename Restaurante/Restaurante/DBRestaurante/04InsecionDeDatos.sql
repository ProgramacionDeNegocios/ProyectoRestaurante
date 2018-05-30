INSERT INTO Restaurante.Usuarios
(
    usuario,	--el usuario se define como 
	clave,
	nombre,
	apellido,
    idArea
)
VALUES
(   N'OToledo', -- usuario - nvarchar(20)
	N'Ninguna', -- clave - nvarchar(20)
    N'Oscar', --nombre - nvarchar (25)
	N'Toledo', --apellido - nvarchar (25)

    1    -- idArea - int
)
GO

INSERT INTO Restaurante.Areas
(
    nombre
)
VALUES
(N'Caja' -- nombre - nvarchar(30)
    )



--AREA DE PRUEBA DE LA INFORMACION
SELECT * FROM Restaurante.Usuarios
SELECT * FROM Restaurante.Areas
