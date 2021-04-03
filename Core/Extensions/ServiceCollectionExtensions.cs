using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, ICoreModule[] modules)
        {

            foreach (var module in modules)
            {
                module.Load(services);
            }

            return ServiceTool.Create(services);
        }
    }
}
//bu yaptığımız hareket bizim core katmanı da dahil olmak üzere ekleyeceğimiz bütün injectioanları bir arada toplayabileceğimiz bir yapıya dönüştü.