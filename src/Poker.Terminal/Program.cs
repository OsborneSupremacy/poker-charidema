using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton(AnsiConsole.Console);
        services.AddSingleton<FluentConsoleService>();
        services.AddSingleton<IUserInterfaceService, FluentConsoleService>();
        services.AddSingleton<IGamePreferencesService, PreferencesService>();
        services.AddSingleton<IMatchPreferencesService, PreferencesService>();
        services.RegisterStandard();
        services.AddHostedService<ConsoleHostedService>();
    })
    .RunConsoleAsync();
