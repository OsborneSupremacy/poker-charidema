using Poker.Library.Phases;
using Poker.Library.Rounds;

namespace Poker.Service;

public class AutomatonMoveService : IAutomatonMoveService
{
    private readonly IUserInterfaceService _userInterfaceService;

    public AutomatonMoveService(IUserInterfaceService userInterfaceService)
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<MoveResult> ExecuteAsync(MoveArgs args) =>
        args.RoundArgs.Phase switch
        {
            Ante => AnteAsync(args),
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

    private Task<MoveResult> AnteAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var ante = args.RoundArgs.Game.Ante;

        _userInterfaceService
            .WriteLines($"{playerOut.Participant.Name} antes.");

        playerOut.Participant.Stack -= ante;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = playerOut,
                Deck = args.RoundArgs.Game.Deck,
                Pot = args.Pot + ante
            }
        );
    }

    private Task<MoveResult> DealAsync(MoveArgs args)
    {
        var playerOut = args.PlayerInTurn.DeepClone();
        var deckOut = args.RoundArgs.Game.Deck.DeepClone();

        var dealtCards = deckOut
            .Cards
            .Take(args.RoundArgs.Phase.GetCountOfCardsToDeal());

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
