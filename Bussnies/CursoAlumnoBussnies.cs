using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.CursoAlumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class CursoAlumnoBussnies : ICursoAlumnoBussnies
    {
        private readonly ICursoAlumnoRepository _CursoAlumnoRepository;
        private readonly IMapper _mapper;

        public CursoAlumnoBussnies(IMapper mapper) { 
            
            _mapper = mapper;
            _CursoAlumnoRepository = new CursoAlumnoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CursoAlumnoResponse> GetAll()
        {
            List<CursoAlumno> CursoAlumnos = _CursoAlumnoRepository.GetAll();
            List<CursoAlumnoResponse> lstResponse = _mapper.Map<List<CursoAlumnoResponse>>(CursoAlumnos);
            return lstResponse;
        }

        public CursoAlumnoResponse GetById(int id)
        {
            CursoAlumno CursoAlumno = _CursoAlumnoRepository.GetById(id);
            CursoAlumnoResponse resul = _mapper.Map<CursoAlumnoResponse>(CursoAlumno);
            return resul;
        }

        public CursoAlumnoResponse Create(CursoAlumnoRequest entity)
        {
            CursoAlumno CursoAlumno = _mapper.Map<CursoAlumno>(entity);
            CursoAlumno = _CursoAlumnoRepository.Create(CursoAlumno);
            CursoAlumnoResponse result = _mapper.Map<CursoAlumnoResponse>(CursoAlumno);
            return result;
        }
        public List<CursoAlumnoResponse> InsertMultiple(List<CursoAlumnoRequest> lista)
        {
            List<CursoAlumno> CursoAlumnos = _mapper.Map<List<CursoAlumno>>(lista);
            CursoAlumnos = _CursoAlumnoRepository.CreateMultiple(CursoAlumnos);
            List<CursoAlumnoResponse> result = _mapper.Map<List<CursoAlumnoResponse>>(CursoAlumnos);
            return result;
        }

        public CursoAlumnoResponse Update(CursoAlumnoRequest entity)
        {
            CursoAlumno CursoAlumno = _mapper.Map<CursoAlumno>(entity);
            CursoAlumno = _CursoAlumnoRepository.Update(CursoAlumno);
            CursoAlumnoResponse result = _mapper.Map<CursoAlumnoResponse>(CursoAlumno);
            return result;
        }

        public List<CursoAlumnoResponse> UpdateMultiple(List<CursoAlumnoRequest> lista)
        {
            List<CursoAlumno> CursoAlumnos = _mapper.Map<List<CursoAlumno>>(lista);
            CursoAlumnos = _CursoAlumnoRepository.UpdateMultiple(CursoAlumnos);
            List<CursoAlumnoResponse> result = _mapper.Map<List<CursoAlumnoResponse>>(CursoAlumnos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CursoAlumnoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CursoAlumnoRequest> lista)
        {
            List<CursoAlumno> CursoAlumnos = _mapper.Map<List<CursoAlumno>>(lista);
            int cantidad = _CursoAlumnoRepository.DeleteMultipleItems(CursoAlumnos);
            return cantidad;
        }

    }
}
