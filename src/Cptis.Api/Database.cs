using Cptis.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Cptis.Api;

public static class Database
{
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

    private static void UseSqlServer(this DbContextOptionsBuilder options, WebApplicationBuilder builder)
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(CptisWriteContext)), sql =>
        {
            sql.MigrationsAssembly(typeof(CptisWriteContext).Assembly.GetName().Name);
            sql.MigrationsHistoryTable("__MIGRATIONS");
        });
    }

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