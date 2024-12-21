using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class ResultProfile : Profile
{
    public ResultProfile()
    {
        CreateMap<ResultDTO, Result>();
        CreateMap<Result, ResultDTO>();
    }
}