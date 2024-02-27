using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class CursoBussnies :ICursoBussnies
    {
        private readonly ICursoRepository _CursoRepository;
        private readonly IMapper _mapper;

        public CursoBussnies(IMapper mapper) { 
        _mapper = mapper;
            _CursoRepository = new CursoRepository();
        
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CursoResponse> GetAll()
        {
            List<Curso> Cursos = _CursoRepository.GetAll();
            List<CursoResponse> lstResponse = _mapper.Map<List<CursoResponse>>(Cursos);
            return lstResponse;
        }

        public CursoResponse GetById(int id)
        {
            Curso Curso = _CursoRepository.GetById(id);
            CursoResponse resul = _mapper.Map<CursoResponse>(Curso);
            return resul;
        }

        public CursoResponse Create(CursoRequest entity)
        {
            Curso Curso = _mapper.Map<Curso>(entity);
            Curso = _CursoRepository.Create(Curso);
            CursoResponse result = _mapper.Map<CursoResponse>(Curso);
            return result;
        }
        public List<CursoResponse> InsertMultiple(List<CursoRequest> lista)
        {
            List<Curso> Cursos = _mapper.Map<List<Curso>>(lista);
            Cursos = _CursoRepository.CreateMultiple(Cursos);
            List<CursoResponse> result = _mapper.Map<List<CursoResponse>>(Cursos);
            return result;
        }

        public CursoResponse Update(CursoRequest entity)
        {
            Curso Curso = _mapper.Map<Curso>(entity);
            Curso = _CursoRepository.Update(Curso);
            CursoResponse result = _mapper.Map<CursoResponse>(Curso);
            return result;
        }

        public List<CursoResponse> UpdateMultiple(List<CursoRequest> lista)
        {
            List<Curso> Cursos = _mapper.Map<List<Curso>>(lista);
            Cursos = _CursoRepository.UpdateMultiple(Cursos);
            List<CursoResponse> result = _mapper.Map<List<CursoResponse>>(Cursos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CursoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CursoRequest> lista)
        {
            List<Curso> Cursos = _mapper.Map<List<Curso>>(lista);
            int cantidad = _CursoRepository.DeleteMultipleItems(Cursos);
            return cantidad;
        }
    }
}
