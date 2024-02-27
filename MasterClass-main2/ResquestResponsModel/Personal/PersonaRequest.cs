using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Personal
{
    public class PersonaRequest
    {
        public int Idpersona { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string NroDocumento { get; set; } = null!;

        public string? Sexo { get; set; }

        public string Edad { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public int? IdTipoDocumento { get; set; }

        //public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

        //public virtual ICollection<Apoderado> Apoderados { get; set; } = new List<Apoderado>();

        //public virtual TipoDocumento? IdTipoDocumentoNavigation { get; set; }

        //public virtual ICollection<Profesor> Profesors { get; set; } = new List<Profesor>();
    }
}
