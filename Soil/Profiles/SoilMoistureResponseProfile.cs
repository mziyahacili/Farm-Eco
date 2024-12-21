using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class SoilMoistureResponseProfile : Profile
{
    public SoilMoistureResponseProfile()
    {
        CreateMap<SoilMoistureResponseDTO, SoilMoistureResponse>();
        CreateMap<SoilMoistureResponse, SoilMoistureResponseDTO>();
    }
}