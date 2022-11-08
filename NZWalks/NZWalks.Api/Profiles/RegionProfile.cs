using AutoMapper;
using NZWalks.Api.Models.Domain;
using NZWalks.Api.Models.DTO;

namespace NZWalks.Api.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
                CreateMap<Region, RegionDTO>();
        }


    }
}
