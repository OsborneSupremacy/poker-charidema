using Poker.Library.Cards;
using Poker.Library.Interface;

namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryArgs args)
    {
        var deck = new Deck()
        {
            Cards = GenerateCombos<SpotCard>(args.SpotCardRanks, args.Suits)
                .Union(GenerateCombos<FaceCard>(args.FaceCardRanks, args.Suits))
                .ToList()
        };

        for (uint j = 0; j < args.NumberOfJokers; j++)
            deck.Cards.Add(new Joker());

        return deck;
    }

    private static IEnumerable<ICard> GenerateCombos<T>(List<Rank> ranks, List<Suit> suits) where T : StandardCard, new() =>
        ranks
            .SelectMany(x => suits,
                (r, s) => new T()
                {
                    Rank = r,
                    Suit = s,
                    CardOrientation = CardOrientations.Facedown
                }
            );
}

public record DeckFactoryArgs
{
    public List<Rank> SpotCardRanks { get; init; }

    public List<Rank> FaceCardRanks { get; init; }

    public List<Suit> Suits { get; init; }

    public uint NumberOfJokers { get; init; }

    public DeckFactoryArgs(List<Rank> spotCardRanks, List<Rank> faceCardRanks, List<Suit> suits)
    {
        SpotCardRanks = spotCardRanks ?? throw new ArgumentNullException(nameof(spotCardRanks));
        FaceCardRanks = faceCardRanks ?? throw new ArgumentNullException(nameof(faceCardRanks));
        Suits = suits ?? throw new ArgumentNullException(nameof(suits));
    }

    public DeckFactoryArgs(
        List<Rank> spotCardRanks,
        List<Rank> faceCardRanks,
        List<Suit> suits, uint numberOfJokers) : this(spotCardRanks, faceCardRanks, suits)
    {
        NumberOfJokers = numberOfJokers;
    }
}