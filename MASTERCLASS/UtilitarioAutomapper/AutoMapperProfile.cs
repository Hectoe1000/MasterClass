using AutoMapper;
using BDMaster.Models.DB;
using ResquestResponsModel;

namespace UtilitarioAutomapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {


            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();
            CreateMap<TipoDocumentoResponse, TipoDocumentoRequest>().ReverseMap();
        }
       
    }
}
