using Bogus;

namespace Poker.Service;

public class AnteSetService : IAnteSetService
{
    private readonly IRandomFactory _randomFactory;

    private readonly IUserInterfaceService _userInterfaceService;

    public AnteSetService(
        IRandomFactory randomFactory,
        IUserInterfaceService userInterfaceService
        )
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<uint> GetAsync(GameArgs gameArgs, Player button)
    {
        if (gameArgs.Match.AntePreferences is FixedAnte fixedAnte)
            return Task.FromResult(fixedAnte.Amount);

        var antePrefs = GetAntePrefs(gameArgs);

        uint anteAmount = button.Participant.Automaton switch
        {
            true => new Randomizer(_randomFactory.GetSeed())
                .UInt(antePrefs.MinAnte, antePrefs.MaxAnte),
            false => GetAnteFromUser(antePrefs)
        };

        return Task.FromResult(anteAmount);
    }

    private DealersChoiceAnte GetAntePrefs(GameArgs gameArgs)
    {
        var minPlayerStack = gameArgs.Players.Min(p => p.Stack);

        var antePrefs = (DealersChoiceAnte)gameArgs.Match.AntePreferences;

        // all players have enough for max ante
        if (minPlayerStack >= antePrefs.MaxAnte)
            return antePrefs;

        DealersChoiceAnte effectivePrefs = new()
        {
            MinAnte = (minPlayerStack < antePrefs.MinAnte) ? minPlayerStack : antePrefs.MinAnte,
            MaxAnte = minPlayerStack
        };

        return effectivePrefs;
    }

    private uint GetAnteFromUser(DealersChoiceAnte antePrefs)
    {
        uint anteAmount = 0;
        _userInterfaceService
            .PromptForMoney("Specify ante amount", antePrefs.MinAnte, antePrefs.MaxAnte, input =>
            {
                anteAmount = input;
            });
        return anteAmount;
    }
}
