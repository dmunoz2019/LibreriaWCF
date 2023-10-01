USE [SistemaGestionLibros]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Nacionalidad] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoriales](
	[IDEditorial] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Ciudad] [nvarchar](255) NULL,
	[País] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEditorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Título] [nvarchar](255) NOT NULL,
	[Año] [int] NOT NULL,
	[IDAutor] [int] NULL,
	[IDEditorial] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD FOREIGN KEY([IDAutor])
REFERENCES [dbo].[Autores] ([ID])
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Editoriales] FOREIGN KEY([IDEditorial])
REFERENCES [dbo].[Editoriales] ([IDEditorial])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Editoriales]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateAutor]    Script Date: 10/1/2023 2:26:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CreateLibro]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_CreateLibro]
    @Título NVARCHAR(255),
    @Año INT,
    @NombreAutor NVARCHAR(255)
AS
BEGIN
    -- Declarar variable para almacenar ID del autor
    DECLARE @IDAutor INT
	
    -- Obtener el ID del autor basado en el nombre proporcionado
    SELECT @IDAutor = ID
    FROM Autores
    WHERE Nombre LIKE '%' + @NombreAutor + '%'


    -- Verificar si se encontró un autor
    IF @IDAutor IS NULL
    BEGIN
        RAISERROR('No se encontró un autor con ese nombre', 16, 1)
        RETURN
    END

    -- Verificar si hay más de un autor con ese nombre
    IF (SELECT COUNT(*) FROM Autores WHERE Nombre LIKE '%' + @NombreAutor + '%') > 1
    BEGIN
        RAISERROR('Hay varios autores con ese nombre. Por favor, especifica más.', 16, 1)
        RETURN
    END
	
	-- Vamos a verficiar si ya existe 
	
    IF (SELECT COUNT(*) FROM Libros WHERE LOWER(Título) LIKE LOWER(@Título) AND IDAutor  =  @IDAutor ) > 1
    BEGIN
        RAISERROR(	'Existe libros por el nombre porporcionado' , 16, 1)
        RETURN 
    END
    -- Insertar el libro con el ID del autor obtenido
    INSERT INTO Libros (Título, Año, IDAutor)
    VALUES (@Título, @Año, @IDAutor)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAutor]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteAutor]
    @ID INT
AS
BEGIN
    DELETE FROM Autores WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteLibro]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_DeleteLibro]
    @ID INT
AS
BEGIN
    DELETE FROM Libros WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllAutores]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllAutores]
AS
BEGIN
    SELECT * FROM Autores
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllBooks]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAllBooks]
AS
BEGIN
    SELECT * FROM Libros
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllEditoriales]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetAllEditoriales]
AS
BEGIN
    SELECT * FROM Editoriales
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAutorById]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAutorById]
    @ID INT
AS
BEGIN
    SELECT * FROM Autores WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAutoresConMasDeTresLibros]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
/****** Object:  StoredProcedure [dbo].[sp_GetAutorYLibrosPorLibroId]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetAutorYLibrosPorLibroId]
    @IDLibro INT
AS
BEGIN
    SELECT A.ID, A.Nombre, A.Nacionalidad, L.Título, L.Año
    FROM Autores A
    INNER JOIN Libros L ON A.ID = L.IDAutor
    WHERE A.ID = (SELECT IDAutor FROM Libros WHERE ID = @IDLibro)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLibroById]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_GetLibroById]
    @ID INT
AS
BEGIN
    SELECT * FROM Libros WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLibrosPorAutorId]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimientos con JOINs

CREATE PROCEDURE [dbo].[sp_GetLibrosPorAutorId]
    @IDAutor INT
AS
BEGIN
    SELECT L.ID, L.Título, L.Año, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE A.ID = @IDAutor
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLibrosPorNombreAutor]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetLibrosPorNombreAutor]
    @Nombre NVARCHAR(255)
AS
BEGIN
    SELECT L.ID, L.Título, L.Año, A.Nombre AS Autor, A.Nacionalidad
    FROM Libros L
    INNER JOIN Autores A ON L.IDAutor = A.ID
    WHERE LOWER(A.Nombre) like '%'+LOWER(@Nombre)+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLibrosPorNombreEditorial]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetLibrosPorNombreEditorial]
    @NombreEditorial NVARCHAR(255)
AS
BEGIN
    -- Corrección: Definir el tipo de dato de la variable
    DECLARE @IdEditorial INT

    -- Vamos a buscar el id de la editorial nombrada
    SELECT @IdEditorial = IDEditorial
    FROM Editoriales
    WHERE Nombre LIKE '%' + @NombreEditorial + '%'

    IF @IdEditorial IS NULL
    BEGIN
        RAISERROR('No se encontró una Editorial con ese nombre', 16, 1)
        RETURN
    END

    -- Verificar si hay más de un autor con ese nombre
    IF (SELECT COUNT(*) FROM Editoriales WHERE Nombre LIKE '%' + @NombreEditorial + '%') > 1
    BEGIN
        RAISERROR('Hay varias editoriales con ese nombre. Por favor, intenta con un nombre mas completo.', 16, 1)
        RETURN
    END

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
         L.IDEditorial = @IdEditorial 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateAutor]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateAutor]
    @ID INT,
    @Nombre NVARCHAR(255) = NULL,
    @Nacionalidad NVARCHAR(255) = NULL
AS
BEGIN
    -- Si @Nombre no es NULL, actualizar Nombre
    IF @Nombre IS NOT NULL
    BEGIN
        UPDATE Autores
        SET Nombre = @Nombre
        WHERE ID = @ID
    END

    -- Si @Nacionalidad no es NULL, actualizar Nacionalidad
    IF @Nacionalidad IS NOT NULL
    BEGIN
        UPDATE Autores
        SET Nacionalidad = @Nacionalidad
        WHERE ID = @ID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateLibro]    Script Date: 10/1/2023 2:26:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateLibro]
    @ID INT,
    @Título NVARCHAR(255) = NULL,
    @Año INT = NULL,
    @IDAutor INT = NULL
AS
BEGIN
    -- Si @Título no es NULL, actualizar Título
    IF @Título IS NOT NULL
    BEGIN
        UPDATE Libros
        SET Título = @Título
        WHERE ID = @ID
    END

    -- Si @Año no es NULL, actualizar Año
    IF @Año IS NOT NULL
    BEGIN
        UPDATE Libros
        SET Año = @Año
        WHERE ID = @ID
    END

    -- Si @IDAutor no es NULL, actualizar IDAutor
    IF @IDAutor IS NOT NULL
    BEGIN
        UPDATE Libros
        SET IDAutor = @IDAutor
        WHERE ID = @ID
    END
END
GO
