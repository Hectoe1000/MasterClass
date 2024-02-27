using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.CursoProfesor
{
    public class CursoProfesorResponse
    {
        public int IdcursoProfesor { get; set; }

        public int Idprofesor { get; set; }

        public int Idcurso { get; set; }

        //public virtual Curso IdcursoNavigation { get; set; } = null!;

        //public virtual Profesor IdprofesorNavigation { get; set; } = null!;
    }
}
