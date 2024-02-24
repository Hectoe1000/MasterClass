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
    public class ApoderadoBussnies : IApoderadoBussnies
    {

        private readonly IApoderadoRepository _apoderadoRepository;
        private readonly IMapper _mapper;

        public ApoderadoBussnies(IMapper mapper) { 
            
            _mapper=mapper;
            _apoderadoRepository=new ApoderadoRepository();
        
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ApoderadoResponse> GetAll()
        {
            List<Apoderado> Apoderados = _apoderadoRepository.GetAll();
            List<ApoderadoResponse> lstResponse = _mapper.Map<List<ApoderadoResponse>>(Apoderados);
            return lstResponse;
        }

        public ApoderadoResponse GetById(int id)
        {
            Apoderado Apoderado = _apoderadoRepository.GetById(id);
            ApoderadoResponse resul = _mapper.Map<ApoderadoResponse>(Apoderado);
            return resul;
        }

        public ApoderadoResponse Create(ApoderadoRequest entity)
        {
            Apoderado Apoderado = _mapper.Map<Apoderado>(entity);
            Apoderado = _apoderadoRepository.Create(Apoderado);
            ApoderadoResponse result = _mapper.Map<ApoderadoResponse>(Apoderado);
            return result;
        }
        public List<ApoderadoResponse> InsertMultiple(List<ApoderadoRequest> lista)
        {
            List<Apoderado> Apoderados = _mapper.Map<List<Apoderado>>(lista);
            Apoderados = _apoderadoRepository.CreateMultiple(Apoderados);
            List<ApoderadoResponse> result = _mapper.Map<List<ApoderadoResponse>>(Apoderados);
            return result;
        }

        public ApoderadoResponse Update(ApoderadoRequest entity)
        {
            Apoderado Apoderado = _mapper.Map<Apoderado>(entity);
            Apoderado = _apoderadoRepository.Update(Apoderado);
            ApoderadoResponse result = _mapper.Map<ApoderadoResponse>(Apoderado);
            return result;
        }

        public List<ApoderadoResponse> UpdateMultiple(List<ApoderadoRequest> lista)
        {
            List<Apoderado> Apoderados = _mapper.Map<List<Apoderado>>(lista);
            Apoderados = _apoderadoRepository.UpdateMultiple(Apoderados);
            List<ApoderadoResponse> result = _mapper.Map<List<ApoderadoResponse>>(Apoderados);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _apoderadoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<ApoderadoRequest> lista)
        {
            List<Apoderado> Apoderados = _mapper.Map<List<Apoderado>>(lista);
            int cantidad = _apoderadoRepository.DeleteMultipleItems(Apoderados);
            return cantidad;
        }
    }
}
