namespace Poker.Domain.Utility;

internal class NeededCardMessageBuilder
{
    private readonly NeededCardMessage _message;

    private readonly List<NeededCard> _cards;

    public NeededCardMessageBuilder()
    {
        _cards = new();
        _message = new()
        {
            Cards = _cards
        };
    }

    public NeededCardMessageBuilder WithCard(Rank rank, List<Suit> suits)
    {
        _cards.Add(
            new() { Ranks = new() { rank }, Suits = suits }
        );
        return this;
    }

    public NeededCardMessageBuilder WithCard(List<Rank> ranks, Suit suit)
    {
        _cards.Add(
            new() { Ranks = ranks, Suits = new() { suit } }
        );
        return this;
    }

    public NeededCardMessageBuilder WithCard(List<Rank> ranks, List<Suit> suits)
    {
        _cards.Add(
            new () { Ranks = ranks, Suits = suits }
        );
        return this;
    }

    public NeededCardMessageBuilder WithCards(List<Rank> ranks, List<Suit> suits, int count)
    {
        for (var i = 0; i < count; i++)
            WithCard(ranks, suits);
        return this;
    }

    public NeededCardMessage Build() => _message;

    public static NeededCardMessage Empty() =>
        new()
        {
            Cards = Enumerable.Empty<NeededCard>().ToList()
        };

    internal NeededCardMessageBuilder WithCards(List<NeededCard> neededCards)
    {
        foreach (var neededCard in neededCards)
            WithCard(neededCard.Ranks, neededCard.Suits);
        return this;
    }
}
