using Poker.Library;
using Poker.Library.AntePreferences;

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

    public Task<uint> GetAsync(GameArgs gameArgs, IInGamePlayer button)
    {
        if (gameArgs.Match.AntePreferences is Fixed fixedAnte)
            return Task.FromResult(fixedAnte.Amount);

        //var maxAnte = gameArgs.Players.Min(p => p.Stack);

        uint anteAmount = 0;

        switch(button.Player.Automaton)
        {
            case true:
                anteAmount = 0;
                break;

            case false:
                _userInterfaceService
                    .PromptForMoney("Specify ante amount", 1, (int)gameArgs.Match.StartingStack, input =>
                    {
                        anteAmount = (uint)input;
                    });
                break;
        }

        return Task.FromResult(anteAmount);
    }



    private uint GetAnteFromUser(GameArgs gameArgs)
    {
        uint anteAmount = 0;
        _userInterfaceService
            .PromptForMoney("Specify ante amount", 1, (int)gameArgs.Match.StartingStack, input =>
            {
                anteAmount = (uint)input;
            });
        return anteAmount;
    }
}
