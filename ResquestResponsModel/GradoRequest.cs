using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class GradoRequest
    {
        public int IdGrados { get; set; }

        public string? NomGrados { get; set; }

        public int IdAula { get; set; }

        //public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

        //public virtual Aula IdAulaNavigation { get; set; } = null!;
    }
}
