using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Alumno
{
    public class AlumnoRequest
    {
        public int Idalumno { get; set; }

        public string? Foto { get; set; }

        [Required]
        public int Idpersona { get; set; }

        //public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

        //public virtual ICollection<CursoAlumno> CursoAlumnos { get; set; } = new List<CursoAlumno>();

        //public virtual Persona IdpersonaNavigation { get; set; } = null!;

        //public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
}
