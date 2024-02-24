using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Profesor
{
    public int Idprofesor { get; set; }

    public string? EmailProfesor { get; set; }

    public int Idpersona { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual ICollection<CursoProfesor> CursoProfesors { get; set; } = new List<CursoProfesor>();

    public virtual Persona IdpersonaNavigation { get; set; } = null!;
}
