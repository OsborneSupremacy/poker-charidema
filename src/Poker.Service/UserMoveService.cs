using Poker.Library.Rounds;

namespace Poker.Service;

public class UserMoveService : IUserMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IRandomFactory _randomFactory;

    public UserMoveService(
        IUserInterfaceService userInterfaceService,
        IRandomFactory randomFactory
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args) =>
        args.RoundArgs.Round switch
        {
            Ante => AntePromptAsync(args),
            DealCards => DealAsync(args),
            _ => DefaultMoveAsync(args)
        };

    private Task<MoveResult> DefaultMoveAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        uint potOut = args.Pot;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = args.RoundArgs.Game.Deck,
                Pot = potOut
            }
        );
    }

    private Task<MoveResult> AntePromptAsync(MoveArgs args) =>
        _userInterfaceService.PromptForBool($"Ante {args.RoundArgs.Game.Ante:C}?") switch
        {
            true => AnteAsync(args),
            false => SitOutAsync(args)
        };

    private Task<MoveResult> AnteAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var ante = args.RoundArgs.Game.Ante;

        _userInterfaceService
            .WriteLines($"{playerOut.Player.Name} antes.");
        playerOut.Player.Stack -= ante;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = args.RoundArgs.Game.Deck,
                Pot = args.Pot + ante
            }
        );
    }

    private Task<MoveResult> SitOutAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();

        _userInterfaceService
            .WriteLines($"{playerOut.Player.Name} sits out.");
        playerOut.Folded = true;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = args.RoundArgs.Game.Deck,
                Pot = args.Pot
            }
        );
    }

    private Task<MoveResult> DealAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var deckOut = args.RoundArgs.Game.Deck.DeepClone();

        var dealtCards = deckOut
            .Cards
            .Take(args.RoundArgs.Round.GetCountOfCardsToDeal());

        playerOut.Cards.AddRange(dealtCards);
        deckOut.Cards.RemoveAll(
            c => dealtCards
                .Select(x => x.Id)
                .Contains(c.Id)
        );

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = deckOut,
                Pot = args.Pot
            }
        );
    }
}
