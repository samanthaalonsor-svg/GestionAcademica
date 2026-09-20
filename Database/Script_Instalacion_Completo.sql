/*
================================================================================
 SCRIPT DE INSTALACIÓN COMPLETO - GESTIÓN ACADÉMICA

 Crea la base de datos y las tablas que necesita el proyecto cuando todavía
 no existen. Si las tablas ya existen, NO las modifica ni elimina.
 Después crea/actualiza usuarios y procedimientos almacenados.

 IMPORTANTE:
 - Este script usa estado como INT en Evaluaciones_Finales, consistente con
   el ComboBox del formulario y con la relación al catálogo Estados.
 - Ejecutar en SQL Server Management Studio.
================================================================================
*/

IF DB_ID(N'Gestion Academica') IS NULL
BEGIN
    CREATE DATABASE [Gestion Academica];
END
GO

USE [Gestion Academica];
GO

-- ============================================================
-- TABLAS DE CATÁLOGO
-- ============================================================
IF OBJECT_ID(N'dbo.Estados', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Estados
    (
        id_estado INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Estados PRIMARY KEY,
        estado NVARCHAR(50) NOT NULL UNIQUE
    );
END
GO

IF OBJECT_ID(N'dbo.Niveles', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Niveles
    (
        id_nivel INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Niveles PRIMARY KEY,
        nivel NVARCHAR(100) NOT NULL UNIQUE
    );
END
GO

IF OBJECT_ID(N'dbo.Materias', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Materias
    (
        id_materia INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Materias PRIMARY KEY,
        materia NVARCHAR(150) NOT NULL UNIQUE
    );
END
GO

IF OBJECT_ID(N'dbo.Profesores', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Profesores
    (
        id_profesor INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Profesores PRIMARY KEY,
        profesor NVARCHAR(150) NOT NULL
    );
END
GO

-- ============================================================
-- ESTUDIANTES
-- ============================================================
IF OBJECT_ID(N'dbo.Estudiantes', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Estudiantes
    (
        codigo_estudiante NVARCHAR(20) NOT NULL CONSTRAINT PK_Estudiantes PRIMARY KEY,
        Alumno NVARCHAR(150) NOT NULL,
        id_estado INT NOT NULL,
        CONSTRAINT FK_Estudiantes_Estados FOREIGN KEY (id_estado)
            REFERENCES dbo.Estados(id_estado)
    );
END
GO

-- ============================================================
-- ASISTENCIAS / SESIONES
-- ============================================================
IF OBJECT_ID(N'dbo.Asistencias_Sesiones', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Asistencias_Sesiones
    (
        id_asistencia INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Asistencias PRIMARY KEY,
        codigo_estudiante NVARCHAR(20) NOT NULL,
        Fecha DATETIME NOT NULL,
        Id_Nivel INT NOT NULL,
        Id_Materia INT NOT NULL,
        Id_Profesor INT NOT NULL,
        CONSTRAINT FK_Asistencias_Estudiantes FOREIGN KEY (codigo_estudiante)
            REFERENCES dbo.Estudiantes(codigo_estudiante),
        CONSTRAINT FK_Asistencias_Niveles FOREIGN KEY (Id_Nivel)
            REFERENCES dbo.Niveles(id_nivel),
        CONSTRAINT FK_Asistencias_Materias FOREIGN KEY (Id_Materia)
            REFERENCES dbo.Materias(id_materia),
        CONSTRAINT FK_Asistencias_Profesores FOREIGN KEY (Id_Profesor)
            REFERENCES dbo.Profesores(id_profesor)
    );
END
GO

-- ============================================================
-- EVALUACIONES FINALES
-- ============================================================
IF OBJECT_ID(N'dbo.Evaluaciones_Finales', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Evaluaciones_Finales
    (
        Id_Evaluacion INT NOT NULL CONSTRAINT PK_Evaluaciones_Finales PRIMARY KEY,
        codigo_estudiante NVARCHAR(20) NOT NULL,
        Asistencia FLOAT NOT NULL DEFAULT(0),
        Puntos_Asistencia FLOAT NOT NULL DEFAULT(0),
        Participacion FLOAT NOT NULL DEFAULT(0),
        Pruebas FLOAT NOT NULL DEFAULT(0),
        id_materia INT NOT NULL,
        id_profesor INT NOT NULL,
        nota_final FLOAT NOT NULL DEFAULT(0),
        estado INT NOT NULL,
        fecha_evaluacion DATETIME NOT NULL,
        CONSTRAINT FK_Evaluaciones_Estudiantes FOREIGN KEY (codigo_estudiante)
            REFERENCES dbo.Estudiantes(codigo_estudiante),
        CONSTRAINT FK_Evaluaciones_Materias FOREIGN KEY (id_materia)
            REFERENCES dbo.Materias(id_materia),
        CONSTRAINT FK_Evaluaciones_Profesores FOREIGN KEY (id_profesor)
            REFERENCES dbo.Profesores(id_profesor),
        CONSTRAINT FK_Evaluaciones_Estados FOREIGN KEY (estado)
            REFERENCES dbo.Estados(id_estado)
    );
END
GO

-- ============================================================
-- DATOS MÍNIMOS DE CATÁLOGO
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM dbo.Estados)
    INSERT INTO dbo.Estados (estado) VALUES (N'Activo'), (N'Inactivo');
GO

-- ============================================================
-- USUARIOS
-- ============================================================
IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Usuarios
    (
        IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
        NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
        ContrasenaHash CHAR(64) NOT NULL,
        NombreCompleto NVARCHAR(100) NOT NULL,
        Activo BIT NOT NULL DEFAULT(1)
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE NombreUsuario = N'UNI')
BEGIN
    INSERT INTO dbo.Usuarios
        (NombreUsuario, ContrasenaHash, NombreCompleto, Activo)
    VALUES
        (N'UNI', '158A323A7BA44870F23D96F1516DD70AA48E9A72DB4EBB026B0A89E212A208AB', N'Usuario UNI', 1);
END
GO

-- ============================================================
-- PROCEDIMIENTOS DE ESTUDIANTES
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Estudiantes_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT codigo_estudiante, Alumno, id_estado
    FROM dbo.Estudiantes
    ORDER BY Alumno;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_ObtenerParaCombo
AS
BEGIN
    SET NOCOUNT ON;
    SELECT codigo_estudiante, Alumno
    FROM dbo.Estudiantes
    ORDER BY Alumno;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Buscar
    @texto NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT codigo_estudiante, Alumno, id_estado
    FROM dbo.Estudiantes
    WHERE codigo_estudiante LIKE N'%' + @texto + N'%'
       OR Alumno LIKE N'%' + @texto + N'%'
    ORDER BY Alumno;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Insertar
    @codigo_estudiante NVARCHAR(20),
    @Alumno NVARCHAR(150),
    @id_estado INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Estudiantes (codigo_estudiante, Alumno, id_estado)
    VALUES (@codigo_estudiante, @Alumno, @id_estado);
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Actualizar
    @codigo_estudiante NVARCHAR(20),
    @Alumno NVARCHAR(150),
    @id_estado INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Estudiantes
    SET Alumno = @Alumno, id_estado = @id_estado
    WHERE codigo_estudiante = @codigo_estudiante;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Eliminar
    @codigo_estudiante NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Estudiantes WHERE codigo_estudiante = @codigo_estudiante;
END
GO

-- ============================================================
-- PROCEDIMIENTOS DE ASISTENCIAS / SESIONES
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Asistencias_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT a.id_asistencia, a.codigo_estudiante, e.Alumno,
           a.Fecha, a.Id_Nivel, a.Id_Materia, a.Id_Profesor
    FROM dbo.Asistencias_Sesiones a
    INNER JOIN dbo.Estudiantes e ON e.codigo_estudiante = a.codigo_estudiante
    ORDER BY a.Fecha DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Buscar
    @texto NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT a.id_asistencia, a.codigo_estudiante, e.Alumno,
           a.Fecha, a.Id_Nivel, a.Id_Materia, a.Id_Profesor
    FROM dbo.Asistencias_Sesiones a
    INNER JOIN dbo.Estudiantes e ON e.codigo_estudiante = a.codigo_estudiante
    WHERE a.codigo_estudiante LIKE N'%' + @texto + N'%'
       OR e.Alumno LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(10), a.Fecha, 103) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), a.Id_Nivel) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), a.Id_Materia) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), a.Id_Profesor) LIKE N'%' + @texto + N'%'
    ORDER BY a.Fecha DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Insertar
    @codigo_estudiante NVARCHAR(20), @Fecha DATETIME,
    @Id_Nivel INT, @Id_Materia INT, @Id_Profesor INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Asistencias_Sesiones
        (codigo_estudiante, Fecha, Id_Nivel, Id_Materia, Id_Profesor)
    VALUES
        (@codigo_estudiante, @Fecha, @Id_Nivel, @Id_Materia, @Id_Profesor);
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Actualizar
    @id_asistencia INT, @codigo_estudiante NVARCHAR(20), @Fecha DATETIME,
    @Id_Nivel INT, @Id_Materia INT, @Id_Profesor INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Asistencias_Sesiones
    SET codigo_estudiante=@codigo_estudiante, Fecha=@Fecha,
        Id_Nivel=@Id_Nivel, Id_Materia=@Id_Materia, Id_Profesor=@Id_Profesor
    WHERE id_asistencia=@id_asistencia;
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Eliminar
    @id_asistencia INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Asistencias_Sesiones WHERE id_asistencia=@id_asistencia;
END
GO

-- ============================================================
-- PROCEDIMIENTOS DE EVALUACIONES FINALES
-- ============================================================
CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ef.Id_Evaluacion, ef.codigo_estudiante, e.Alumno,
           ef.Asistencia, ef.Puntos_Asistencia, ef.Participacion, ef.Pruebas,
           ef.id_materia, ef.id_profesor, ef.nota_final, ef.estado, ef.fecha_evaluacion
    FROM dbo.Evaluaciones_Finales ef
    INNER JOIN dbo.Estudiantes e ON e.codigo_estudiante = ef.codigo_estudiante
    ORDER BY ef.fecha_evaluacion DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Buscar
    @texto NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ef.Id_Evaluacion, ef.codigo_estudiante, e.Alumno,
           ef.Asistencia, ef.Puntos_Asistencia, ef.Participacion, ef.Pruebas,
           ef.id_materia, ef.id_profesor, ef.nota_final, ef.estado, ef.fecha_evaluacion
    FROM dbo.Evaluaciones_Finales ef
    INNER JOIN dbo.Estudiantes e ON e.codigo_estudiante = ef.codigo_estudiante
    WHERE ef.codigo_estudiante LIKE N'%' + @texto + N'%'
       OR e.Alumno LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), ef.id_materia) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), ef.id_profesor) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), ef.estado) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(20), ef.nota_final) LIKE N'%' + @texto + N'%'
       OR CONVERT(NVARCHAR(10), ef.fecha_evaluacion, 103) LIKE N'%' + @texto + N'%'
    ORDER BY ef.fecha_evaluacion DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Insertar
    @codigo_estudiante NVARCHAR(20), @Asistencia FLOAT,
    @Puntos_Asistencia FLOAT, @Participacion FLOAT, @Pruebas FLOAT,
    @id_materia INT, @id_profesor INT, @nota_final FLOAT,
    @estado INT, @fecha_evaluacion DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Evaluaciones_Finales
        (Id_Evaluacion, codigo_estudiante, Asistencia, Puntos_Asistencia,
         Participacion, Pruebas, id_materia, id_profesor, nota_final,
         estado, fecha_evaluacion)
    VALUES
        ((SELECT ISNULL(MAX(Id_Evaluacion),0)+1 FROM dbo.Evaluaciones_Finales),
         @codigo_estudiante, @Asistencia, @Puntos_Asistencia,
         @Participacion, @Pruebas, @id_materia, @id_profesor,
         @nota_final, @estado, @fecha_evaluacion);
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Actualizar
    @Id_Evaluacion INT, @codigo_estudiante NVARCHAR(20), @Asistencia FLOAT,
    @Puntos_Asistencia FLOAT, @Participacion FLOAT, @Pruebas FLOAT,
    @id_materia INT, @id_profesor INT, @nota_final FLOAT,
    @estado INT, @fecha_evaluacion DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Evaluaciones_Finales
    SET codigo_estudiante=@codigo_estudiante, Asistencia=@Asistencia,
        Puntos_Asistencia=@Puntos_Asistencia, Participacion=@Participacion,
        Pruebas=@Pruebas, id_materia=@id_materia, id_profesor=@id_profesor,
        nota_final=@nota_final, estado=@estado,
        fecha_evaluacion=@fecha_evaluacion
    WHERE Id_Evaluacion=@Id_Evaluacion;
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Eliminar
    @Id_Evaluacion INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Evaluaciones_Finales WHERE Id_Evaluacion=@Id_Evaluacion;
END
GO

-- ============================================================
-- PROCEDIMIENTOS DE CATÁLOGOS
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Estados_ObtenerTodos
AS BEGIN SET NOCOUNT ON; SELECT * FROM dbo.Estados; END
GO
CREATE OR ALTER PROCEDURE sp_Niveles_ObtenerTodos
AS BEGIN SET NOCOUNT ON; SELECT * FROM dbo.Niveles; END
GO
CREATE OR ALTER PROCEDURE sp_Materias_ObtenerTodos
AS BEGIN SET NOCOUNT ON; SELECT * FROM dbo.Materias; END
GO
CREATE OR ALTER PROCEDURE sp_Profesores_ObtenerTodos
AS BEGIN SET NOCOUNT ON; SELECT * FROM dbo.Profesores; END
GO

-- ============================================================
-- LOGIN
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Usuarios_ValidarCredenciales
    @NombreUsuario NVARCHAR(50), @ContrasenaHash CHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdUsuario, NombreUsuario, NombreCompleto
    FROM dbo.Usuarios
    WHERE NombreUsuario=@NombreUsuario
      AND ContrasenaHash=@ContrasenaHash
      AND Activo=1;
END
GO

PRINT 'Instalación de Gestion Academica completada.';
PRINT 'Usuario inicial: UNI | Contraseña: 2026';
