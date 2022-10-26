using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Models.Domain;

namespace NZWalks.Api.Data
{
    public class NZWalkDbContext: DbContext
    {
        public NZWalkDbContext(DbContextOptions<NZWalkDbContext> options): base(options)
        {

        }

        DbSet<Region> Regions { get;set; }
        DbSet<Walk> Walks { get;set; }
        DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
