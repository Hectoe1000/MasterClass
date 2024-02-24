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
    public class CursoProfesorBussnies:ICursoProfesorBussnies
    {
        private readonly ICursoProfesorRepository _CursoProfesorRepository;
        private readonly IMapper _mapper;

        public CursoProfesorBussnies(IMapper mapper) {
        _mapper = mapper;
            _CursoProfesorRepository = new CursoProfesorRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CursoProfesorResponse> GetAll()
        {
            List<CursoProfesor> CursoProfesors = _CursoProfesorRepository.GetAll();
            List<CursoProfesorResponse> lstResponse = _mapper.Map<List<CursoProfesorResponse>>(CursoProfesors);
            return lstResponse;
        }

        public CursoProfesorResponse GetById(int id)
        {
            CursoProfesor CursoProfesor = _CursoProfesorRepository.GetById(id);
            CursoProfesorResponse resul = _mapper.Map<CursoProfesorResponse>(CursoProfesor);
            return resul;
        }

        public CursoProfesorResponse Create(CursoProfesorRequest entity)
        {
            CursoProfesor CursoProfesor = _mapper.Map<CursoProfesor>(entity);
            CursoProfesor = _CursoProfesorRepository.Create(CursoProfesor);
            CursoProfesorResponse result = _mapper.Map<CursoProfesorResponse>(CursoProfesor);
            return result;
        }
        public List<CursoProfesorResponse> InsertMultiple(List<CursoProfesorRequest> lista)
        {
            List<CursoProfesor> CursoProfesors = _mapper.Map<List<CursoProfesor>>(lista);
            CursoProfesors = _CursoProfesorRepository.CreateMultiple(CursoProfesors);
            List<CursoProfesorResponse> result = _mapper.Map<List<CursoProfesorResponse>>(CursoProfesors);
            return result;
        }

        public CursoProfesorResponse Update(CursoProfesorRequest entity)
        {
            CursoProfesor CursoProfesor = _mapper.Map<CursoProfesor>(entity);
            CursoProfesor = _CursoProfesorRepository.Update(CursoProfesor);
            CursoProfesorResponse result = _mapper.Map<CursoProfesorResponse>(CursoProfesor);
            return result;
        }

        public List<CursoProfesorResponse> UpdateMultiple(List<CursoProfesorRequest> lista)
        {
            List<CursoProfesor> CursoProfesors = _mapper.Map<List<CursoProfesor>>(lista);
            CursoProfesors = _CursoProfesorRepository.UpdateMultiple(CursoProfesors);
            List<CursoProfesorResponse> result = _mapper.Map<List<CursoProfesorResponse>>(CursoProfesors);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CursoProfesorRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CursoProfesorRequest> lista)
        {
            List<CursoProfesor> CursoProfesors = _mapper.Map<List<CursoProfesor>>(lista);
            int cantidad = _CursoProfesorRepository.DeleteMultipleItems(CursoProfesors);
            return cantidad;
        }
    }
}
