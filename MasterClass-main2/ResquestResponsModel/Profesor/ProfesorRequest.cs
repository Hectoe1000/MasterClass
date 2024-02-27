using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Profesor
{
    public class ProfesorRequest
    {

        public int Idprofesor { get; set; }

        public string? EmailProfesor { get; set; }

        public int Idpersona { get; set; }

        //public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

        //public virtual ICollection<CursoProfesor> CursoProfesors { get; set; } = new List<CursoProfesor>();

        //public virtual Persona IdpersonaNavigation { get; set; } = null!;
    }
}
