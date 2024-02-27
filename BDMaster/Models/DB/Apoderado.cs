using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Apoderado
{
    public int Idapoderado { get; set; }

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Idpersona { get; set; }

    public virtual Persona IdpersonaNavigation { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
