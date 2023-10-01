USE [SistemaGestionLibros]
GO

/****** Object:  StoredProcedure [dbo].[sp_CreateAutor]    Script Date: 9/30/2023 10:02:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- CRUD para Autores

CREATE PROCEDURE [dbo].[sp_CreateAutor]
    @Nombre NVARCHAR(255),
    @Nacionalidad NVARCHAR(255)
AS
BEGIN
    INSERT INTO Autores (Nombre, Nacionalidad)
    VALUES (@Nombre, @Nacionalidad)
END
GO


/****** Object:  StoredProcedure [dbo].[sp_CreateLibro]    Script Date: 9/30/2023 10:02:35 PM ******/


CREATE PROCEDURE [dbo].[sp_CreateLibro]
    @T�tulo NVARCHAR(255),
    @A�o INT,
    @NombreAutor NVARCHAR(255)
AS
BEGIN
    -- Declarar variable para almacenar ID del autor
    DECLARE @IDAutor INT
	
    -- Obtener el ID del autor basado en el nombre proporcionado
    SELECT @IDAutor = ID
    FROM Autores
    WHERE Nombre LIKE '%' + @NombreAutor + '%'


    -- Verificar si se encontr� un autor
    IF @IDAutor IS NULL
    BEGIN
        RAISERROR('No se encontr� un autor con ese nombre', 16, 1)
        RETURN
    END

    -- Verificar si hay m�s de un autor con ese nombre
    IF (SELECT COUNT(*) FROM Autores WHERE Nombre LIKE '%' + @NombreAutor + '%') > 1
    BEGIN
        RAISERROR('Hay varios autores con ese nombre. Por favor, especifica m�s.', 16, 1)
        RETURN
    END
	
	-- Vamos a verficiar si ya existe 
	
    IF (SELECT COUNT(*) FROM Libros WHERE LOWER(T�tulo) LIKE LOWER(@T�tulo) AND IDAutor  =  @IDAutor ) > 1
    BEGIN
        RAISERROR(	'Existe libros por el nombre porporcionado' , 16, 1)
        RETURN 
    END
    -- Insertar el libro con el ID del autor obtenido
    INSERT INTO Libros (T�tulo, A�o, IDAutor)
    VALUES (@T�tulo, @A�o, @IDAutor)
END
GO


/****** Object:  StoredProcedure [dbo].[sp_DeleteAutor]    Script Date: 9/30/2023 10:02:48 PM ******/



CREATE PROCEDURE [dbo].[sp_DeleteAutor]
    @ID INT
AS
BEGIN
    DELETE FROM Autores WHERE ID = @ID
END
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteLibro]    Script Date: 9/30/2023 10:03:52 PM ******/



CREATE PROCEDURE [dbo].[sp_DeleteLibro]
    @ID INT
AS
BEGIN
    DELETE FROM Libros WHERE ID = @ID
END
GO


/****** Object:  StoredProcedure [dbo].[sp_GetAllAutores]    Script Date: 9/30/2023 10:04:25 PM ******/


SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetAllAutores]
AS
BEGIN
    SELECT * FROM Autores
END
GO



/****** Object:  StoredProcedure [dbo].[sp_GetAllBooks]    Script Date: 9/30/2023 10:04:42 PM ******/


CREATE PROCEDURE [dbo].[sp_GetAllBooks]
AS
BEGIN
    SELECT * FROM Libros
END
GO



/****** Object:  StoredProcedure [dbo].[sp_GetAutorById]    Script Date: 9/30/2023 10:04:53 PM ******/

CREATE PROCEDURE [dbo].[sp_GetAutorById]
    @ID INT
AS
BEGIN
    SELECT * FROM Autores WHERE ID = @ID
END
GO


/****** Object:  StoredProcedure [dbo].[sp_GetAutoresConMasDeTresLibros]    Script Date: 9/30/2023 10:05:56 PM ******/



CREATE PROCEDURE [dbo].[sp_GetAutoresConMasDeTresLibros]
AS
BEGIN
    SELECT A.ID, A.Nombre, A.Nacionalidad, COUNT(L.ID) AS NumeroDeLibros
    FROM Autores A
    INNER JOIN Libros L ON A.ID = L.IDAutor
    GROUP BY A.ID, A.Nombre, A.Nacionalidad
    HAVING COUNT(L.ID) > 3
END
GO

/****** Object:  StoredProcedure [dbo].[sp_GetAutorYLibrosPorLibroId]    Script Date: 9/30/2023 10:06:20 PM ******/



CREATE PROCEDURE [dbo].[sp_GetAutorYLibrosPorLibroId]
    @IDLibro INT
AS
BEGIN
    SELECT A.ID, A.Nombre, A.Nacionalidad, L.T�tulo, L.A�o
    FROM Autores A
    INNER JOIN Libros L ON A.ID = L.IDAutor
    WHERE A.ID = (SELECT IDAutor FROM Libros WHERE ID = @IDLibro)
END
GO

/****** Object:  StoredProcedure [dbo].[sp_GetLibroById]    Script Date: 9/30/2023 10:06:36 PM ******/



CREATE PROCEDURE [dbo].[sp_GetLibroById]
    @ID INT
AS
BEGIN
    SELECT * FROM Libros WHERE ID = @ID
END
GO

/****** Object:  StoredProcedure [dbo].[sp_GetLibrosPorAutorId]    Script Date: 9/30/2023 10:06:52 PM ******/


-- Procedimientos con JOINs

CREATE PROCEDURE [dbo].[sp_GetLibrosPorAutorId]
    @IDAutor INT
AS
BEGIN
    SELECT L.ID, L.T�tulo, L.A�o, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE A.ID = @IDAutor
END
GO


/****** Object:  StoredProcedure [dbo].[sp_GetLibrosPorNombreAutor]    Script Date: 9/30/2023 10:07:19 PM ******/



CREATE PROCEDURE [dbo].[sp_GetLibrosPorNombreAutor]
    @Nombre NVARCHAR(255)
AS
BEGIN
    SELECT L.ID, L.T�tulo, L.A�o, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE LOWER(A.Nombre) like '%'+LOWER(@Nombre)+'%'
END
GO

/****** Object:  StoredProcedure [dbo].[sp_UpdateAutor]    Script Date: 9/30/2023 10:07:37 PM ******/

CREATE PROCEDURE [dbo].[sp_UpdateAutor]
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


/****** Object:  StoredProcedure [dbo].[sp_UpdateLibro]    Script Date: 9/30/2023 10:07:56 PM ******/

CREATE PROCEDURE [dbo].[sp_UpdateLibro]
    @ID INT,
    @T�tulo NVARCHAR(255),
    @A�o INT,
    @IDAutor INT
AS
BEGIN
    UPDATE Libros
    SET T�tulo = @T�tulo, A�o = @A�o, IDAutor = @IDAutor
    WHERE ID = @ID
END
GO
CREATE PROCEDURE sp_GetLibrosAutorYEditorial
    @IDAutor INT
AS
BEGIN
    SELECT 
        L.Título, 
        A.Nombre AS Autor,
        E.Nombre AS Editorial
    FROM 
        Libros L
    INNER JOIN 
        Autores A ON L.IDAutor = A.ID
    INNER JOIN 
        Editoriales E ON L.IDEditorial = E.IDEditorial
    WHERE 
        A.ID = @IDAutor
END






















