using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class TipoDocumentoRequest
    {

        public int IdTipoDocumento { get; set; }

        public string Descripcion { get; set; } = null!;

        //public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}
