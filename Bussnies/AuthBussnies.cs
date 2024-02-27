using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel;
using ResquestResponsModel.Login;
using ResquestResponsModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilSecurity;

namespace Bussnies
{
    public class AuthBussnies:IAuthBussnies
    {
        private readonly IUsuarioBussnies _UsuarioBussnies;
        private readonly IMapper _mapper;
        private readonly UtilCripto _utilCripto;

        public AuthBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _UsuarioBussnies = new UsuarioBussnies(mapper);
            _utilCripto =new UtilCripto();
        }

        public LoginResponse Login(LoginRequest request)
        {
            
            LoginResponse result= new LoginResponse();
            
            //Validamos que el usuario exista
            Vusuario usuario = _UsuarioBussnies.VistaObtenerPorUserName(request.Email);
            if (usuario == null)
            {
                return result;
            }

            //Proceso de encriptacion de un texto
            string newPassword=_utilCripto.AES_encriptar(request.Password);

            if (newPassword != usuario.Contrasena) {

                return result;
            
            }
            result.Succes = true;
            result.Mensaje = "Usuario correcto";

            result.Usuario = new UsuarioLoginResponse();
            result.Usuario.Email = usuario.Estado;
            result.Usuario.Contrasena= usuario.Rol;
           

           

            return result;
        }
    }
}
