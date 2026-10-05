/*
================================================================================
 COMPLEMENTO DEL ENTREGABLE 6 - ENTITY FRAMEWORK CORE

 El proyecto ya utiliza ADO.NET y procedimientos almacenados. Este script NO
 reemplaza ni elimina ese acceso. EF Core se configura como complemento y
 trabaja sobre las tablas existentes.

 Ejecutar en SQL Server solo para verificar que las tablas necesarias existen.
 No modifica datos ni cambia la estructura.
================================================================================
*/

USE [Gestion Academica];
GO

IF OBJECT_ID(N'dbo.Estudiantes', N'U') IS NULL
    THROW 50001, 'No existe la tabla Estudiantes. Ejecute primero el script de instalación del proyecto.', 1;

IF OBJECT_ID(N'dbo.Estados', N'U') IS NULL
    THROW 50002, 'No existe la tabla Estados. Ejecute primero el script de instalación del proyecto.', 1;

IF OBJECT_ID(N'dbo.Asistencias_Sesiones', N'U') IS NULL
    THROW 50003, 'No existe la tabla Asistencias_Sesiones. Ejecute primero el script de instalación del proyecto.', 1;

IF OBJECT_ID(N'dbo.Evaluaciones_Finales', N'U') IS NULL
    THROW 50004, 'No existe la tabla Evaluaciones_Finales. Ejecute primero el script de instalación del proyecto.', 1;

PRINT 'Verificación completada: las tablas requeridas por Entity Framework Core existen.';
GO
