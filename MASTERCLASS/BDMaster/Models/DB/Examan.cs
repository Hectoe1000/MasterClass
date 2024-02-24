using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Examan
{
    public int IdExamen { get; set; }

    public string? PregAcertadas { get; set; }

    public string? PregEquivocadas { get; set; }

    public DateTime? FechaExam { get; set; }

    public int IdProfesor { get; set; }

    public virtual ICollection<DetalleExam> DetalleExams { get; set; } = new List<DetalleExam>();

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
