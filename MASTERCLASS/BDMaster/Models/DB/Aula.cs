using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Aula
{
    public int IdAula { get; set; }

    public string Turno { get; set; } = null!;

    public string CodigAula { get; set; } = null!;

    public string? Capacidad { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
}
