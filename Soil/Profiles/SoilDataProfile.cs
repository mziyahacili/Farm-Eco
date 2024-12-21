using AutoMapper;
using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;

public class SoilDataProfile : Profile
{
    public SoilDataProfile()
    {
        CreateMap<SoilDataDTO, SoilData>()
            .ConstructUsing(src => new SoilData(
                src.SceneId,
                src.ViewId,
                src.Date,
                src.Cloud,
                src.Notes ?? new List<string>(), 
                src.Q1,
                src.Q3,
                src.Max,
                src.Min,
                src.P10,
                src.P90,
                src.Std,
                src.Median,
                src.Average,
                src.Variance,
                src.Ctime10
            ));
    }
}