using Poker.Library.Cards;
using Poker.Library.Interface;
using Poker.Library.Variants;

namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryArgs args)
    {
        var deck = new Deck() with
        {
            Cards = args
                .PointCardRanks
                .Union(args.FaceCardRanks)
                .SelectMany(x => args.Suits,
                    (r, s) => new SpotCard()
                    {
                        Rank = r,
                        Suit = s,
                        CardOrientation = CardOrientations.Facedown
                    }
                ).ToList<ICard>()
        };

        for (uint j = 0; j < args.NumberOfJokers; j++)
            deck.Cards.Add(new Joker());

        return deck;
    }
}

public record DeckFactoryArgs
{
    public List<Rank> PointCardRanks { get; init; }

    public List<Rank> FaceCardRanks { get; init; }

    public List<Suit> Suits { get; init; }

    public uint NumberOfJokers { get; init; }

    public DeckFactoryArgs(List<Rank> pointCardRanks, List<Rank> faceCardRanks, List<Suit> suits)
    {
        PointCardRanks = pointCardRanks ?? throw new ArgumentNullException(nameof(pointCardRanks));
        FaceCardRanks = faceCardRanks ?? throw new ArgumentNullException(nameof(faceCardRanks));
        Suits = suits ?? throw new ArgumentNullException(nameof(suits));
    }

    public DeckFactoryArgs(
        List<Rank> pointCardRanks,
        List<Rank> faceCardRanks,
        List<Suit> suits, uint numberOfJokers) : this(pointCardRanks, faceCardRanks, suits)
    {
        NumberOfJokers = numberOfJokers;
    }
}