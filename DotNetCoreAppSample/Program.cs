using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;

namespace DotNetCoreAppSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = Configure().GetService<App>();
            app.RunAsync().Wait();
        }

        static IServiceProvider Configure()
        {
            var services = new ServiceCollection();

            services.AddTransient<App>();
            services.AddLogging(builder => builder.SetMinimumLevel(LogLevel.Trace));

            var provider = services.BuildServiceProvider();
            var factory = provider.GetRequiredService<ILoggerFactory>().AddNLog();

            NLog.LogManager.LoadConfiguration("NLog.config");

            return provider;
        }
    }
}
