namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        // utility services
        serviceCollection.AddSingleton<IRandomFactory, TimeRandomFactory>();
        serviceCollection.AddSingleton<IRandomService, RandomService>();

        // business services
        serviceCollection.AddScoped<PlayerFactory>();
        serviceCollection.AddScoped<IMatchService, MatchService>();
        serviceCollection.AddScoped<IDealerService, DealerService>();
        serviceCollection.AddScoped<IAnteSetService, AnteSetService>();

        serviceCollection.AddScoped<IGameCoordinator, GameCoordinator>();
        serviceCollection.AddScoped<IGameService, GameService>();

        serviceCollection.AddScoped<IPhaseCoordinator, PhaseCoordinator>();
        serviceCollection.AddScoped<IPhaseService, PhaseService>();

        serviceCollection.AddScoped<IBettingIntervalService, BettingIntervalService>();
        serviceCollection.AddScoped<IBettingIntervalOptionsService, BettingIntervalOptionsService>();

        serviceCollection.AddScoped<IMoveServiceFactory, MoveServiceFactory>();
        serviceCollection.AddScoped<IUserMoveService, UserMoveService>();
        serviceCollection.AddScoped<IAutomatonMoveService, AutomatonMoveService>();
        serviceCollection.AddScoped<ILeadPlayerService, LeadPlayerService>();

        serviceCollection.AddKeyedScoped<IPhaseService, DealerService>(PhaseType.Deal);
        serviceCollection.AddKeyedScoped<IPhaseService, RoundRobinMoveService>("move");
        serviceCollection.AddKeyedScoped<IPhaseService, BetCoordinator>(PhaseType.BettingInterval);
        serviceCollection.AddKeyedScoped<IPhaseService, WinnerEvaluationService>(PhaseType.Evaluation);

        serviceCollection.AddScoped<IBettingIntervalService, BettingIntervalService>();
        serviceCollection.AddScoped<IBettingIntervalOptionsService, BettingIntervalOptionsService>();

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
