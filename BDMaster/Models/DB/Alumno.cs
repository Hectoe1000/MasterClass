using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Alumno
{
    public int Idalumno { get; set; }

    public byte[]? Foto { get; set; }

    public int Idpersona { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual ICollection<CursoAlumno> CursoAlumnos { get; set; } = new List<CursoAlumno>();

    public virtual Persona IdpersonaNavigation { get; set; } = null!;

    public virtual ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}
