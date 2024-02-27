using AutoMapper;
using Bussnies;
using IBussniess;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using ResquestResponsModel.Generic;
using ResquestResponsModel.Login;
using System.Net;

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

            //if (request.Email == "admin" && request.Password == "123") 
            //{

            //    response.Succes = true;
            //    response.Mensaje = "login correcto";
            //}
            return Ok(response);
               


        }

    }
    
}
