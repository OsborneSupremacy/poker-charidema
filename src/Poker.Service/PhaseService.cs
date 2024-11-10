namespace Poker.Service;

public class PhaseService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IPhaseService _roundRobinMoveService;

    private readonly IPhaseService _winnerEvaluationService;

    private readonly IPhaseService _dealerService;

    public PhaseService(
        IUserInterfaceService userInterfaceService,
        RoundRobinMoveService roundRobinMoveService,
        IDealerService dealerService,
        WinnerEvaluationService winnerEvaluationService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _roundRobinMoveService = roundRobinMoveService ?? throw new ArgumentNullException(nameof(roundRobinMoveService));
        _winnerEvaluationService = winnerEvaluationService as IPhaseService ?? throw new ArgumentNullException(nameof(dealerService));
        _dealerService = dealerService as IPhaseService ?? throw new ArgumentNullException(nameof(dealerService));
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
            _ => _roundRobinMoveService
        };

        return await phaseService.ExecuteAsync(request);
    }
}
