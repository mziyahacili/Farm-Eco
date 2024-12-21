using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class SoilMoistureRequestProfile : Profile
{
    public SoilMoistureRequestProfile()
    {
        CreateMap<SoilMoistureRequestDTO, SoilMoistureRequest>();
        CreateMap<SoilMoistureRequest, SoilMoistureRequestDTO>();
    }
}