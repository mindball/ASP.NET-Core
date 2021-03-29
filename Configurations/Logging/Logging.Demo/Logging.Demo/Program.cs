using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log entry level on  Program
            var host = CreateHostBuilder(args).Build();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Start programs");
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .ConfigureLogging((context, logging) =>
             {
                 //Providers:
                 // EventSource is by default, EventLog, TraceSource, AzureAppServiceFiles, AzureAppServicesBlob, ApplicationInsights
                 // clear all providers who listings for logging events                 
                 logging.ClearProviders();
                 //Configure our logger for: who listing, what listing ant etc.
                 logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                 //add our loggers
                 logging.AddDebug(); //debug windows in VS
                 logging.AddConsole(); //Kestrel console 
                 
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
