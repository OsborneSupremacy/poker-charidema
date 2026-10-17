namespace Poker.Service;

public static class RegistrationService
{
    public static IServiceCollection RegisterStandard(this IServiceCollection serviceCollection)
    {
        // utility services
        serviceCollection.AddSingleton<IRandomFactory, SystemRandomFactory>();
        serviceCollection.AddSingleton<IRandomService, RandomService>();

        // business services
        serviceCollection.AddScoped<IPlayerFactory, PlayerFactory>();
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
        serviceCollection.AddScoped<ILeadPlayerService, LeadParticipantService>();

        serviceCollection.AddScoped<IUserDiscardSelectionService, UserDiscardSelectionService>();
        serviceCollection.AddScoped<IAutomatonDiscardSelectionService, AutomatonDiscardSelectionService>();

        serviceCollection.AddKeyedScoped<IPhaseService, DealerService>(PhaseType.Deal);
        serviceCollection.AddKeyedScoped<IPhaseService, RoundRobinMoveService>("move");
        serviceCollection.AddKeyedScoped<IPhaseService, BetCoordinator>(PhaseType.BettingInterval);
        serviceCollection.AddKeyedScoped<IPhaseService, DrawCoordinator>(PhaseType.Draw);
        serviceCollection.AddKeyedScoped<IPhaseService, WinnerEvaluationService>(PhaseType.Evaluation);

        // domain functions
        serviceCollection.AddSingleton(DefaultDealer.Deal);
        serviceCollection.AddSingleton(DefaultDrawer.Draw);
        serviceCollection.AddSingleton(DefaultDiscardStrategy.Select);
        serviceCollection.AddSingleton(FisherYatesShuffleAlgorithm.Shuffle);
        serviceCollection.AddSingleton(ClassicHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(ClassicWinnerEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultBestHandEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultHandCollectionEvaluator.Evaluate);
        serviceCollection.AddSingleton(DefaultWinningsDistributor.Distribute);

        return serviceCollection;
    }
}
