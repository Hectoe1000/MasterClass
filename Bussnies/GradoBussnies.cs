using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Grado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class GradoBussnies : IGradoBussnies

    {
        private readonly IGradoRepository _GradoRepository;
        private readonly IMapper _mapper;
        public GradoBussnies(IMapper mapper) { 
        _mapper=mapper;
        _GradoRepository = new GradoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<GradoResponse> GetAll()
        {
            List<Grado> Grados = _GradoRepository.GetAll();
            List<GradoResponse> lstResponse = _mapper.Map<List<GradoResponse>>(Grados);
            return lstResponse;
        }

        public GradoResponse GetById(int id)
        {
            Grado Grado = _GradoRepository.GetById(id);
            GradoResponse resul = _mapper.Map<GradoResponse>(Grado);
            return resul;
        }

        public GradoResponse Create(GradoRequest entity)
        {
            Grado Grado = _mapper.Map<Grado>(entity);
            Grado = _GradoRepository.Create(Grado);
            GradoResponse result = _mapper.Map<GradoResponse>(Grado);
            return result;
        }
        public List<GradoResponse> InsertMultiple(List<GradoRequest> lista)
        {
            List<Grado> Grados = _mapper.Map<List<Grado>>(lista);
            Grados = _GradoRepository.CreateMultiple(Grados);
            List<GradoResponse> result = _mapper.Map<List<GradoResponse>>(Grados);
            return result;
        }

        public GradoResponse Update(GradoRequest entity)
        {
            Grado Grado = _mapper.Map<Grado>(entity);
            Grado = _GradoRepository.Update(Grado);
            GradoResponse result = _mapper.Map<GradoResponse>(Grado);
            return result;
        }

        public List<GradoResponse> UpdateMultiple(List<GradoRequest> lista)
        {
            List<Grado> Grados = _mapper.Map<List<Grado>>(lista);
            Grados = _GradoRepository.UpdateMultiple(Grados);
            List<GradoResponse> result = _mapper.Map<List<GradoResponse>>(Grados);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _GradoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<GradoRequest> lista)
        {
            List<Grado> Grados = _mapper.Map<List<Grado>>(lista);
            int cantidad = _GradoRepository.DeleteMultipleItems(Grados);
            return cantidad;
        }


    }
}
