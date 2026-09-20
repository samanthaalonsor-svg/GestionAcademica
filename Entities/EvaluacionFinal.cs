namespace GestionAcademica.Entities
{
    public class EvaluacionFinal
    {
        public int IdEvaluacion { get; set; }
        public string CodigoEstudiante { get; set; } = string.Empty;
        public double Asistencia { get; set; }
        public double PuntosAsistencia { get; set; }
        public double Participacion { get; set; }
        public double Pruebas { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public double NotaFinal { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public string Resultado { get; set; }
    }
}
