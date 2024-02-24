using AutoMapper;
using Bussnies;
using IBussniess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResquestResponsModel;
using System.Net;

namespace Master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {

        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly ITipoDocumentoBussnies _tipoDocumentoBussnies;
        private readonly IMapper _mapper;
        public TipoDocumentoController(IMapper mapper)
        {
            _mapper = mapper;
            _tipoDocumentoBussnies = new TipoDocumentoBussnies(mapper);
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR

        #region CRUD METHODS
        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA CARGO
        /// </summary>
        /// <returns>List-CargoResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TipoDocumentoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(AdminErrores))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(AdminErrores))]
        public IActionResult Get()
        {
            return Ok(_tipoDocumentoBussnies.Getall());
        }
        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>CargoResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TipoDocumentoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(AdminErrores))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(AdminErrores))]
        public IActionResult Get(int id)
        {
            return Ok(_tipoDocumentoBussnies.GetById(id));
        }

        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TipoDocumentoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(AdminErrores))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(AdminErrores))]
        public IActionResult Create([FromBody] TipoDocumentoRequest request)
        {
            return Ok(_tipoDocumentoBussnies.Create(request));
        }

        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(TipoDocumentoResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(AdminErrores))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(AdminErrores))]
        public IActionResult Update([FromBody] TipoDocumentoRequest request)
        {
            return Ok(_tipoDocumentoBussnies.Update(request));
        }

        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(AdminErrores))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(AdminErrores))]

        public IActionResult Delete(int id)
        {
            return Ok(_tipoDocumentoBussnies.Delete(id));
        }
        #endregion CRUD METHODS

    }
}
