using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace SpaceXLaunchpadInformation.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .ConfigureAppConfiguration((context, config) =>
                 {
                     var builtConfig = config.Build();
                 })
                .UseSerilog((hostingContext, loggerConfiguration) =>
                 {
                  loggerConfiguration.MinimumLevel.Debug()
                      .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                      .Enrich.FromLogContext()
                      .WriteTo.RollingFile(Path.Combine(hostingContext.HostingEnvironment.ContentRootPath, "logs/log-{Date}.log"));
                 })
                 .UseStartup<Startup>();
    }
}
