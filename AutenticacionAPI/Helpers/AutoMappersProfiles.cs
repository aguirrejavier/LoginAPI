using AutenticacionAPI.Dtos;
using AutenticacionAPI.Models;
using AutoMapper;

namespace AutenticacionAPI.Helpers
{
    public class AutoMappersProfiles : Profile
    {
        public AutoMappersProfiles()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
