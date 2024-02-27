using AutoMapper;
using BDMaster.Models.DB;
using IBussniess;
using IRepository;
using Repository;
using ResquestResponsModel.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class UsuarioBussnies :IUsuarioBussnies
    {
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioBussnies(IMapper mapper) { 
            _mapper = mapper;
            _UsuarioRepository = new UsuarioRepository(); 
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<UsuarioResponse> GetAll()
        {
            List<Usuario> Usuarios = _UsuarioRepository.GetAll();
            List<UsuarioResponse> lstResponse = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return lstResponse;
        }

        public UsuarioResponse GetById(int id)
        {
            Usuario Usuario = _UsuarioRepository.GetById(id);
            UsuarioResponse resul = _mapper.Map<UsuarioResponse>(Usuario);
            return resul;
        }

        public UsuarioResponse Create(UsuarioRequest entity)
        {
            Usuario Usuario = _mapper.Map<Usuario>(entity);
            Usuario = _UsuarioRepository.Create(Usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(Usuario);
            return result;
        }
        public List<UsuarioResponse> InsertMultiple(List<UsuarioRequest> lista)
        {
            List<Usuario> Usuarios = _mapper.Map<List<Usuario>>(lista);
            Usuarios = _UsuarioRepository.CreateMultiple(Usuarios);
            List<UsuarioResponse> result = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return result;
        }

        public UsuarioResponse Update(UsuarioRequest entity)
        {
            Usuario Usuario = _mapper.Map<Usuario>(entity);
            Usuario = _UsuarioRepository.Update(Usuario);
            UsuarioResponse result = _mapper.Map<UsuarioResponse>(Usuario);
            return result;
        }

        public List<UsuarioResponse> UpdateMultiple(List<UsuarioRequest> lista)
        {
            List<Usuario> Usuarios = _mapper.Map<List<Usuario>>(lista);
            Usuarios = _UsuarioRepository.UpdateMultiple(Usuarios);
            List<UsuarioResponse> result = _mapper.Map<List<UsuarioResponse>>(Usuarios);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _UsuarioRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<UsuarioRequest> lista)
        {
            List<Usuario> Usuarios = _mapper.Map<List<Usuario>>(lista);
            int cantidad = _UsuarioRepository.DeleteMultipleItems(Usuarios);
            return cantidad;
        }

        public UsuarioResponse BuscarPorNombre(string Email)
        {
            UsuarioResponse usuario=_mapper.Map<UsuarioResponse>(_UsuarioRepository.ObtenerPorUserName(Email));
            return usuario;
            
        }

        public Vusuario VistaObtenerPorUserName(string username)
        {
            Vusuario vusuario = _UsuarioRepository.VistaObtenerPorUserName(username);
            return vusuario;
        }
    }
} 
