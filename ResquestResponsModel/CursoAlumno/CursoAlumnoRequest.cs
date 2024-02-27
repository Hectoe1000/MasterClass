using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.CursoAlumno
{
    public class CursoAlumnoRequest
    {
        public int IdcursoAlumno { get; set; }
        [Required]
        public int Idcurso { get; set; }
        [Required]
        public int Idalumno { get; set; }

        //public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

        //public virtual Alumno IdalumnoNavigation { get; set; } = null!;

        //public virtual Curso IdcursoNavigation { get; set; } = null!;

    }
}
