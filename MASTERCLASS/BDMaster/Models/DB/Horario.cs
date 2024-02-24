using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Horario
{
    public int IdHorario { get; set; }

    public DateTime IniClases { get; set; }

    public DateTime? FinClases { get; set; }

    public int IdCurso { get; set; }

    public int IdAula { get; set; }

    public int IdProfesor { get; set; }

    public virtual Aula IdAulaNavigation { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;
}
