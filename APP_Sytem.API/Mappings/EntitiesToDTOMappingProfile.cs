using APP_Sytem.API.DTOs;
using APP_Sytem.API.Models;
using AutoMapper;

namespace APP_Sytem.API.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<TbAtor, ClienteDTO>().ReverseMap();
        }
    }
}