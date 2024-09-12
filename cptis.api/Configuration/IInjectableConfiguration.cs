namespace cptis.api.Configuration
{
    public interface IInjectableConfiguration
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}
