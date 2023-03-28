using Poker.Library.Cards;

namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryArgs args)
    {
        var standardCards = GenerateCombos<Spot>(args.SpotCardRanks, args.Suits)
            .Union(GenerateCombos<Face>(args.FaceCardRanks, args.Suits))
            .ToList();

        List<ICard> cards = standardCards.ToList<ICard>();

        for (uint j = 0; j < args.NumberOfJokers; j++)
            cards.Add(new Joker());

        return new Deck()
        {
            Cards = cards,
            NumberOfJokers = args.NumberOfJokers,
            CardRankValues = standardCards
                .Select(x => x.Rank.Value)
                .Distinct()
                .OrderBy(x => x)
                .ToList()
        };
    }

    private static IEnumerable<Standard> GenerateCombos<T>(List<Rank> ranks, List<Suit> suits) where T : Standard, new() =>
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