using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class CursoProfesor
{
    public int IdcursoProfesor { get; set; }

    public int Idprofesor { get; set; }

    public int Idcurso { get; set; }

    public virtual Curso IdcursoNavigation { get; set; } = null!;

    public virtual Profesor IdprofesorNavigation { get; set; } = null!;
}
