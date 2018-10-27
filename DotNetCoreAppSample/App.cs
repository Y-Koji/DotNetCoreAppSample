using DotNetCoreAppSample.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreAppSample
{
    public class App
    {
        private ILogger<App> Logger { get; } = new NullLogger<App>();

        public App(ILogger<App> logger)
        {
            Logger = logger;
        }

        public async Task RunAsync()
        {
            Logger.LogTrace("Run Start");

            using (SQLite sqlite = new SQLite())
            {
                await sqlite.Articles.AddAsync(new Article
                {
                    Title = "Sample! - " + Guid.NewGuid().ToString(),
                    Uri = "https://www.google.co.jp/",
                    Description = Guid.NewGuid().ToString(),
                });

                await sqlite.SaveChangesAsync();
            }

            Logger.LogTrace("Run End");
        }
    }
}
