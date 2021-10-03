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
        }
    }
}