using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Data;
using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalkDbContext _context;

        public RegionRepository(NZWalkDbContext context)
        {
            this._context = context;
        }


      public  async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await this._context.Regions.ToListAsync();
        }
    }
}
