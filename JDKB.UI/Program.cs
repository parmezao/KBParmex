using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using Serilog.Sinks.MSSqlServer;
using System;
using System.IO;

namespace JDKB.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environment}.json", true)
                .Build();

            // Create the logger
            var options = new ColumnOptions();
            options.Store.Remove(StandardColumn.Properties);
            options.Store.Add(StandardColumn.LogEvent);

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .Enrich.WithExceptionDetails()
                .Enrich.WithMachineName()
                .Enrich.WithProperty("Application", "JDKB")
                .Enrich.WithProperty("Environment", Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))
                .Enrich.WithEnvironmentUserName()
                .Enrich.WithProcessId()
                .Enrich.WithProcessName()
                .ReadFrom.Configuration(configuration)
                .WriteTo.Async(a =>
                {
                    a.MSSqlServer(configuration.GetConnectionString("JDConexao"), "TBJKB_LOG", period: TimeSpan.FromMilliseconds(500), columnOptions: options);
                    a.ColoredConsole(LogEventLevel.Verbose, "{NewLine}{Timestamp:HH:mm:ss.fff} [{Level}] ({CorrelationToken}) {Message}{NewLine}{Exception} {Properties:j}");
                    a.File(new CompactJsonFormatter(), ".\\logs\\log_.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 1024 * 1024 * 20, buffered: true, flushToDiskInterval: TimeSpan.FromSeconds(5), rollOnFileSizeLimit: true);
                }, bufferSize: 500)
                .CreateLogger();

            try 
            { 
                CreateWebHostBuilder(args).Build().Run();
            }
            finally
            {
                // Close and flush de log.
                Log.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            return WebHost.CreateDefaultBuilder(args)
                //.UseConfiguration(config)
                .UseSerilog()
                .UseStartup<Startup>();            
        }
    }
}
