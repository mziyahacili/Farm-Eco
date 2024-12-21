using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class GeometryProfile : Profile
{
    public GeometryProfile()
    {
        CreateMap<GeometryDTO, Geometry>();
        CreateMap<Geometry, GeometryDTO>();
    }
}