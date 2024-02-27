using System;
using System.Collections.Generic;

namespace BDMaster.Models.DB;

public partial class Vusuario
{
    public string? Rol { get; set; }

    public string? Estado { get; set; }

    public string? Contrasena { get; set; }

    public string Email { get; set; } = null!;
}
