-- Usar la base de datos master para crear el inicio de sesión
USE master;
GO

-- Crear el inicio de sesión para 'IIS APPPOOL\Libreria'
CREATE LOGIN [IIS APPPOOL\Libreria] FROM WINDOWS;
GO

-- Usar la base de datos 'SistemaGestionLibros' para crear el usuario y asignar roles
USE SistemaGestionLibros;
GO

-- Crear el usuario para 'IIS APPPOOL\Libreria'
CREATE USER [IIS APPPOOL\Libreria] FOR LOGIN [IIS APPPOOL\Libreria];
GO

-- Asignar el rol 'db_owner' al usuario (esto le dará acceso completo a la base de datos; ajusta según tus necesidades)
EXEC sp_addrolemember 'db_owner', 'IIS APPPOOL\Libreria';
GO
