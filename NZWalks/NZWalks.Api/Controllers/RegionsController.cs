using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Models.Domain;
using NZWalks.Api.Models.DTO;
using NZWalks.Api.Repositories;

namespace NZWalks.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this._mapper = mapper;
            
        }

        

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
           // List<Region> regions = new List<Region>()
           //{
           //    new Region()
           //    {
           //        Name ="Wellington",
           //        Id = Guid.NewGuid(),
           //        Code = "WGT",
           //        Area =2000,
           //        Lat = -123.65,
           //        Long =234.67,
           //        Population =500000
           //    },
           //     new Region()
           //    {
           //        Name ="Auckland",
           //        Id =  Guid.NewGuid(),
           //        Code = "ALD",
           //        Area =2000,
           //        Lat = -123.65,
           //        Long =234.67,
           //        Population =500000
           //    }
           //};

            var regions= await regionRepository.GetAllAsync();
            //var regionsDTO = new List<Models.DTO.RegionDTO>();
            //regions.ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.RegionDTO() {
            //    Id = region.Id,
            //    Name = region.Name,
            //    Code = region.Code,
            //    Area = region.Area,
            //    Lat = region.Lat,
            //    Long = region.Long,
            //    Population = region.Population,
            //    };
            //    regionsDTO.Add(regionDTO);

            //}

            //);

            //return DTO
            var regionsDTO = _mapper.Map<List<RegionDTO>>(regions);

            return Ok(regionsDTO);


        }
    }
}
