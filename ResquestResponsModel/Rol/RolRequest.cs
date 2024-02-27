using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Rol
{
    public class RolRequest
    {
        public int IdRol { get; set; }

        public string? Rol1 { get; set; }

        public string? Estado { get; set; }

        //public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
