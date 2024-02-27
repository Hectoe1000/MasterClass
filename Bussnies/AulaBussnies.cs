using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Aula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class AulaBussnies : IAulaBussnies
    {
        private readonly IAulaRepositoy _aulaRepository;
        private readonly IMapper _mapper;
        public AulaBussnies(IMapper mapper) {
            _mapper = mapper;
            _aulaRepository = new AulaRepository();
        
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<AulaResponse> GetAll()
        {
            List<Aula> Aulas = _aulaRepository.GetAll();
            List<AulaResponse> lstResponse = _mapper.Map<List<AulaResponse>>(Aulas);
            return lstResponse;
        }

        public AulaResponse GetById(int id)
        {
            Aula Aula = _aulaRepository.GetById(id);
            AulaResponse resul = _mapper.Map<AulaResponse>(Aula);
            return resul;
        }

        public AulaResponse Create(AulaRequest entity)
        {
            Aula Aula = _mapper.Map<Aula>(entity);
            Aula = _aulaRepository.Create(Aula);
            AulaResponse result = _mapper.Map<AulaResponse>(Aula);
            return result;
        }
        public List<AulaResponse> InsertMultiple(List<AulaRequest> lista)
        {
            List<Aula> Aulas = _mapper.Map<List<Aula>>(lista);
            Aulas = _aulaRepository.CreateMultiple(Aulas);
            List<AulaResponse> result = _mapper.Map<List<AulaResponse>>(Aulas);
            return result;
        }

        public AulaResponse Update(AulaRequest entity)
        {
            Aula Aula = _mapper.Map<Aula>(entity);
            Aula = _aulaRepository.Update(Aula);
            AulaResponse result = _mapper.Map<AulaResponse>(Aula);
            return result;
        }

        public List<AulaResponse> UpdateMultiple(List<AulaRequest> lista)
        {
            List<Aula> Aulas = _mapper.Map<List<Aula>>(lista);
            Aulas = _aulaRepository.UpdateMultiple(Aulas);
            List<AulaResponse> result = _mapper.Map<List<AulaResponse>>(Aulas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _aulaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<AulaRequest> lista)
        {
            List<Aula> Aulas = _mapper.Map<List<Aula>>(lista);
            int cantidad = _aulaRepository.DeleteMultipleItems(Aulas);
            return cantidad;
        }
    }
}
