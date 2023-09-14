using Poker.Library.Phases;
using Poker.Library.Rounds;

namespace Poker.Service;

public class DealerService : IDealerService, IPhaseService
{
    private readonly IRandomFactory _randomFactory;

    public DealerService(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<PhaseResult> ExecuteAsync(PhaseArgs args)
    {
        var dealPhase = (args.Phase as DealCards)!;

        var playersOut = new List<InGamePlayer>();

        var ccOut = args.CommunityCards.DeepClone();
        var deckOut = args.Deck.DeepClone();

        var playerInTurn = args.StartingPlayer;

        for(var c = 0; c < dealPhase.Count; c++)
        {
            while(playersOut.Count < args.Game.Players.Count)
            {
                if(playerInTurn.Folded)
                {
                    playersOut.Add(playerInTurn);
                    continue;
                }
                DealCard(deckOut, playerInTurn, dealPhase);
                playersOut.Add(playerInTurn);
                playerInTurn = args.Game.Players.NextPlayer(playerInTurn);
            }
        }

        return Task.FromResult(new PhaseResult
        {
            Deck = deckOut,
            CommunityCards = ccOut,
            Players = playersOut,
            GameOver = false,
            Pot = args.Pot
        });
    }

    private void DealCard(IDeck deckOut, InGamePlayer playerInTurn, DealCards dealPhase)
    {
        var cardToDeal = deckOut.Cards.First();
        cardToDeal.CardOrientation = dealPhase.CardOrientation;
        playerInTurn.Cards.Add(cardToDeal);
        deckOut.Cards.Remove(cardToDeal);
    }

    public Task<IDeck> ShuffleAsync(IDeck deck)
    {
        var random = _randomFactory.Create();

        // Fisher-Yates shuffle algorithm
        for (int i = deck.Cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (deck.Cards[j], deck.Cards[i]) = (deck.Cards[i], deck.Cards[j]);
        }

        return Task.FromResult(deck);
    }
}
