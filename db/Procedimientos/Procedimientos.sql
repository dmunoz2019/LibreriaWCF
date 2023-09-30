-- CRUD para Autores

CREATE PROCEDURE sp_CreateAutor
    @Nombre NVARCHAR(255),
    @Nacionalidad NVARCHAR(255)
AS
BEGIN
    INSERT INTO Autores (Nombre, Nacionalidad)
    VALUES (@Nombre, @Nacionalidad)
END
GO

CREATE PROCEDURE sp_GetAllAutores
AS
BEGIN
    SELECT * FROM Autores
END
GO

CREATE PROCEDURE sp_GetAutorById
    @ID INT
AS
BEGIN
    SELECT * FROM Autores WHERE ID = @ID
END
GO

CREATE PROCEDURE sp_UpdateAutor
    @ID INT,
    @Nombre NVARCHAR(255),
    @Nacionalidad NVARCHAR(255)
AS
BEGIN
    UPDATE Autores
    SET Nombre = @Nombre, Nacionalidad = @Nacionalidad
    WHERE ID = @ID
END
GO

CREATE PROCEDURE sp_DeleteAutor
    @ID INT
AS
BEGIN
    DELETE FROM Autores WHERE ID = @ID
END
GO

-- CRUD para Libros

CREATE PROCEDURE sp_CreateLibro
    @Título NVARCHAR(255),
    @Año INT,
    @IDAutor INT
AS
BEGIN
    INSERT INTO Libros (Título, Año, IDAutor)
    VALUES (@Título, @Año, @IDAutor)
END
GO

CREATE PROCEDURE sp_GetAllBooks
AS
BEGIN
    SELECT * FROM Libros
END
GO

CREATE PROCEDURE sp_GetLibroById
    @ID INT
AS
BEGIN
    SELECT * FROM Libros WHERE ID = @ID
END
GO

CREATE PROCEDURE sp_UpdateLibro
    @ID INT,
    @Título NVARCHAR(255),
    @Año INT,
    @IDAutor INT
AS
BEGIN
    UPDATE Libros
    SET Título = @Título, Año = @Año, IDAutor = @IDAutor
    WHERE ID = @ID
END
GO

CREATE PROCEDURE sp_DeleteLibro
    @ID INT
AS
BEGIN
    DELETE FROM Libros WHERE ID = @ID
END
GO

-- Procedimientos con JOINs

CREATE PROCEDURE sp_GetLibrosPorAutorId
    @IDAutor INT
AS
BEGIN
    SELECT L.ID, L.Título, L.Año, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE A.ID = @IDAutor
END
GO

CREATE PROCEDURE sp_GetLibrosPorNombreAutor
    @Nombre NVARCHAR(255)
AS
BEGIN
    SELECT L.ID, L.Título, L.Año, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE LOWER(A.Nombre) = LOWER(@Nombre)
END
GO

CREATE PROCEDURE sp_GetAutoresConMasDeTresLibros
AS
BEGIN
    SELECT A.ID, A.Nombre, A.Nacionalidad, COUNT(L.ID) AS NumeroDeLibros
    FROM Autores A
    INNER JOIN Libros L ON A.ID = L.IDAutor
    GROUP BY A.ID, A.Nombre, A.Nacionalidad
    HAVING COUNT(L.ID) > 3
END
GO

CREATE PROCEDURE sp_GetAutorYLibrosPorLibroId
    @IDLibro INT
AS
BEGIN
    SELECT A.ID, A.Nombre, A.Nacionalidad, L.Título, L.Año
    FROM Autores A
    INNER JOIN Libros L ON A.ID = L.IDAutor
    WHERE A.ID = (SELECT IDAutor FROM Libros WHERE ID = @IDLibro)
END
GO
