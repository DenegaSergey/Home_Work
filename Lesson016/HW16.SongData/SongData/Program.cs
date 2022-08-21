
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SongData.UI;
using SongData.UI.Extensions;
using Serilog;
using Serilog.Events;



var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((builderContext, services) =>
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .MinimumLevel.Debug()
            .WriteTo.File("/../../Logs/log-.log", fileSizeLimitBytes: 10485760, restrictedToMinimumLevel: LogEventLevel.Debug,
                outputTemplate: "[{Level:u3}] Time:{Timestamp: HH:mm:ss} {Message:lj} {NewLine} {Exception}",
                rollingInterval: RollingInterval.Hour)
            .CreateLogger();
        services.AddServices()
            .AddSingleton<Startup, Startup>()
            .BuildServiceProvider()
            .GetService<Startup>()!
            .Start();
    });
await host.Build().RunAsync();



