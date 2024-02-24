using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class AulaResponse
    {

        public int IdAula { get; set; }

        public string CodigAula { get; set; } = null!;

        public string? Capacidad { get; set; }

        //public virtual ICollection<Grado> Grados { get; set; } = new List<Grado>();
    }
}
