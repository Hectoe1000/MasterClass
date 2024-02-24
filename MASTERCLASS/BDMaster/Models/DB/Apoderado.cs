using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Apoderado
{
    public int IdApoderado { get; set; }

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int IdPersona { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
