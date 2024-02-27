using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class CursoAlumno
{
    public int IdcursoAlumno { get; set; }

    public int Idcurso { get; set; }

    public int Idalumno { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual Alumno IdalumnoNavigation { get; set; } = null!;

    public virtual Curso IdcursoNavigation { get; set; } = null!;
}
