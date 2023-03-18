using Poker.Library.Interface;

namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryArgs args)
    {
        var deck = new Deck() with
        {
            Cards = args
                .Ranks
                .SelectMany(x => args.Suits,
                    (r, s) => new StandardCard()
                    {
                        Rank = r,
                        Suit = s,
                        CardOrientation = CardOrientations.Facedown
                    }
                ).ToList<ICard>()
        };

        var maxValue = args.Ranks.Select(x => x.Value).Max();

        for (uint j = 0; j < args.NumberOfJokers; j++)
            deck.Cards.Add(new Joker());

        return deck;
    }
}

public record DeckFactoryArgs
{
    public List<Rank> Ranks { get; init; }

    public List<Suit> Suits { get; init; }

    public uint NumberOfJokers { get; init; }

    public DeckFactoryArgs(List<Rank> ranks, List<Suit> suits)
    {
        Ranks = ranks ?? throw new ArgumentNullException(nameof(ranks));
        Suits = suits ?? throw new ArgumentNullException(nameof(suits));
        NumberOfJokers = 0;
    }

    public DeckFactoryArgs(List<Rank> ranks, List<Suit> suits, uint numberOfJokers)
    {
        Ranks = ranks ?? throw new ArgumentNullException(nameof(ranks));
        Suits = suits ?? throw new ArgumentNullException(nameof(suits));
        NumberOfJokers = numberOfJokers;
    }
}