using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class TipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;

    //public virtual icollection<persona> personas { get; set; } = new list<persona>();
}
