namespace Poker.Domain.Utility;

internal class NeededCardMessageBuilder
{
    private readonly NeededCardMessage _neededCardMessage;

    private readonly List<NeededCardGroup> _neededCardGroups;

    private NeededCardGroup _currentGroup;

    private List<NeededCard> _currentGroupCards;

    public NeededCardMessageBuilder()
    {
        _currentGroupCards = new();
        _currentGroup = new NeededCardGroup
        {
            Count = 0,
            Cards = _currentGroupCards
        };
        _neededCardGroups = new();
        _neededCardMessage = new()
        {
            NeededCardGroups = _neededCardGroups
        };
    }

    public NeededCardMessageBuilder WithGroup(int count)
    {
        _currentGroupCards = new List<NeededCard>();

        _currentGroup = new()
        {
            Count = count.ToUint(),
            Cards = _currentGroupCards
        };

        _neededCardGroups.Add(_currentGroup);
        return this;
    }

    public NeededCardMessageBuilder WithCard(Rank rank, Suit suit)
    {
        _currentGroupCards.Add(
            new () { Rank = rank, Suit = suit }
        );
        return this;
    }

    public NeededCardMessage Build() => _neededCardMessage;

    public static NeededCardMessage Empty() =>
        new()
        {
            NeededCardGroups = Enumerable.Empty<NeededCardGroup>().ToList()
        };

    internal NeededCardMessageBuilder WithCards(List<NeededCard> neededCards)
    {
        foreach (var neededCard in neededCards)
            WithCard(neededCard.Rank, neededCard.Suit);
        return this;
    }
}
