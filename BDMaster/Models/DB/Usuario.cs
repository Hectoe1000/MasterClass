using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Contraseña { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int IdRol { get; set; }

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
