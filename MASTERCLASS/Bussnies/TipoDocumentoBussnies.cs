
using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel;

namespace Bussnies
{
    public class TipoDocumentoBussnies : ITipoDocumentoBussnies
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        private readonly ITipoDocumentoRepository _tipoDocumentorepository;
        private readonly IMapper _mapper;
        public TipoDocumentoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _tipoDocumentorepository = new TipoDocumentoRepository();
        }
        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR

        public List<TipoDocumentoResponse> Getall()
        {
          List<TipoDocumentoResponse> lst =new List<TipoDocumentoResponse> ();
            List<TipoDocumento> _tipoDocumento = _tipoDocumentorepository.Getall();
            lst = _mapper.Map<List<TipoDocumentoResponse>>(_tipoDocumento);
            return lst;
            
        }

        public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
        {
            TipoDocumento _tipoDocumento = _mapper.Map<TipoDocumento>(entity);
            _tipoDocumento = _tipoDocumentorepository.Create(_tipoDocumento);

            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(_tipoDocumento);
            return result;

        }

        public int Delete(object id)
        {
            int cantidad = _tipoDocumentorepository.Delete(id);
            return cantidad;
        }


        public TipoDocumentoResponse GetById(int id)
        {
            TipoDocumento _tipoDocumento = _tipoDocumentorepository.GetById(id);
            TipoDocumentoResponse resul = _mapper.Map<TipoDocumentoResponse>(_tipoDocumento);
            //CargoResponse resultado = _mapper.Map<CargoResponse>(_cargoRepository.GetById(id));
            return resul;
        }

        public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
        {
            TipoDocumento tipoDocumento = _mapper.Map<TipoDocumento>(entity);
            tipoDocumento = _tipoDocumentorepository.Update(tipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(_tipoDocumentorepository);
            return result;
        }
    }
}
