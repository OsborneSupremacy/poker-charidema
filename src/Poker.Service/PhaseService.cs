
namespace Poker.Service;

/// <inheritdoc />
internal class PhaseService : IPhaseService
{
    private readonly IPhaseService _roundRobinMoveService;

    private readonly IPhaseService _winnerEvaluationService;

    private readonly IPhaseService _dealerService;

    private readonly IPhaseService _betCoordinator;

    public PhaseService(
        [FromKeyedServices("move")] IPhaseService roundRobinMoveService,
        [FromKeyedServices(PhaseType.Deal)] IPhaseService dealerService,
        [FromKeyedServices(PhaseType.Evaluation)] IPhaseService winnerEvaluationService,
        [FromKeyedServices(PhaseType.BettingInterval)] IPhaseService betCoordinator
        )
    {
        _roundRobinMoveService = roundRobinMoveService ?? throw new ArgumentNullException(nameof(roundRobinMoveService));
        _winnerEvaluationService = winnerEvaluationService ?? throw new ArgumentNullException(nameof(winnerEvaluationService));
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _betCoordinator = betCoordinator ?? throw new ArgumentNullException(nameof(betCoordinator));
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        var phaseService = request.Phase.PhaseType switch
        {
            PhaseType.Deal => _dealerService,
            PhaseType.Evaluation => _winnerEvaluationService,
            PhaseType.BettingInterval => _betCoordinator,
            // move service covers phases like ante and draw
            _ => _roundRobinMoveService
        };

        return await phaseService.ExecuteAsync(request);
    }
}
