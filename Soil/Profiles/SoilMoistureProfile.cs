using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;
using AutoMapper;

public class SoilMoistureProfile : Profile
{
    public SoilMoistureProfile()
    {
        CreateMap<SoilMoisture, SoilMoistureDTO>()
            .ForMember(dest => dest.SurfaceMoisture, opt => opt.MapFrom(src => src.Average))
            .ForMember(dest => dest.RootZoneMoisture, opt => opt.MapFrom(src => src.Ctime10));
    }
}
