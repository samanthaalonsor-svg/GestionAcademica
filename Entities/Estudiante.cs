namespace GestionAcademica.Entities
{
    public class Estudiante
    {
        public string CodigoEstudiante { get; set; } = string.Empty;
        public string Alumno { get; set; } = string.Empty;
        public int IdEstado { get; set; }

        public override string ToString()
        {
            return $"{CodigoEstudiante} - {Alumno}";
        }
    }
}
