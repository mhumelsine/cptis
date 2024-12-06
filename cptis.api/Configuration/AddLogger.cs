
using cptis.infrastructure.Services;
using NLog.Extensions.Logging;

namespace cptis.api.Configuration
{
    public class AddLogger : IInjectableConfiguration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging(loggingBuilder =>
             {
                 loggingBuilder.ClearProviders();
                 loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                 loggingBuilder.AddNLog();
             });
            services.AddScoped<ILogger, LoggerManager>();
        }
    }

}
