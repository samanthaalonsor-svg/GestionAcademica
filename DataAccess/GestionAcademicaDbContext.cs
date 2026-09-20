using GestionAcademica.Entities;
using GestionAcademica.ORM;
using Microsoft.EntityFrameworkCore;

namespace GestionAcademica.DataAccess
{
    
    public class GestionAcademicaDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
        public DbSet<Asistencia> Asistencias => Set<Asistencia>();
        public DbSet<EvaluacionFinal> EvaluacionesFinales => Set<EvaluacionFinal>();
        public DbSet<EstadoOrm> Estados => Set<EstadoOrm>();
        public DbSet<NivelOrm> Niveles => Set<NivelOrm>();
        public DbSet<MateriaOrm> Materias => Set<MateriaOrm>();
        public DbSet<ProfesorOrm> Profesores => Set<ProfesorOrm>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Conexion.ObtenerCadenaConexion());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.ToTable("Estudiantes");
                entity.HasKey(e => e.CodigoEstudiante);
                entity.Property(e => e.CodigoEstudiante).HasColumnName("codigo_estudiante").HasMaxLength(20);
                entity.Property(e => e.Alumno).HasColumnName("Alumno").HasMaxLength(150).IsRequired();
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            });

            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.ToTable("Asistencias_Sesiones");
                entity.HasKey(e => e.IdAsistencia);
                entity.Property(e => e.IdAsistencia).HasColumnName("id_asistencia");
                entity.Property(e => e.CodigoEstudiante).HasColumnName("codigo_estudiante").HasMaxLength(20);
                entity.Property(e => e.Fecha).HasColumnName("Fecha");
                entity.Property(e => e.IdNivel).HasColumnName("Id_Nivel");
                entity.Property(e => e.IdMateria).HasColumnName("Id_Materia");
                entity.Property(e => e.IdProfesor).HasColumnName("Id_Profesor");
            });

            modelBuilder.Entity<EvaluacionFinal>(entity =>
            {
                entity.ToTable("Evaluaciones_Finales");
                entity.HasKey(e => e.IdEvaluacion);
                entity.Property(e => e.IdEvaluacion).HasColumnName("Id_Evaluacion");
                entity.Property(e => e.CodigoEstudiante).HasColumnName("codigo_estudiante").HasMaxLength(20);
                entity.Property(e => e.Asistencia).HasColumnName("Asistencia");
                entity.Property(e => e.PuntosAsistencia).HasColumnName("Puntos_Asistencia");
                entity.Property(e => e.Participacion).HasColumnName("Participacion");
                entity.Property(e => e.Pruebas).HasColumnName("Pruebas");
                entity.Property(e => e.IdMateria).HasColumnName("id_materia");
                entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
                entity.Property(e => e.NotaFinal).HasColumnName("nota_final").HasColumnType("decimal(18,2)").HasConversion<decimal>();
                entity.Property(e => e.IdEstado).HasColumnName("estado").HasMaxLength(20).HasConversion<string>();
                entity.Property(e => e.FechaEvaluacion).HasColumnName("fecha_evaluacion");
                entity.Ignore(e => e.Resultado);
            });

            modelBuilder.Entity<EstadoOrm>(entity =>
            {
                entity.ToTable("Estados");
                entity.HasKey(e => e.IdEstado);
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
                
            });
            modelBuilder.Entity<NivelOrm>(entity =>
            {
                entity.ToTable("Niveles");
                entity.HasKey(e => e.IdNivel);
                entity.Property(e => e.IdNivel).HasColumnName("id_nivel");
            });

            modelBuilder.Entity<MateriaOrm>(entity =>
            {
                entity.ToTable("Materias");
                entity.HasKey(e => e.IdMateria);
                entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            });

            modelBuilder.Entity<ProfesorOrm>(entity =>
            {
                entity.ToTable("Profesores");
                entity.HasKey(e => e.IdProfesor);
                entity.Property(e => e.IdProfesor).HasColumnName("id_profesor");
            });
        }
    }
}
