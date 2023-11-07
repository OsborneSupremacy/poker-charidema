using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        // utility services
        serviceCollection.AddSingleton<IRandomFactory, TimeRandomFactory>();
        
        // business services
        serviceCollection.AddScoped<PlayerFactory>();
        serviceCollection.AddScoped<IMatchService, MatchService>();
        serviceCollection.AddScoped<IDealerService, DealerService>();
        serviceCollection.AddScoped<IAnteSetService, AnteSetService>();
        
        serviceCollection.AddScoped<IGameCoordinator, GameCoordinator>();
        serviceCollection.AddScoped<IGameService, GameService>();
        
        serviceCollection.AddScoped<IPhaseCoordinator, PhaseCoordinator>();
        serviceCollection.AddScoped<IPhaseService, PhaseService>();
        
        serviceCollection.AddScoped<IMoveServiceFactory, MoveServiceFactory>();
        serviceCollection.AddScoped<IUserMoveService, UserMoveService>();
        serviceCollection.AddScoped<IAutomatonMoveService, AutomatonMoveService>();
        
        // in .net 8, make this a keyed service
        serviceCollection.AddScoped<RoundRobinMoveService>();

        serviceCollection.AddScoped<IBetCoordinator, BetCoordinator>();
        serviceCollection.AddScoped<IBettingIntervalService, BettingIntervalService>();
        serviceCollection.AddScoped<IBettingIntervalOptionsService, BettingIntervalOptionsService>();
        
        // in .net 8, make this a keyed service
        serviceCollection.AddScoped<WinnerEvaluationService>();
        
        // domain functions
        serviceCollection.AddSingleton(DefaultDealer.Deal);
        serviceCollection.AddSingleton(FisherYatesShuffleAlgorithm.Shuffle);
        serviceCollection.AddSingleton(ClassicHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(ClassicWinnerEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultBestHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultHandCollectionEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultWinningsDistributor.Distribute);

        return serviceCollection;
    }
}
