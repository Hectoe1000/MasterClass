using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.CursoProfesor
{
    public class CursoProfesorRequest
    {
        public int IdcursoProfesor { get; set; }
        [Required]
        public int Idprofesor { get; set; }
        [Required]
        public int Idcurso { get; set; }

        //public virtual Curso IdcursoNavigation { get; set; } = null!;

        //public virtual Profesor IdprofesorNavigation { get; set; } = null!;
    }
}
