using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IRandomFactory, TimeRandomFactory>();

        serviceCollection.AddScoped<DeckFactory>();
        serviceCollection.AddScoped<RankFactory>();
        serviceCollection.AddScoped<SuitFactory>();

        serviceCollection.AddScoped<IDealerService, DealerService>();
        serviceCollection.AddScoped<IGameService, GameService>();
        serviceCollection.AddScoped<IMatchService, MatchService>();

        return serviceCollection;
    }
}
