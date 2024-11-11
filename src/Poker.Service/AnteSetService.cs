namespace Poker.Service;

public class AnteSetService : IAnteSetService
{
    private readonly IRandomService _randomService;

    private readonly IUserInterfaceService _userInterfaceService;

    public AnteSetService(IRandomService randomService, IUserInterfaceService userInterfaceService)
    {
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<int> GetAsync(GameRequest request, Player button)
    {
        if (request.Match.AntePreferences.AnteType == AnteTypes.Fixed)
            return Task.FromResult(request.Match.AntePreferences.Fixed);

        var antePrefs = GetAntePrefs(request);

        int anteAmount = button.Automaton switch
        {
            true => _randomService.GetAmount(antePrefs.Min, antePrefs.Max),
            false => GetAnteFromUser(antePrefs)
        };

        return Task.FromResult(anteAmount);
    }

    private static AntePreferences GetAntePrefs(GameRequest request)
    {
        var minPlayerStack = request.Players.Min(p => p.Stack);

        var antePrefs = request.Match.AntePreferences;

        // all players have enough for max ante
        if (minPlayerStack >= antePrefs.Max)
            return antePrefs;

        var effectivePrefs = antePrefs with
        {
            Min = (minPlayerStack < antePrefs.Min) ? minPlayerStack : antePrefs.Min,
            Max = minPlayerStack
        };

        return effectivePrefs;
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
