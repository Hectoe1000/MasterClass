using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Nivel
{
    public int IdNivel { get; set; }

    public string NomNivel { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
