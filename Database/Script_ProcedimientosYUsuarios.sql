/*
================================================================================
 Script: Procedimientos almacenados + tabla de Usuarios
 Proyecto: GestionAcademica
 --------------------------------------------------------------------------
 Ejecutar este script completo en SSMS, conectado a la base de datos
 "Gestion Academica" (la misma que usa DataAccess/Conexion.cs).

 Este script:
   1) Crea la tabla dbo.Usuarios (si no existe) y un usuario por defecto.
   2) Crea/actualiza todos los procedimientos almacenados que usa la app.

 Es seguro volver a ejecutarlo: usa CREATE OR ALTER y comprobaciones
 IF NOT EXISTS, así que no falla si ya lo corriste antes.

 IMPORTANTE: los tipos de columna (NVARCHAR, INT, etc.) son los más
 razonables según las tablas que ya usa el proyecto. Si en tu base de
 datos alguna columna tiene un tipo/tamaño distinto, ajusta el SELECT/
 parámetro correspondiente para que coincida.
================================================================================
*/

USE [Gestion Academica];
GO

-- ============================================================
-- 1) TABLA DE USUARIOS (login del sistema)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Usuarios' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.Usuarios
    (
        IdUsuario        INT IDENTITY(1,1) PRIMARY KEY,
        NombreUsuario    NVARCHAR(50)  NOT NULL UNIQUE,
        ContrasenaHash   CHAR(64)      NOT NULL,   -- SHA-256 en hexadecimal, calculado en la app
        NombreCompleto   NVARCHAR(100) NOT NULL,
        Activo           BIT           NOT NULL DEFAULT (1)
    );
END
GO

-- Usuario por defecto: UNI / 2026 (el mismo que estaba "quemado" antes).
-- El hash de abajo corresponde a SHA-256("2026") en hexadecimal mayúsculas.
IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE NombreUsuario = 'UNI')
BEGIN
    INSERT INTO dbo.Usuarios (NombreUsuario, ContrasenaHash, NombreCompleto, Activo)
    VALUES ('UNI', '158A323A7BA44870F23D96F1516DD70AA48E9A72DB4EBB026B0A89E212A208AB', 'Usuario UNI', 1);
END
GO

-- ============================================================
-- 2) PROCEDIMIENTOS: dbo.Estudiantes
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
    WHERE codigo_estudiante LIKE '%' + @texto + '%'
       OR Alumno LIKE '%' + @texto + '%'
    ORDER BY Alumno;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Insertar
    @codigo_estudiante NVARCHAR(20),
    @Alumno            NVARCHAR(150),
    @id_estado         INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Estudiantes (codigo_estudiante, Alumno, id_estado)
    VALUES (@codigo_estudiante, @Alumno, @id_estado);
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Actualizar
    @codigo_estudiante NVARCHAR(20),
    @Alumno            NVARCHAR(150),
    @id_estado         INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Estudiantes
    SET Alumno = @Alumno,
        id_estado = @id_estado
    WHERE codigo_estudiante = @codigo_estudiante;
END
GO

CREATE OR ALTER PROCEDURE sp_Estudiantes_Eliminar
    @codigo_estudiante NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Estudiantes
    WHERE codigo_estudiante = @codigo_estudiante;
END
GO

-- ============================================================
-- 3) PROCEDIMIENTOS: dbo.Asistencias_Sesiones
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
    WHERE a.codigo_estudiante LIKE '%' + @texto + '%'
       OR e.Alumno LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(10), a.Fecha, 103) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), a.Id_Nivel) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), a.Id_Materia) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), a.Id_Profesor) LIKE '%' + @texto + '%'
    ORDER BY a.Fecha DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Insertar
    @codigo_estudiante NVARCHAR(20),
    @Fecha             DATETIME,
    @Id_Nivel          INT,
    @Id_Materia        INT,
    @Id_Profesor       INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Asistencias_Sesiones (codigo_estudiante, Fecha, Id_Nivel, Id_Materia, Id_Profesor)
    VALUES (@codigo_estudiante, @Fecha, @Id_Nivel, @Id_Materia, @Id_Profesor);
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Actualizar
    @id_asistencia     INT,
    @codigo_estudiante NVARCHAR(20),
    @Fecha             DATETIME,
    @Id_Nivel          INT,
    @Id_Materia        INT,
    @Id_Profesor       INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Asistencias_Sesiones
    SET codigo_estudiante = @codigo_estudiante,
        Fecha = @Fecha,
        Id_Nivel = @Id_Nivel,
        Id_Materia = @Id_Materia,
        Id_Profesor = @Id_Profesor
    WHERE id_asistencia = @id_asistencia;
END
GO

CREATE OR ALTER PROCEDURE sp_Asistencias_Eliminar
    @id_asistencia INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Asistencias_Sesiones
    WHERE id_asistencia = @id_asistencia;
END
GO

-- ============================================================
-- 4) PROCEDIMIENTOS: dbo.Evaluaciones_Finales
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
    WHERE ef.codigo_estudiante LIKE '%' + @texto + '%'
       OR e.Alumno LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), ef.id_materia) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), ef.id_profesor) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), ef.estado) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(20), ef.nota_final) LIKE '%' + @texto + '%'
       OR CONVERT(NVARCHAR(10), ef.fecha_evaluacion, 103) LIKE '%' + @texto + '%'
    ORDER BY ef.fecha_evaluacion DESC;
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Insertar
    @codigo_estudiante NVARCHAR(20),
    @Asistencia        FLOAT,
    @Puntos_Asistencia FLOAT,
    @Participacion     FLOAT,
    @Pruebas           FLOAT,
    @id_materia        INT,
    @id_profesor       INT,
    @nota_final        FLOAT,
    @estado            INT,
    @fecha_evaluacion  DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    -- Id_Evaluacion no es IDENTITY en este proyecto; se conserva la misma
    -- lógica de numeración manual que ya traía la aplicación.
    INSERT INTO dbo.Evaluaciones_Finales
        (Id_Evaluacion, codigo_estudiante, Asistencia, Puntos_Asistencia, Participacion, Pruebas,
         id_materia, id_profesor, nota_final, estado, fecha_evaluacion)
    VALUES
        ((SELECT ISNULL(MAX(Id_Evaluacion), 0) + 1 FROM dbo.Evaluaciones_Finales),
         @codigo_estudiante, @Asistencia, @Puntos_Asistencia, @Participacion, @Pruebas,
         @id_materia, @id_profesor, @nota_final, @estado, @fecha_evaluacion);
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Actualizar
    @Id_Evaluacion     INT,
    @codigo_estudiante NVARCHAR(20),
    @Asistencia        FLOAT,
    @Puntos_Asistencia FLOAT,
    @Participacion     FLOAT,
    @Pruebas           FLOAT,
    @id_materia        INT,
    @id_profesor       INT,
    @nota_final        FLOAT,
    @estado            INT,
    @fecha_evaluacion  DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Evaluaciones_Finales
    SET codigo_estudiante = @codigo_estudiante,
        Asistencia = @Asistencia,
        Puntos_Asistencia = @Puntos_Asistencia,
        Participacion = @Participacion,
        Pruebas = @Pruebas,
        id_materia = @id_materia,
        id_profesor = @id_profesor,
        nota_final = @nota_final,
        estado = @estado,
        fecha_evaluacion = @fecha_evaluacion
    WHERE Id_Evaluacion = @Id_Evaluacion;
END
GO

CREATE OR ALTER PROCEDURE sp_EvaluacionesFinales_Eliminar
    @Id_Evaluacion INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Evaluaciones_Finales
    WHERE Id_Evaluacion = @Id_Evaluacion;
END
GO

-- ============================================================
-- 5) PROCEDIMIENTOS: catálogos de solo lectura
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Estados_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Estados;
END
GO

CREATE OR ALTER PROCEDURE sp_Niveles_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Niveles;
END
GO

CREATE OR ALTER PROCEDURE sp_Materias_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Materias;
END
GO

CREATE OR ALTER PROCEDURE sp_Profesores_ObtenerTodos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Profesores;
END
GO

-- ============================================================
-- 6) PROCEDIMIENTO: login (dbo.Usuarios)
-- ============================================================
CREATE OR ALTER PROCEDURE sp_Usuarios_ValidarCredenciales
    @NombreUsuario   NVARCHAR(50),
    @ContrasenaHash  CHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdUsuario, NombreUsuario, NombreCompleto
    FROM dbo.Usuarios
    WHERE NombreUsuario = @NombreUsuario
      AND ContrasenaHash = @ContrasenaHash
      AND Activo = 1;
END
GO

PRINT 'Script ejecutado correctamente: tabla Usuarios y procedimientos almacenados listos.';
