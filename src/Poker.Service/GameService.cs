using Poker.Library.RoundActions;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly IDealerService _dealerService;

    private readonly IRoundActionService _roundActionService;


    public async Task<Game> PlayAsync(GameArgs args)
    {
        Game game = new() {
            Variant = args.Variant,
            Players = args.Players,
            Deck = args.Deck
        };

        var deck = await _dealerService.ShuffleAsync(args.Deck);

        foreach(var action in args.Variant.RoundActions)
        {
            var result = await _roundActionService
                .ExecuteAsync(new RoundActionArgs() { 
                    RoundAction = action,
                    Deck = deck,
                    Players = args.Players
                });
            if (result.GameOver)
                return game;
        }

        return game;
    }
}
