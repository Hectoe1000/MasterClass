using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Grado
{
    public int IdGrados { get; set; }

    public string? NomGrados { get; set; }

    public int IdAula { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    public virtual Aula IdAulaNavigation { get; set; } = null!;
}
