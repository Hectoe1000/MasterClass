using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class CalificacionesResponse
    {
        public int Idcalificaciones { get; set; }

        public string? Nota { get; set; }

        public int? IdcursoAlumno { get; set; }

        public int? Idalumno { get; set; }

        public int? Idprofesor { get; set; }

        //public virtual Alumno? IdalumnoNavigation { get; set; }

        //public virtual CursoAlumno? IdcursoAlumnoNavigation { get; set; }

        //public virtual Profesor? IdprofesorNavigation { get; set; }
    }
}
