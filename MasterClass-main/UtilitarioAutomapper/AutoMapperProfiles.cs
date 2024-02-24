using AutoMapper;
using BDMaster.Models.DB;
using ResquestResponsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitarioAutomapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();
            CreateMap<TipoDocumentoRequest, TipoDocumentoResponse>().ReverseMap();

            CreateMap<Persona, PersonaRequest>().ReverseMap();
            CreateMap<Persona, PersonaResponse>().ReverseMap();
            CreateMap<PersonaRequest, PersonaResponse>().ReverseMap();

            CreateMap<Apoderado, ApoderadoRequest>().ReverseMap();
            CreateMap<Apoderado, ApoderadoResponse>().ReverseMap();
            CreateMap<ApoderadoRequest, ApoderadoResponse>().ReverseMap();


            CreateMap<Matricula, MatriculaRequest>().ReverseMap();
            CreateMap<Matricula, MatriculaResponse>().ReverseMap();
            CreateMap<MatriculaRequest, MatriculaResponse>().ReverseMap();

            CreateMap<Aula, AulaRequest>().ReverseMap();
            CreateMap<Aula, AulaResponse>().ReverseMap();
            CreateMap<AulaRequest, AulaResponse>().ReverseMap();

            CreateMap<Profesor, ProfesorRequest>().ReverseMap();
            CreateMap<Profesor, ProfesorResponse>().ReverseMap();
            CreateMap<ProfesorRequest, ProfesorResponse>().ReverseMap();

            CreateMap<Grado, GradoRequest>().ReverseMap();
            CreateMap<Grado, GradoResponse>().ReverseMap();
            CreateMap<GradoRequest, GradoResponse>().ReverseMap();


            CreateMap<Curso, CursoRequest>().ReverseMap();
            CreateMap<Curso, CursoResponse>().ReverseMap();
            CreateMap<CursoRequest, CursoResponse>().ReverseMap();

            CreateMap<Alumno, AlumnoRequest>().ReverseMap();
            CreateMap<Alumno, AlumnoResponse>().ReverseMap();
            CreateMap<AlumnoRequest, AlumnoResponse>().ReverseMap();

            CreateMap<CursoAlumno, CursoAlumnoRequest>().ReverseMap();
            CreateMap<CursoAlumno, CursoAlumnoResponse>().ReverseMap();
            CreateMap<CursoAlumnoRequest, CursoAlumnoResponse>().ReverseMap();

            CreateMap<CursoProfesor, CursoProfesorRequest>().ReverseMap();
            CreateMap<CursoProfesor, CursoProfesorResponse>().ReverseMap();
            CreateMap<CursoProfesorRequest, CursoProfesorResponse>().ReverseMap();


            CreateMap<Calificacione, CalificacionesRequest>().ReverseMap();
            CreateMap<Calificacione, CalificacionesResponse>().ReverseMap();
            CreateMap<CalificacionesRequest, CalificacionesResponse>().ReverseMap();

            CreateMap<Rol, RolRequest>().ReverseMap();
            CreateMap<Rol,RolResponse>().ReverseMap();
            CreateMap<RolRequest, RolResponse>().ReverseMap();

            CreateMap<Usuario, UsuarioRequest>().ReverseMap();
            CreateMap<Usuario, UsuarioResponse>().ReverseMap();
            CreateMap<UsuarioRequest, UsuarioResponse>().ReverseMap();

        }
    }
}
