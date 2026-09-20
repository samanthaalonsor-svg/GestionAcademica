using System.Data;
using GestionAcademica.DataAccess;

namespace GestionAcademica.Negocio
{
    public class CatalogosBL
    {
        private readonly CatalogosDAO catalogosDAO = new CatalogosDAO();

        public DataTable ObtenerEstados() => catalogosDAO.ObtenerEstados();
        public DataTable ObtenerNiveles() => catalogosDAO.ObtenerNiveles();
        public DataTable ObtenerMaterias() => catalogosDAO.ObtenerMaterias();
        public DataTable ObtenerProfesores() => catalogosDAO.ObtenerProfesores();
        public DataTable ObtenerEstudiantesParaCombo() => catalogosDAO.ObtenerEstudiantesParaCombo();
    }
}
