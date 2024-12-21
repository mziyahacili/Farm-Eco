using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;
using AutoMapper;

public class SoilMoistureProfile : Profile
{
    public SoilMoistureProfile()
    {
        CreateMap<SoilMoistureDTO, SoilMoisture>();
        CreateMap<SoilMoisture, SoilMoistureDTO>();
    }
}
