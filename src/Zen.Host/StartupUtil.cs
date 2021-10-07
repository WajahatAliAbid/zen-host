using System;

namespace Zen.Host
{
    public class StartupUtil
    {
        public static IServiceProvider From<TStartup>(string[]? args = null) where TStartup : BaseStartup, new()
        {
            var startup = new TStartup();
            return startup.Configure(args ?? new string[0]);
        }

        public static IServiceProvider From<TStartup>(TStartup startup, string[]? args = null) where TStartup : BaseStartup
        {
            return startup.Configure(args ?? new string[0]);
        }
    }
}