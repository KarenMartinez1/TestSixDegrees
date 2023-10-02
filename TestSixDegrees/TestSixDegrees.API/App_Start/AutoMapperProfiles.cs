using AutoMapper;
using TestSixDegrees.Domain;
using TestSixDegrees.Domain.Dtos;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Usuario, DataUsuario>()
            .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => $"{src.Nombre} {src.Apellido}"));
    }
}