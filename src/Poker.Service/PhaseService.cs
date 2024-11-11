using Microsoft.Extensions.DependencyInjection;

namespace Poker.Service;

public class PhaseService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IPhaseService _roundRobinMoveService;

    private readonly IPhaseService _winnerEvaluationService;

    private readonly IPhaseService _dealerService;

    private readonly IPhaseService _betCoordinator;

    public PhaseService(
        IUserInterfaceService userInterfaceService,
        [FromKeyedServices("move")] IPhaseService roundRobinMoveService,
        [FromKeyedServices(PhaseType.Deal)] IPhaseService dealerService,
        [FromKeyedServices(PhaseType.Evaluation)] IPhaseService winnerEvaluationService,
        [FromKeyedServices(PhaseType.BettingInterval)] IPhaseService betCoordinator
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _roundRobinMoveService = roundRobinMoveService ?? throw new ArgumentNullException(nameof(roundRobinMoveService));
        _winnerEvaluationService = winnerEvaluationService ?? throw new ArgumentNullException(nameof(winnerEvaluationService));
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
        _betCoordinator = betCoordinator ?? throw new ArgumentNullException(nameof(betCoordinator));
    }

    private Task WriteStartInfoAsync(PhaseRequest request)
    {
        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
            $"{request.Phase.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        await WriteStartInfoAsync(request);

        var phaseService = request.Phase.PhaseType switch
        {
            PhaseType.Deal => _dealerService,
            PhaseType.Evaluation => _winnerEvaluationService,
            PhaseType.BettingInterval => _betCoordinator,
            _ => _roundRobinMoveService
        };

        return await phaseService.ExecuteAsync(request);
    }
}
