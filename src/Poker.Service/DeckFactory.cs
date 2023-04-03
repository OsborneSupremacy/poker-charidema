using Poker.Library.Cards;

namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryArgs args)
    {
        List<IStandardCard> standardCards = new();
        standardCards.AddRange(GenerateCombos<Spot>(args.SpotCardRanks, args.Suits));
        standardCards.AddRange(GenerateCombos<Face>(args.FaceCardRanks, args.Suits));

        List<ICard> cards = new();
        cards.AddRange(standardCards);

        for (uint j = 0; j < args.NumberOfJokers; j++)
            cards.Add(new Joker());

        return new Deck()
        {
            Cards = cards,
            NumberOfJokers = args.NumberOfJokers,
            CardRankValues = standardCards
                .Select(x => x.Rank.Value)
                .Distinct()
                .OrderByDescending(x => x)
                .ToList(),
            CardSuitPriorities = standardCards
                .Select(x => x.Suit.Priority)
                .Distinct()
                .OrderByDescending(x => x)
                .ToList()
        };
    }

    private static IEnumerable<T> GenerateCombos<T>(List<Rank> ranks, List<Suit> suits) where T : IStandardCard, new() =>
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
