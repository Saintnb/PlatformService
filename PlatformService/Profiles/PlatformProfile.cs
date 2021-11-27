using AutoMapper;
using PlatformService.DTOs;
using PlatformServices.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //source -> target
            CreateMap<Platform, PlatformReadDTO>();
            CreateMap<PlatFormCreateDTO, Platform>();
            CreateMap<PlatformReadDTO, PlatformPublishedDto>();
            CreateMap<Platform, GrpcPlatformModel>()
            .ForMember(dest => dest.PlatformId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Publisher, opt => opt.MapFrom(src => src.Publisher));

        }
    }
}