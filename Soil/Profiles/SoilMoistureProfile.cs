using Soil.DTOs;
using Soil.Models;

namespace Soil.Profiles;
using AutoMapper;

public class SoilMoistureProfile : Profile
{
    public SoilMoistureProfile()
    {
        CreateMap<SoilMoisture, SoilMoistureDTO>()
            .ForMember(dest => dest.SceneId, opt => opt.MapFrom(src => src.SceneId))
            .ForMember(dest => dest.ViewId, opt => opt.MapFrom(src => src.ViewId))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.Cloud, opt => opt.MapFrom(src => src.Cloud))
            .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
            .ForMember(dest => dest.Q1, opt => opt.MapFrom(src => src.Q1))
            .ForMember(dest => dest.Q3, opt => opt.MapFrom(src => src.Q3))
            .ForMember(dest => dest.Max, opt => opt.MapFrom(src => src.Max))
            .ForMember(dest => dest.Min, opt => opt.MapFrom(src => src.Min))
            .ForMember(dest => dest.P10, opt => opt.MapFrom(src => src.P10))
            .ForMember(dest => dest.P90, opt => opt.MapFrom(src => src.P90))
            .ForMember(dest => dest.Std, opt => opt.MapFrom(src => src.Std))
            .ForMember(dest => dest.Median, opt => opt.MapFrom(src => src.Median))
            .ForMember(dest => dest.Average, opt => opt.MapFrom(src => src.Average))
            .ForMember(dest => dest.Variance, opt => opt.MapFrom(src => src.Variance))
            .ForMember(dest => dest.Ctime10, opt => opt.MapFrom(src => src.Ctime10));
    }
}
