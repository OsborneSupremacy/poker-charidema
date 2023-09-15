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
        uint potOut = args.Pot;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = args.PlayerInTurn,
                Deck = args.RoundArgs.Game.Deck,
                Pot = potOut
            }
        );
    }

    private Task<MoveResult> AnteAsync(MoveArgs args)
    {
        var stackOut = args.PlayerInTurn.Participant.Stack;

        var ante = args.RoundArgs.Game.Ante;

        _userInterfaceService
            .WriteLines($"{args.PlayerInTurn.Participant.Name} antes.");

        stackOut -= ante;

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = args.PlayerInTurn with
                {
                    Participant = args.PlayerInTurn.Participant with {
                        Stack = stackOut
                    }
                },
                Deck = args.RoundArgs.Game.Deck,
                Pot = args.Pot + ante
            }
        );
    }

    private Task<MoveResult> DealAsync(MoveArgs args)
    {
        var playerCardsOut = args.PlayerInTurn.Cards;

        var deckOut = args.RoundArgs.Game.Deck.DeepClone();

        var dealtCards = deckOut
            .Cards
            .Take(args.RoundArgs.Phase.GetCountOfCardsToDeal());

        playerCardsOut.AddRange(dealtCards);

        deckOut.Cards.RemoveAll(
            c => dealtCards
                .Select(x => x.Id)
                .Contains(c.Id)
        );

        return Task.FromResult(
            new MoveResult
            {
                PlayerInTurn = args.PlayerInTurn with { Cards = playerCardsOut },
                Deck = deckOut,
                Pot = args.Pot
            }
        );
    }
}
