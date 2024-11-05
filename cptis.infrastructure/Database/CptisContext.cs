using Microsoft.EntityFrameworkCore;

namespace cptis.infrastructure.Database
{
    public class CptisContext: DbContext
    {
       /*  public DbSet<PlaceHolder> PlaceHolder { get; set; } */


        public CptisContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CptisContext).Assembly);
        }
    }
}
