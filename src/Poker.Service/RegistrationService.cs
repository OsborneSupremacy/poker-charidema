using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        // services
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
        
        // functions
        serviceCollection.AddSingleton(ClassicHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(ClassicWinnerEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultBestHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultHandCollectionEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultWinningsDistributor.Distribute);
        serviceCollection.AddSingleton(FisherYatesShuffleAlgorithm.Shuffle);
        serviceCollection.AddSingleton(DefaultDealer.Deal);

        return serviceCollection;
    }
}
