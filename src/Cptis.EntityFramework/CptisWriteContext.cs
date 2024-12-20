using Microsoft.EntityFrameworkCore;

namespace Cptis.EntityFramework;

public class CptisWriteContext : DbContext
{
    public CptisWriteContext(DbContextOptions<CptisWriteContext> options)
        :base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Configuration.ClientConfiguration).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
    
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        //default all strings to varchar(100) unless overridden
        configurationBuilder
            .Properties<string>()
            .AreUnicode(false)
            .HaveMaxLength(100);
    }

    public DbSet<Core.Client> Clients { get; set; }
}