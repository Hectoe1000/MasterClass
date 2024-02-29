using AutoMapper;
using Bussnies;
using IBussniess;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.IdentityModel.Tokens;
using ResquestResponsModel.Generic;
using ResquestResponsModel.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase


    {
        //Definiciond e variables
        private readonly IAuthBussnies _authBussnies;
        private readonly IMapper _mapper;

        public AuthController(IMapper mapper) { 
            _mapper= mapper;
            _authBussnies=new AuthBussnies(mapper);
        
        }

        /// <summary>
        /// Validar si el servicio esta activo 
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get() {

            return Ok(true);
        }

        ///<summary>
        ///
        /// Se usa para iniciar sesion
        ///<parm name="request"></parm>
        
        ///</summary>

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(LoginResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]

        public IActionResult Login([FromBody] LoginRequest request)
        {
            LoginResponse response= _authBussnies.Login(request);
           
            
                response.Token = CreateToken(response);
                return Ok(response);
            
           

        }




        private string CreateToken(LoginResponse oLoginResponse)
        {

            //obteniendo información de nuestro archivo appsettings.json
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            ////OBTENER EL TIEMPO DE VIDA DEL TOKEN
            int tiempoVida = int.Parse(configurationFile["Jwt:TimeJWTMin"]);
            ////01 VAMOS A DETALLAR LOS CLAIMS
            ////==> INFORMACIÓN QUE SE PUEDE ALMACENAR DENTRO DEL TOKEN GENERADO

            ///**
            // * VAMOS A DECLARAR LOS CLAIMS - LA INFORMACIÓN QUE SE VA A CARGAR DENTRO DEL TOKEN
            // * 
            // */

            ////string stringClaims = JsonConvert.SerializeObject(oLoginResponse);
            ////stringClaims = _cripto.AES_encriptar(stringClaims);

            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),// - UTC-0
                        new Claim(ClaimTypes.Role, oLoginResponse.Succes.ToString()),
                        new Claim("UserId", oLoginResponse.Usuario.Contrasena.ToString()),
                  
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMonths(tiempoVida),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);

      

        }
    

   }
    
}
