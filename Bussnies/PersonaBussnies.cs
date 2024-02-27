using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class PersonaBussnies : IPersonaBussnies

    {
        #region TRAER LOS METODOS DE LA BASE DE DATOS 
        private readonly IPersonaRepository _personaRepository; 
        private readonly IMapper _mapper;
        #endregion
        public PersonaBussnies(IMapper mapper) { 
            
            _mapper=mapper;
            _personaRepository = new PersonaRepository();//IGUALAMOS LAS CONSULTAS SQL DE BASE DE DATOS 
        
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<PersonaResponse> GetAll()
        {
            List<Persona> Personas =_personaRepository.GetAll();
            List<PersonaResponse> lstResponse = _mapper.Map<List<PersonaResponse>>(Personas);
            return lstResponse;
        }

        public PersonaResponse GetById(int id)
        {
            Persona Persona =_personaRepository.GetById(id);
            PersonaResponse resul = _mapper.Map<PersonaResponse>(Persona);
            return resul;
        }

        public PersonaResponse Create(PersonaRequest entity)
        {
            Persona Persona = _mapper.Map<Persona>(entity);
            Persona =_personaRepository.Create(Persona);
            PersonaResponse result = _mapper.Map<PersonaResponse>(Persona);
            return result;
        }
        public List<PersonaResponse> InsertMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            Personas =_personaRepository.CreateMultiple(Personas);
            List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
            return result;
        }

        public PersonaResponse Update(PersonaRequest entity)
        {
            Persona Persona = _mapper.Map<Persona>(entity);
            Persona =_personaRepository.Update(Persona);
            PersonaResponse result = _mapper.Map<PersonaResponse>(Persona);
            return result;
        }

        public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            Personas =_personaRepository.UpdateMultiple(Personas);
            List<PersonaResponse> result = _mapper.Map<List<PersonaResponse>>(Personas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad =_personaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PersonaRequest> lista)
        {
            List<Persona> Personas = _mapper.Map<List<Persona>>(lista);
            int cantidad =_personaRepository.DeleteMultipleItems(Personas);
            return cantidad;
        }
    }
}
