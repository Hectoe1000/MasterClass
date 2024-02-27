using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Curso
{
    public class CursoResponse
    {
        public int Idcurso { get; set; }

        public string? NomCurso { get; set; }

        public DateTime? Horario { get; set; }

        public int IdGrados { get; set; }

        //public virtual ICollection<CursoAlumno> CursoAlumnos { get; set; } = new List<CursoAlumno>();

        //public virtual ICollection<CursoProfesor> CursoProfesors { get; set; } = new List<CursoProfesor>();

        //public virtual Grado IdGradosNavigation { get; set; } = null!;
    }
}
