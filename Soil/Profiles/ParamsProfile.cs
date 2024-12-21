using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class ParamsProfile : Profile
{
    public ParamsProfile()
    {
        CreateMap<ParamsDTO, Params>();
        CreateMap<Params, ParamsDTO>();
    }
}