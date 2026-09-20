using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAcademica.ORM
{
    public class EstadoOrm
    {
        public int IdEstado { get; set; }
        public string Estado { get; set; } = string.Empty;
    }

    public class NivelOrm
    {
        public int IdNivel { get; set; }
        public string Nivel { get; set; } = string.Empty;
    }

    public class MateriaOrm
    {
        public int IdMateria { get; set; }
       
        public string Materia { get; set; } = string.Empty;
    }

    public class ProfesorOrm
    {
        public int IdProfesor { get; set; }
        
        public string Profesor { get; set; } = string.Empty;
    }
}
