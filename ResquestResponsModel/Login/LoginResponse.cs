using ResquestResponsModel.Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Login
{
    public class LoginResponse
    {
        public bool Succes { get; set; } = false;
        public string Mensaje { get; set; } = "Incorrecto";
        public string Token { get; set; } = "";
        public RolResponse? Rol1 { get; set; }= null;

       public UsuarioLoginResponse? Usuario { get; set; } = null;
    }
}
