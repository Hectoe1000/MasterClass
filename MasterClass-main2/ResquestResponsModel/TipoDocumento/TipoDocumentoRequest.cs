using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.TipoDocumento
{
    public class TipoDocumentoRequest
    {
        public int IdTipoDocumento { get; set; }

        public string Descripcion { get; set; } = null!;

        //public virtual icollection<persona> personas
        //{
        //    get; set;
        //}
    }
}