namespace GestionAcademica.Entities
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public string CodigoEstudiante { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int IdNivel { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
    }
}
