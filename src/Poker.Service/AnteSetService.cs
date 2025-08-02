namespace Poker.Service;

/// <inheritdoc />
internal class AnteSetService : IAnteSetService
{
    private readonly IRandomService _randomService;

    private readonly IUserInterfaceService _userInterfaceService;

    public AnteSetService(IRandomService randomService, IUserInterfaceService userInterfaceService)
    {
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<int> GetAsync(GameRequest request, Participant button)
    {
        if (request.Match.AntePreferences.AnteType == AnteTypes.Fixed)
            return Task.FromResult(request.Match.AntePreferences.Fixed);

        var antePreferences = GetAntePreferences(request);

        int anteAmount = button.Automaton switch
        {
            true => _randomService.GetAmount(antePreferences.Min, antePreferences.Max),
            false => GetAnteFromUser(antePreferences)
        };

        return Task.FromResult(anteAmount);
    }

    private static AntePreferences GetAntePreferences(GameRequest request)
    {
        var minPlayerStack = request.Participants.Min(p => p.Stack);

        var antePreferences = request.Match.AntePreferences;

        // all players have enough for max ante
        if (minPlayerStack >= antePreferences.Max)
            return antePreferences;

        var effectivePreferences = antePreferences with
        {
            Min = (minPlayerStack < antePreferences.Min) ? minPlayerStack : antePreferences.Min,
            Max = minPlayerStack
        };

        return effectivePreferences;
    }

    private int GetAnteFromUser(AntePreferences antePrefs)
    {
        int anteAmount = 0;
        _userInterfaceService
            .PromptForMoney(
                "Specify ante amount",
                antePrefs.Min,
                antePrefs.Max,
                _randomService.GetAmount(antePrefs.Min, antePrefs.Max),
                input =>
                {
                    anteAmount = input;
                });
        return anteAmount;
    }
}
