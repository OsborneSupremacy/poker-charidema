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

    public NeededCardMessageBuilder WithCard(Rank rank, Suit suit)
    {
        _cards.Add(
            new () { Rank = rank, Suit = suit }
        );
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
            WithCard(neededCard.Rank, neededCard.Suit);
        return this;
    }
}
