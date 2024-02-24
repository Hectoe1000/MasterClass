using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Profesor
{
    public int IdProfesor { get; set; }

    public string? EmailProfesor { get; set; }

    public int IdPersona { get; set; }

    public virtual ICollection<Examan> Examen { get; set; } = new List<Examan>();

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
