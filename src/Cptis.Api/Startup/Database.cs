using Cptis.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Cptis.Api.Startup;

/// <summary>
/// Handles database registration
/// </summary>
public static class Database
{
    /// <summary>
    /// Adds the database and db contexts to the service collection
    /// </summary>
    /// <param name="builder">The web application builder instance</param>
    /// <returns>The web application builder instance</returns>
    public static WebApplicationBuilder AddDatabase(this WebApplicationBuilder builder)
    {
        Action<DbContextOptionsBuilder> optionsAction = options =>
        {
            if (builder.Environment.IsDevelopment())
            {
                options.EnableSensitiveDataLogging();
            }

            //options.UseSqlServer(builder);

            options.UseSqlite(builder);

            options.UseSnakeCaseNamingConvention();
        };
        
        builder.Services.AddDbContext<CptisWriteContext>(optionsAction);
        builder.Services.AddDbContext<CptisReadContext>(optionsAction);

        return builder;
    }

    /// <summary>
    /// Configures SQL Server as the storage for CptisDbContexts
    /// </summary>
    /// <param name="options">Configuration delegate</param>
    /// <param name="builder">The web application builder instance</param>
    private static void UseSqlServer(this DbContextOptionsBuilder options, WebApplicationBuilder builder)
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(CptisWriteContext)), sql =>
        {
            sql.MigrationsAssembly(typeof(CptisWriteContext).Assembly.GetName().Name);
            sql.MigrationsHistoryTable("__MIGRATIONS");
        });
    }

    /// <summary>
    /// Configures SQLite as the storage for CptisDbContexts and puts database file in OS's user app data folder
    /// </summary>
    /// <param name="options">Configuration delegate</param>
    /// <param name="builder">The web application builder instance</param>
    private static void UseSqlite(this DbContextOptionsBuilder options, WebApplicationBuilder builder)
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        var file = System.IO.Path.Join(path, "cptis.db");

        options.UseSqlite($"Data Source={file}", sql =>
        {
            sql.MigrationsAssembly(typeof(CptisWriteContext).Assembly.GetName().Name);
            sql.MigrationsHistoryTable("__MIGRATIONS");
        });
    }
}