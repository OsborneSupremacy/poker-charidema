namespace Poker.Service;

/// <inheritdoc />
internal class UserBettingIntervalActionSelectionService : IUserBettingIntervalActionSelectionService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public UserBettingIntervalActionSelectionService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<BettingIntervalActionSelectionResponse> SelectAsync(BettingIntervalActionSelectionRequest request)
    {
        // a player who can't afford the full call goes all-in with what they have left
        var amountToCall = Math.Min(request.Options.RequiredAmountToCall, request.ParticipantInTurn.Stack);

        _userInterfaceService.WriteLine(
            $"The pot is {request.Pot:C0}. You have {request.ParticipantInTurn.Stack:C0}." +
            (amountToCall > 0 ? $" It's {amountToCall:C0} to call." : string.Empty)
        );

        var options = request.Options.AvailableBettingIntervalActions
            .Select(o => new ActionOption(GetOptionName(o.BettingIntervalActionType, amountToCall), () => o.BettingIntervalActionType))
            .ToArray<IInputOption<BettingIntervalActionType>>();

        var actionType = _userInterfaceService
            .PromptForOption("What do you want to do?", options)
            .GetValue();

        return Task.FromResult(
            new BettingIntervalActionSelectionResponse
            {
                BettingIntervalActionType = actionType,
                Amount = actionType switch
                {
                    BettingIntervalActionType.Bet => PromptForAmount("How much do you want to bet?", request.Options.MaximumBet),
                    BettingIntervalActionType.Raise => PromptForAmount("How much do you want to raise?", request.Options.MaximumBet),
                    _ => 0
                }
            }
        );
    }

    private int PromptForAmount(string prompt, int maximum)
    {
        var amount = 0;
        _userInterfaceService.PromptForMoney(prompt, 1, maximum, 1, input => amount = input);
        return amount;
    }

    private static string GetOptionName(BettingIntervalActionType actionType, int amountToCall) =>
        actionType switch
        {
            BettingIntervalActionType.Call => $"Call {amountToCall:C0}",
            _ => actionType.ToString()
        };

    private record ActionOption(string Name, Func<BettingIntervalActionType> GetValue)
        : IInputOption<BettingIntervalActionType>;
}
