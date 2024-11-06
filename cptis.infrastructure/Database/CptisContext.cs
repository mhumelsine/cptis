using cptis.domain.ClientDemographics;
using Microsoft.EntityFrameworkCore;

namespace cptis.infrastructure.Database
{
    public class CptisContext: DbContext
    { 
        public DbSet<ClientDemographic> ClientDemographics { get; set; }

        public CptisContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CptisContext).Assembly);
        }
    }
}
