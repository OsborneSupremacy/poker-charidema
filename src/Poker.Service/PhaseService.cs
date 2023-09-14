using Poker.Library.Phases;
using Poker.Library.Rounds;

namespace Poker.Service;

public class PhaseService : IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IPhaseService _roundRobinMoveService;

    private readonly IPhaseService _dealerService;

    public PhaseService(
        IUserInterfaceService userInterfaceService,
        RoundRobinMoveService roundRobinMoveService,
        IDealerService dealerService
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _roundRobinMoveService = roundRobinMoveService ?? throw new ArgumentNullException(nameof(roundRobinMoveService));
        _dealerService = dealerService as IPhaseService ?? throw new ArgumentNullException(nameof(dealerService));
    }

    protected Task WriteStartInfoAsync(PhaseArgs args)
    {
        _userInterfaceService.WriteHeading(
            HeadingLevel.Five,
            $"{args.Phase.Name}"
        );

        return Task.CompletedTask;
    }

    public async Task<PhaseResult> ExecuteAsync(PhaseArgs args)
    {
        await WriteStartInfoAsync(args);

        var phaseService = args.Phase switch
        {
            DealCards => _dealerService,
            _ => _roundRobinMoveService
        };

        return await phaseService.ExecuteAsync(args);
    }
}
