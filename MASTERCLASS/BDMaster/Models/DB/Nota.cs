using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Nota
{
    public int IdNotas { get; set; }

    public string? Nota1 { get; set; }

    public int IdAlumno { get; set; }

    public int IdExamen { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Examan IdExamenNavigation { get; set; } = null!;
}
