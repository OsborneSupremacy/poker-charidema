namespace Poker.Service;

public class DeckFactory
{
    public Deck Create(DeckFactoryInputs inputs) =>
        new Deck() with
        {
            Cards = inputs
                .Ranks
                .SelectMany(x => inputs.Suits,
                    (r, s) =>  new Card() {
                        Rank = r,
                        Suit = s,
                        CardOrientation = CardOrientations.Facedown
                    }
                ).ToList()
        };
}

public record DeckFactoryInputs
{
    public List<Rank> Ranks { get; init; }

    public List<Suit> Suits { get; init; }

    public DeckFactoryInputs(List<Rank> ranks, List<Suit> suits)
    {
        Ranks = ranks ?? throw new ArgumentNullException(nameof(ranks));
        Suits = suits ?? throw new ArgumentNullException(nameof(suits));
    }
}