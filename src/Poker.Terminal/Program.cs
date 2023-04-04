using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Poker.Interface;
using Poker.Service;
using Poker.Terminal;
using Poker.Terminal.Service;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json");

var configuration = builder.Build();

var uiService = new UiService();

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<IGamePreferencesService>(uiService);
        services.AddSingleton<IMatchPreferencesService>(uiService);
        services.RegisterStandard();
        services.AddHostedService<ConsoleHostedService>();
    })
    .RunConsoleAsync();
