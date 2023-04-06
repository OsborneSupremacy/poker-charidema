using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json");

var configuration = builder.Build();

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<FluentConsoleService>();
        services.AddSingleton<IGamePreferencesService, UiService>();
        services.AddSingleton<IMatchPreferencesService, UiService>();
        services.RegisterStandard();
        services.AddHostedService<ConsoleHostedService>();
    })
    .RunConsoleAsync();
