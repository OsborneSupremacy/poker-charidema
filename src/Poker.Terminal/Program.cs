using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Poker.Service.Abstractions;
using Poker.Terminal.Services;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton(AnsiConsole.Console);
        services.AddSingleton<FluentConsoleService>();
        services.AddSingleton<IUserInterfaceService, FluentConsoleService>();
        services.AddSingleton<IGamePreferencesService, PreferencesService>();
        services.AddSingleton<IMatchPreferencesService, PreferencesService>();
        services.AddSingleton<ILedgerService, LedgerService>()
        services.RegisterStandard();
        services.AddHostedService<ConsoleHostedService>();
    })
    .RunConsoleAsync();
