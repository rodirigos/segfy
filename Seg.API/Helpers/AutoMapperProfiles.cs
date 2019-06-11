using AutoMapper;
using Seg.API.Dtos;
using Seg.API.Models;

namespace Seg.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Insurance, InsuranceForCreationDto>();
            CreateMap<InsuranceForCreationDto,Insurance>();
        }
    }
}