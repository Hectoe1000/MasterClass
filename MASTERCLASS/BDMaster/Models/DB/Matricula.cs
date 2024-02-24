using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Matricula
{
    public int IdMatricula { get; set; }

    public DateTime FechaMatricula { get; set; }

    public DateTime FechaSalida { get; set; }

    public int IdAlumno { get; set; }

    public string Turno { get; set; } = null!;

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;
}
