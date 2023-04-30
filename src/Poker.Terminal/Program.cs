using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Poker.Presentation.Interface;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json");

var configuration = builder.Build();

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<FluentConsoleService>();
        services.AddSingleton<IUserInterfaceService, FluentConsoleService>();
        services.AddSingleton<IGamePreferencesService, PreferencesService>();
        services.AddSingleton<IMatchPreferencesService, PreferencesService>();
        services.RegisterStandard();
        services.AddHostedService<ConsoleHostedService>();
    })
    .RunConsoleAsync();
