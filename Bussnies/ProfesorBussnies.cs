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
    public class ProfesorBussnies : IProfesorBussnies
    {
        private readonly IProfesoRepository _profesorRepository;
        private readonly IMapper _mapper;
        public ProfesorBussnies(IMapper mapper) { 
        _mapper = mapper;
            _profesorRepository = new ProfesorRespository();
        
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProfesorResponse> GetAll()
        {
            List<Profesor> Profesors = _profesorRepository.GetAll();
            List<ProfesorResponse> lstResponse = _mapper.Map<List<ProfesorResponse>>(Profesors);
            return lstResponse;
        }

        public ProfesorResponse GetById(int id)
        {
            Profesor Profesor = _profesorRepository.GetById(id);
            ProfesorResponse resul = _mapper.Map<ProfesorResponse>(Profesor);
            return resul;
        }

        public ProfesorResponse Create(ProfesorRequest entity)
        {
            Profesor Profesor = _mapper.Map<Profesor>(entity);
            Profesor = _profesorRepository.Create(Profesor);
            ProfesorResponse result = _mapper.Map<ProfesorResponse>(Profesor);
            return result;
        }
        public List<ProfesorResponse> InsertMultiple(List<ProfesorRequest> lista)
        {
            List<Profesor> Profesors = _mapper.Map<List<Profesor>>(lista);
            Profesors = _profesorRepository.CreateMultiple(Profesors);
            List<ProfesorResponse> result = _mapper.Map<List<ProfesorResponse>>(Profesors);
            return result;
        }

        public ProfesorResponse Update(ProfesorRequest entity)
        {
            Profesor Profesor = _mapper.Map<Profesor>(entity);
            Profesor = _profesorRepository.Update(Profesor);
            ProfesorResponse result = _mapper.Map<ProfesorResponse>(Profesor);
            return result;
        }

        public List<ProfesorResponse> UpdateMultiple(List<ProfesorRequest> lista)
        {
            List<Profesor> Profesors = _mapper.Map<List<Profesor>>(lista);
            Profesors = _profesorRepository.UpdateMultiple(Profesors);
            List<ProfesorResponse> result = _mapper.Map<List<ProfesorResponse>>(Profesors);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _profesorRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ProfesorRequest> lista)
        {
            List<Profesor> Profesors = _mapper.Map<List<Profesor>>(lista);
            int cantidad = _profesorRepository.DeleteMultipleItems(Profesors);
            return cantidad;
        }
    }
}
