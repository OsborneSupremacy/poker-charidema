using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IRandomFactory, TimeRandomFactory>();

        serviceCollection.AddScoped<RankFactory>();
        serviceCollection.AddScoped<SuitFactory>();

        serviceCollection.AddScoped<IDealerService, DealerService>();
        serviceCollection.AddScoped<RoundRobinMoveService>();
        serviceCollection.AddScoped<IAutomatonMoveService, AutomatonMoveService>();
        serviceCollection.AddScoped<IUserMoveService, UserMoveService>();
        serviceCollection.AddScoped<IMoveServiceFactory, MoveServiceFactory>();
        serviceCollection.AddScoped<IPhaseService, PhaseService>();
        serviceCollection.AddScoped<IGameService, GameService>();
        serviceCollection.AddScoped<IAnteSetService, AnteSetService>();
        serviceCollection.AddScoped<IMatchService, MatchService>();

        serviceCollection.AddScoped<PlayerFactory>();

        return serviceCollection;
    }
}
