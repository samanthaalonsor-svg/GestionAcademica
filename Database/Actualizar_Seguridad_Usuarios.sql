/* Ejecutar una sola vez en SQL Server Management Studio sobre Gestion Academica.
   Amplía el campo para guardar hashes PBKDF2 de nuevas cuentas; conserva usuarios existentes. */
USE [Gestion Academica];
GO
IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
BEGIN
    THROW 50001, 'No existe dbo.Usuarios. Ejecute primero el script de instalación del proyecto.', 1;
END
GO
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID(N'dbo.Usuarios') AND name = N'ContrasenaHash' AND max_length = 64)
BEGIN
    ALTER TABLE dbo.Usuarios ALTER COLUMN ContrasenaHash NVARCHAR(256) NOT NULL;
END
GO
PRINT 'Actualización de seguridad de usuarios completada.';
GO
