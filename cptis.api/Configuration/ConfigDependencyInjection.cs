using System.Reflection;

namespace cptis.api.Configuration
{
    public static class ConfigDependencyInjection
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services,
            IConfiguration configuration,
            params Assembly[] assemblies)
        {
            IEnumerable<IInjectableConfiguration> injectableServices = assemblies
                .SelectMany(a => a.DefinedTypes)
                .Where(IsAssignableToType<IInjectableConfiguration>)
                .Select(Activator.CreateInstance)
                .Cast<IInjectableConfiguration>();

            foreach (IInjectableConfiguration serviceInstaller in injectableServices)
            {
                serviceInstaller.Register(services, configuration);
            }

            return services;

            static bool IsAssignableToType<T>(TypeInfo typeInfo) =>
                typeof(T).IsAssignableFrom(typeInfo) &&
                !typeInfo.IsInterface &&
                !typeInfo.IsAbstract;
        }
    }
}
