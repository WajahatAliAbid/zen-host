using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Zen.Host
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddTransientClassesImplementingBaseClass<TClass>(this IServiceCollection services) where TClass : class
        {
            var assembly = typeof(TClass).Assembly;
            return AddTransientClassesImplementingBaseClass<TClass>(services, assembly);
        } 

        public static IServiceCollection AddTransientClassesImplementingBaseClass<TClass>(this IServiceCollection services, Assembly assembly) where TClass : class
        {
            var types = assembly.GetTypes();
            types = types.Where(opt => opt.IsSubclassOf(typeof(TClass)))
                .ToArray();
            foreach (var item in types)
            {
                services.AddTransient(item);
            }
            return services;
        } 
    }
}