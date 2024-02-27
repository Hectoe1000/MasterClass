using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Usuario
{
    public class UsuarioRequest
    {
        public int IdUsuario { get; set; }

        public string Contrasena { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int IdRol { get; set; }

        //public virtual Rol IdRolNavigation { get; set; } = null!;
    }
}
