using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Alumno
{
    public int IdAlumno { get; set; }

    public byte[]? Foto { get; set; }

    public int IdNivel { get; set; }

    public int IdApoderado { get; set; }

    public int IdPersona { get; set; }

    public virtual Apoderado IdApoderadoNavigation { get; set; } = null!;

    public virtual Nivel IdNivelNavigation { get; set; } = null!;

    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
