INSERT INTO Restaurante.Usuarios
(
    usuario,	--el usuario se define como 
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
