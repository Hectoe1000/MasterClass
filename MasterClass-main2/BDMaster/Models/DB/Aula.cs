using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Aula
{
    public int IdAula { get; set; }

    public string CodigAula { get; set; } = null!;

    public string? Capacidad { get; set; }

    public virtual ICollection<Grado> Grados { get; set; } = new List<Grado>();
}
