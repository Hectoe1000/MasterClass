using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel
{
    public class TipoDocumentoResponse
    {

        public int IdTipoDocumento { get; set; }

        public string Descripcion { get; set; } = null!;

        //public virtual icollection<persona> personas
        //{
        //    get; set;
        //}
    }
}
