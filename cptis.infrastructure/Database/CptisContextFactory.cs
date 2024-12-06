using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace cptis.infrastructure.Database
{
    public class CptisContextFactory : IDesignTimeDbContextFactory<CptisContext>
    {
        public CptisContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile(Path.Combine(basePath, "..", "cptis.api", "appsettings.json"))
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CptisContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            return new CptisContext(optionsBuilder.Options);
        }
    }
}
