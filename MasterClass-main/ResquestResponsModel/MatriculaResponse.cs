using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class MatriculaResponse
    {
        public int IdMatricula { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Idalumno { get; set; }

        public string Turno { get; set; } = null!;

        public int Idapoderado { get; set; }

        //public virtual Alumno IdalumnoNavigation { get; set; } = null!;

        //public virtual Apoderado IdapoderadoNavigation { get; set; } = null!;
    }
}
