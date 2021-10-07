using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Zen.Host
{
    public abstract class BaseStartup
    {
        internal IServiceProvider Configure(string[] args)
        {
            var services = new ServiceCollection();
            var configurationBuilder = new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables();
            ConfigureAppConfiguration(configurationBuilder);
            var configuration = configurationBuilder.Build();
            services.AddSingleton<IConfigurationRoot>(configurationBuilder.Build());
            ConfigureServices(services, configuration);
            return services.BuildServiceProvider();
        }
        public virtual void ConfigureAppConfiguration(IConfigurationBuilder configuration)
        {
        }

        public abstract void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration);
    }
}