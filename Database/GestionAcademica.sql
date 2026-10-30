USE [master]
GO
/****** Objeto: Database [Gestion Academica] Fecha de script: 5/10/2026 2:08:36:p. m. ******/
CREATE DATABASE [Gestion Academica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'2s5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\2s5.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'2s5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\2s5_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Gestion Academica] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestion Academica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gestion Academica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gestion Academica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gestion Academica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gestion Academica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gestion Academica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gestion Academica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gestion Academica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gestion Academica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gestion Academica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gestion Academica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gestion Academica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gestion Academica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gestion Academica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gestion Academica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gestion Academica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gestion Academica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gestion Academica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gestion Academica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gestion Academica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gestion Academica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gestion Academica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gestion Academica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gestion Academica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gestion Academica] SET  MULTI_USER 
GO
ALTER DATABASE [Gestion Academica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gestion Academica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gestion Academica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gestion Academica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gestion Academica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gestion Academica] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [Gestion Academica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Gestion Academica] SET QUERY_STORE = ON
GO
ALTER DATABASE [Gestion Academica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Gestion Academica]
GO
/****** Objeto: Table [dbo].[Asistencias_Sesiones] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencias_Sesiones](
	[id_asistencia] [int] IDENTITY(1,1) NOT NULL,
	[codigo_estudiante] [varchar](50) NULL,
	[id_materia] [int] NULL,
	[id_profesor] [int] NULL,
	[id_nivel] [int] NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Estados] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] NOT NULL,
	[nombre_estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Estudiantes] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[codigo_estudiante] [varchar](10) NOT NULL,
	[Alumno] [varchar](100) NOT NULL,
	[id_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Evaluaciones_Finales] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluaciones_Finales](
	[Id_Evaluacion] [int] NOT NULL,
	[codigo_estudiante] [varchar](10) NULL,
	[Asistencia] [int] NULL,
	[Puntos_Asistencia] [int] NULL,
	[Participacion] [int] NULL,
	[Pruebas] [int] NULL,
	[id_materia] [int] NULL,
	[id_profesor] [int] NULL,
	[nota_final] [decimal](5, 2) NULL,
	[estado] [varchar](20) NULL,
	[fecha_evaluacion] [date] NULL,
	[Resultado]  AS (case when [nota_final]>=(60) then 'Aprobado' else 'Reprobado' end) PERSISTED NOT NULL,
 CONSTRAINT [PK_Evaluaciones_Finales] PRIMARY KEY CLUSTERED 
(
	[Id_Evaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Materias] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Niveles] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveles](
	[id_nivel] [int] NOT NULL,
	[nombre_nivel] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Profesores] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[id_profesor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Usuarios] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[ContrasenaHash] [nvarchar](256) NOT NULL,
	[NombreCompleto] [nvarchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asistencias_Sesiones] ON 

INSERT [dbo].[Asistencias_Sesiones] ([id_asistencia], [codigo_estudiante], [id_materia], [id_profesor], [id_nivel], [fecha]) VALUES (1, N'1', 1, 1, 2, CAST(N'2026-08-31' AS Date))
INSERT [dbo].[Asistencias_Sesiones] ([id_asistencia], [codigo_estudiante], [id_materia], [id_profesor], [id_nivel], [fecha]) VALUES (2, N'1', 2, 3, 3, CAST(N'2026-09-01' AS Date))
INSERT [dbo].[Asistencias_Sesiones] ([id_asistencia], [codigo_estudiante], [id_materia], [id_profesor], [id_nivel], [fecha]) VALUES (3, N'005', 4, 3, 2, CAST(N'2026-09-05' AS Date))
SET IDENTITY_INSERT [dbo].[Asistencias_Sesiones] OFF
GO
INSERT [dbo].[Estados] ([id_estado], [nombre_estado]) VALUES (1, N'Activo')
INSERT [dbo].[Estados] ([id_estado], [nombre_estado]) VALUES (2, N'Inactivo')
INSERT [dbo].[Estados] ([id_estado], [nombre_estado]) VALUES (3, N'Presente')
INSERT [dbo].[Estados] ([id_estado], [nombre_estado]) VALUES (4, N'Ausente')
INSERT [dbo].[Estados] ([id_estado], [nombre_estado]) VALUES (5, N'Traslado')
GO
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'001', N'Samantha Alonso', 1)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'002', N'Josnny Hernandez', 1)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'004', N'Jeremy Castro O', 1)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'005', N'Juan Perez', 2)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'007', N'Claudia M', 1)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'008', N'Maria R', 1)
INSERT [dbo].[Estudiantes] ([codigo_estudiante], [Alumno], [id_estado]) VALUES (N'009', N'Claudia R', 1)
GO
INSERT [dbo].[Evaluaciones_Finales] ([Id_Evaluacion], [codigo_estudiante], [Asistencia], [Puntos_Asistencia], [Participacion], [Pruebas], [id_materia], [id_profesor], [nota_final], [estado], [fecha_evaluacion]) VALUES (1, N'004', 0, 0, 5, 0, 1, 1, CAST(5.00 AS Decimal(5, 2)), N'1', CAST(N'2026-08-31' AS Date))
INSERT [dbo].[Evaluaciones_Finales] ([Id_Evaluacion], [codigo_estudiante], [Asistencia], [Puntos_Asistencia], [Participacion], [Pruebas], [id_materia], [id_profesor], [nota_final], [estado], [fecha_evaluacion]) VALUES (2, N'001', 10, 15, 15, 29, 1, 1, CAST(59.00 AS Decimal(5, 2)), N'1', CAST(N'2026-08-31' AS Date))
INSERT [dbo].[Evaluaciones_Finales] ([Id_Evaluacion], [codigo_estudiante], [Asistencia], [Puntos_Asistencia], [Participacion], [Pruebas], [id_materia], [id_profesor], [nota_final], [estado], [fecha_evaluacion]) VALUES (3, N'002', 10, 35, 15, 50, 1, 1, CAST(100.00 AS Decimal(5, 2)), N'1', CAST(N'2026-08-31' AS Date))
INSERT [dbo].[Evaluaciones_Finales] ([Id_Evaluacion], [codigo_estudiante], [Asistencia], [Puntos_Asistencia], [Participacion], [Pruebas], [id_materia], [id_profesor], [nota_final], [estado], [fecha_evaluacion]) VALUES (5, N'004', 0, 20, 0, 10, 1, 1, CAST(30.00 AS Decimal(5, 2)), N'1', CAST(N'2026-08-31' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([id_materia], [nombre]) VALUES (1, N'Programacion de escritorio')
INSERT [dbo].[Materias] ([id_materia], [nombre]) VALUES (2, N'Algebra Lineal')
INSERT [dbo].[Materias] ([id_materia], [nombre]) VALUES (3, N'Fisica')
INSERT [dbo].[Materias] ([id_materia], [nombre]) VALUES (4, N'Economia')
SET IDENTITY_INSERT [dbo].[Materias] OFF
GO
INSERT [dbo].[Niveles] ([id_nivel], [nombre_nivel]) VALUES (1, N'Nivel I')
INSERT [dbo].[Niveles] ([id_nivel], [nombre_nivel]) VALUES (2, N'Nivel II')
INSERT [dbo].[Niveles] ([id_nivel], [nombre_nivel]) VALUES (3, N'Nivel III')
INSERT [dbo].[Niveles] ([id_nivel], [nombre_nivel]) VALUES (4, N'Nivel IV')
INSERT [dbo].[Niveles] ([id_nivel], [nombre_nivel]) VALUES (5, N'Nivel V')
GO
SET IDENTITY_INSERT [dbo].[Profesores] ON 

INSERT [dbo].[Profesores] ([id_profesor], [nombre]) VALUES (1, N'Jose Hernandez')
INSERT [dbo].[Profesores] ([id_profesor], [nombre]) VALUES (2, N'Karen Arias')
INSERT [dbo].[Profesores] ([id_profesor], [nombre]) VALUES (3, N'Juan Orozco')
INSERT [dbo].[Profesores] ([id_profesor], [nombre]) VALUES (4, N'Ariel Blanco')
INSERT [dbo].[Profesores] ([id_profesor], [nombre]) VALUES (5, N'Aura Lopez')
SET IDENTITY_INSERT [dbo].[Profesores] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [NombreUsuario], [ContrasenaHash], [NombreCompleto], [Activo]) VALUES (1, N'UNI', N'158A323A7BA44870F23D96F1516DD70AA48E9A72DB4EBB026B0A89E212A208AB', N'Usuario UNI', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Objeto: Index [UQ__Usuarios__6B0F5AE0F46444B6] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Evaluaciones_Finales] ADD  DEFAULT (getdate()) FOR [fecha_evaluacion]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Estudiantes]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Evaluaciones_Finales]  WITH CHECK ADD  CONSTRAINT [FK__Evaluacio__codig__6E01572D] FOREIGN KEY([codigo_estudiante])
REFERENCES [dbo].[Estudiantes] ([codigo_estudiante])
GO
ALTER TABLE [dbo].[Evaluaciones_Finales] CHECK CONSTRAINT [FK__Evaluacio__codig__6E01572D]
GO
/****** Objeto: StoredProcedure [dbo].[sp_Asistencias_Actualizar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Asistencias_Actualizar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Asistencias_Buscar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Asistencias_Buscar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Asistencias_Eliminar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Asistencias_Eliminar]
    @id_asistencia INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Asistencias_Sesiones
    WHERE id_asistencia = @id_asistencia;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Asistencias_Insertar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Asistencias_Insertar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Asistencias_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ============================================================
-- 3) PROCEDIMIENTOS: dbo.Asistencias_Sesiones
-- ============================================================
CREATE   PROCEDURE [dbo].[sp_Asistencias_ObtenerTodos]
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
/****** Objeto: StoredProcedure [dbo].[sp_Estados_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ============================================================
-- 5) PROCEDIMIENTOS: catálogos de solo lectura
-- ============================================================
CREATE   PROCEDURE [dbo].[sp_Estados_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Estados;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_Actualizar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Estudiantes_Actualizar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_Buscar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Estudiantes_Buscar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_Eliminar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Estudiantes_Eliminar]
    @codigo_estudiante NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Estudiantes
    WHERE codigo_estudiante = @codigo_estudiante;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_Insertar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Estudiantes_Insertar]
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
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_ObtenerParaCombo] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Estudiantes_ObtenerParaCombo]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT codigo_estudiante, Alumno
    FROM dbo.Estudiantes
    ORDER BY Alumno;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Estudiantes_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ============================================================
-- 2) PROCEDIMIENTOS: dbo.Estudiantes
-- ============================================================
CREATE   PROCEDURE [dbo].[sp_Estudiantes_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT codigo_estudiante, Alumno, id_estado
    FROM dbo.Estudiantes
    ORDER BY Alumno;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_EvaluacionesFinales_Actualizar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_EvaluacionesFinales_Actualizar]
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
/****** Objeto: StoredProcedure [dbo].[sp_EvaluacionesFinales_Buscar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_EvaluacionesFinales_Buscar]
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
/****** Objeto: StoredProcedure [dbo].[sp_EvaluacionesFinales_Eliminar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_EvaluacionesFinales_Eliminar]
    @Id_Evaluacion INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Evaluaciones_Finales
    WHERE Id_Evaluacion = @Id_Evaluacion;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_EvaluacionesFinales_Insertar] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_EvaluacionesFinales_Insertar]
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
/****** Objeto: StoredProcedure [dbo].[sp_EvaluacionesFinales_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EvaluacionesFinales_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id_Evaluacion,
        codigo_estudiante,
        Asistencia,
        Puntos_Asistencia,
        Participacion,
        Pruebas,
        id_materia,
        id_profesor,
        nota_final,
        estado,
        fecha_evaluacion,
        -- Columna calculada para mostrar Aprobado o Reprobado
        CASE 
            WHEN nota_final >= 60 THEN 'Aprobado'
            ELSE 'Reprobado'
        END AS Resultado
    FROM Evaluaciones_Finales;
END
GO
/****** Objeto: StoredProcedure [dbo].[sp_Materias_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Materias_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Materias;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Niveles_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Niveles_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Niveles;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Profesores_ObtenerTodos] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_Profesores_ObtenerTodos]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM dbo.Profesores;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_Usuarios_ValidarCredenciales] Fecha de script: 5/10/2026 2:08:37:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ============================================================
-- 6) PROCEDIMIENTO: login (dbo.Usuarios)
-- ============================================================
CREATE   PROCEDURE [dbo].[sp_Usuarios_ValidarCredenciales]
    @NombreUsuario   NVARCHAR(50),
    @ContrasenaHash  NVARCHAR(256)
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
USE [master]
GO
ALTER DATABASE [Gestion Academica] SET  READ_WRITE 
GO
