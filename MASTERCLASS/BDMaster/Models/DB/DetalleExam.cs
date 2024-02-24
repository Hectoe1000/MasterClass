using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class DetalleExam
{
    public int IdDetalleExam { get; set; }

    public string? PuntajeCurso { get; set; }

    public int IdCurso { get; set; }

    public int IdExamen { get; set; }

    public virtual Curso IdCursoNavigation { get; set; } = null!;

    public virtual Examan IdExamenNavigation { get; set; } = null!;
}
