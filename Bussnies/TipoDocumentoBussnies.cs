using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class TipoDocumentoBussnies : ITipoDocumentoBussnies

    {
        private readonly ITipoDocumentoRepository tipoDocuemntoRepository;
        private readonly IMapper _mapper;

        public TipoDocumentoBussnies(IMapper mapper) { 
        
            _mapper = mapper;
            tipoDocuemntoRepository = new TipoDocumentoRepository();

        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<TipoDocumentoResponse> GetAll()
        {
            List<TipoDocumento> TipoDocumentos = tipoDocuemntoRepository.GetAll();
            List<TipoDocumentoResponse> lstResponse = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return lstResponse;
        }

        public TipoDocumentoResponse GetById(int id)
        {
            TipoDocumento TipoDocumento = tipoDocuemntoRepository.GetById(id);
            TipoDocumentoResponse resul = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return resul;
        }

        public TipoDocumentoResponse Create(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = tipoDocuemntoRepository.Create(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return result;
        }
        public List<TipoDocumentoResponse> InsertMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = tipoDocuemntoRepository.CreateMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }

        public TipoDocumentoResponse Update(TipoDocumentoRequest entity)
        {
            TipoDocumento TipoDocumento = _mapper.Map<TipoDocumento>(entity);
            TipoDocumento = tipoDocuemntoRepository.Update(TipoDocumento);
            TipoDocumentoResponse result = _mapper.Map<TipoDocumentoResponse>(TipoDocumento);
            return result;
        }

        public List<TipoDocumentoResponse> UpdateMultiple(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            TipoDocumentos = tipoDocuemntoRepository.UpdateMultiple(TipoDocumentos);
            List<TipoDocumentoResponse> result = _mapper.Map<List<TipoDocumentoResponse>>(TipoDocumentos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = tipoDocuemntoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<TipoDocumentoRequest> lista)
        {
            List<TipoDocumento> TipoDocumentos = _mapper.Map<List<TipoDocumento>>(lista);
            int cantidad = tipoDocuemntoRepository.DeleteMultipleItems(TipoDocumentos);
            return cantidad;
        }
    }

}
