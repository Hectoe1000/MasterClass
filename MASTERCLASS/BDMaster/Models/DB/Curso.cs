using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string? NomCurso { get; set; }

    public int IdNivel { get; set; }

    public virtual ICollection<DetalleExam> DetalleExams { get; set; } = new List<DetalleExam>();

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    public virtual Nivel IdNivelNavigation { get; set; } = null!;
}
