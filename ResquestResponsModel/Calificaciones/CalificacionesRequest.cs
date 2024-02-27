using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Calificaciones
{
    public class CalificacionesRequest
    {
        public int Idcalificaciones { get; set; }

        public string? Nota { get; set; }
        [Required]
        public int? IdcursoAlumno { get; set; }
        [Required]
        public int? Idalumno { get; set; }
        [Required]
        public int? Idprofesor { get; set; }

        //public virtual Alumno? IdalumnoNavigation { get; set; }

        //public virtual CursoAlumno? IdcursoAlumnoNavigation { get; set; }

        //public virtual Profesor? IdprofesorNavigation { get; set; }
    }
}
