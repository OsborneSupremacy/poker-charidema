using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IRandomFactory, TimeRandomFactory>();
        serviceCollection.AddScoped<IDealerService, DealerService>();
        serviceCollection.AddScoped<RoundRobinMoveService>();
        serviceCollection.AddScoped<WinnerEvaluationService>();
        serviceCollection.AddScoped<IAutomatonMoveService, AutomatonMoveService>();
        serviceCollection.AddScoped<IUserMoveService, UserMoveService>();
        serviceCollection.AddScoped<IMoveServiceFactory, MoveServiceFactory>();
        serviceCollection.AddScoped<IPhaseService, PhaseService>();
        serviceCollection.AddScoped<IPhaseCoordinator, PhaseCoordinator>();
        serviceCollection.AddScoped<IGameService, GameService>();
        serviceCollection.AddScoped<IGameCoordinator, GameCoordinator>();
        serviceCollection.AddScoped<IAnteSetService, AnteSetService>();
        serviceCollection.AddScoped<IMatchService, MatchService>();

        serviceCollection.AddScoped<PlayerFactory>();

        return serviceCollection;
    }
}
