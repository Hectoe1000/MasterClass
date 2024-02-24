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
    public class AlumnoBussnies:IAlumnoBussnies
    {
        private readonly IAlumnoRepository _AlumnoRepository;
        private readonly IMapper _mapper;

        public AlumnoBussnies(IMapper mapper) {
            _mapper= mapper;
            _AlumnoRepository = new AlumnoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<AlumnoResponse> GetAll()
        {
            List<Alumno> Alumnos = _AlumnoRepository.GetAll();
            List<AlumnoResponse> lstResponse = _mapper.Map<List<AlumnoResponse>>(Alumnos);
            return lstResponse;
        }

        public AlumnoResponse GetById(int id)
        {
            Alumno Alumno = _AlumnoRepository.GetById(id);
            AlumnoResponse resul = _mapper.Map<AlumnoResponse>(Alumno);
            return resul;
        }

        public AlumnoResponse Create(AlumnoRequest entity)
        {
            Alumno Alumno = _mapper.Map<Alumno>(entity);
            Alumno = _AlumnoRepository.Create(Alumno);
            AlumnoResponse result = _mapper.Map<AlumnoResponse>(Alumno);
            return result;
        }
        public List<AlumnoResponse> InsertMultiple(List<AlumnoRequest> lista)
        {
            List<Alumno> Alumnos = _mapper.Map<List<Alumno>>(lista);
            Alumnos = _AlumnoRepository.CreateMultiple(Alumnos);
            List<AlumnoResponse> result = _mapper.Map<List<AlumnoResponse>>(Alumnos);
            return result;
        }

        public AlumnoResponse Update(AlumnoRequest entity)
        {
            Alumno Alumno = _mapper.Map<Alumno>(entity);
            Alumno = _AlumnoRepository.Update(Alumno);
            AlumnoResponse result = _mapper.Map<AlumnoResponse>(Alumno);
            return result;
        }

        public List<AlumnoResponse> UpdateMultiple(List<AlumnoRequest> lista)
        {
            List<Alumno> Alumnos = _mapper.Map<List<Alumno>>(lista);
            Alumnos = _AlumnoRepository.UpdateMultiple(Alumnos);
            List<AlumnoResponse> result = _mapper.Map<List<AlumnoResponse>>(Alumnos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _AlumnoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<AlumnoRequest> lista)
        {
            List<Alumno> Alumnos = _mapper.Map<List<Alumno>>(lista);
            int cantidad = _AlumnoRepository.DeleteMultipleItems(Alumnos);
            return cantidad;
        }

    }
}
