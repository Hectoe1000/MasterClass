using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Matricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class MatriculaBussnies:IMatriculaBussnies
    {

        private readonly IMatriculaRespository _matriculaRepository;
        private readonly IMapper _mapper;

        public MatriculaBussnies(IMapper mapper) {
            _mapper = mapper;
            _matriculaRepository= new MatriculaRepository();
            
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<MatriculaResponse> GetAll()
        {
            List<Matricula> Matriculas = _matriculaRepository.GetAll();
            List<MatriculaResponse> lstResponse = _mapper.Map<List<MatriculaResponse>>(Matriculas);
            return lstResponse;
        }

        public MatriculaResponse GetById(int id)
        {
            Matricula Matricula = _matriculaRepository.GetById(id);
            MatriculaResponse resul = _mapper.Map<MatriculaResponse>(Matricula);
            return resul;
        }

        public MatriculaResponse Create(MatriculaRequest entity)
        {
            Matricula Matricula = _mapper.Map<Matricula>(entity);
            Matricula = _matriculaRepository.Create(Matricula);
            MatriculaResponse result = _mapper.Map<MatriculaResponse>(Matricula);
            return result;
        }
        public List<MatriculaResponse> InsertMultiple(List<MatriculaRequest> lista)
        {
            List<Matricula> Matriculas = _mapper.Map<List<Matricula>>(lista);
            Matriculas = _matriculaRepository.CreateMultiple(Matriculas);
            List<MatriculaResponse> result = _mapper.Map<List<MatriculaResponse>>(Matriculas);
            return result;
        }

        public MatriculaResponse Update(MatriculaRequest entity)
        {
            Matricula Matricula = _mapper.Map<Matricula>(entity);
            Matricula = _matriculaRepository.Update(Matricula);
            MatriculaResponse result = _mapper.Map<MatriculaResponse>(Matricula);
            return result;
        }

        public List<MatriculaResponse> UpdateMultiple(List<MatriculaRequest> lista)
        {
            List<Matricula> Matriculas = _mapper.Map<List<Matricula>>(lista);
            Matriculas = _matriculaRepository.UpdateMultiple(Matriculas);
            List<MatriculaResponse> result = _mapper.Map<List<MatriculaResponse>>(Matriculas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _matriculaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<MatriculaRequest> lista)
        {
            List<Matricula> Matriculas = _mapper.Map<List<Matricula>>(lista);
            int cantidad = _matriculaRepository.DeleteMultipleItems(Matriculas);
            return cantidad;
        }
    }
}
