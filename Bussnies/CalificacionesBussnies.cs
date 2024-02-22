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
    public class CalificacionesBussnies:ICalificacionesBussnies
    {
        private readonly ICalificacionesRepository _CalificacionesRepository;
        private readonly IMapper _mapper;
        public CalificacionesBussnies(IMapper mapper) {
        
        _mapper = mapper;
            _CalificacionesRepository =  new CalificacionesRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CalificacionesResponse> GetAll()
        {
            List<Calificacione> Calificacioness = _CalificacionesRepository.GetAll();
            List<CalificacionesResponse> lstResponse = _mapper.Map<List<CalificacionesResponse>>(Calificacioness);
            return lstResponse;
        }

        public CalificacionesResponse GetById(int id)
        {
            Calificacione Calificaciones = _CalificacionesRepository.GetById(id);
            CalificacionesResponse resul = _mapper.Map<CalificacionesResponse>(Calificaciones);
            return resul;
        }

        public CalificacionesResponse Create(CalificacionesRequest entity)
        {
            Calificacione Calificaciones = _mapper.Map<Calificacione>(entity);
            Calificaciones = _CalificacionesRepository.Create(Calificaciones);
            CalificacionesResponse result = _mapper.Map<CalificacionesResponse>(Calificaciones);
            return result;
        }
        public List<CalificacionesResponse> InsertMultiple(List<CalificacionesRequest> lista)
        {
            List<Calificacione> Calificacioness = _mapper.Map<List<Calificacione>>(lista);
            Calificacioness = _CalificacionesRepository.CreateMultiple(Calificacioness);
            List<CalificacionesResponse> result = _mapper.Map<List<CalificacionesResponse>>(Calificacioness);
            return result;
        }

        public CalificacionesResponse Update(CalificacionesRequest entity)
        {
            Calificacione Calificaciones = _mapper.Map<Calificacione>(entity);
            Calificaciones = _CalificacionesRepository.Update(Calificaciones);
            CalificacionesResponse result = _mapper.Map<CalificacionesResponse>(Calificaciones);
            return result;
        }

        public List<CalificacionesResponse> UpdateMultiple(List<CalificacionesRequest> lista)
        {
            List<Calificacione> Calificacioness = _mapper.Map<List<Calificacione>>(lista);
            Calificacioness = _CalificacionesRepository.UpdateMultiple(Calificacioness);
            List<CalificacionesResponse> result = _mapper.Map<List<CalificacionesResponse>>(Calificacioness);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CalificacionesRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CalificacionesRequest> lista)
        {
            List<Calificacione> Calificacioness = _mapper.Map<List<Calificacione>>(lista);
            int cantidad = _CalificacionesRepository.DeleteMultipleItems(Calificacioness);
            return cantidad;
        }
    }
}
