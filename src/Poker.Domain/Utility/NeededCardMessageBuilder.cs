namespace Poker.Domain.Utility;

internal class NeededCardMessageBuilder
{
    private readonly NeededCardMessage _message;

    public NeededCardMessageBuilder()
    {
        _message = new()
        {
            Groups = new()
        };
    }

    public NeededCardMessageBuilder WithCard(uint count, Card card)
    {
        _message.Groups.Add(new()
        {
            Count = count,
            Cards = new() { card }
        });
        return this;
    }

    public NeededCardMessageBuilder WithCards(uint count, IEnumerable<Card> cards)
    {
        _message.Groups.Add(new()
        {
            Count = count,
            Cards = cards.ToList()
        });
        return this;
    }

    public NeededCardMessage Build() => _message;

    public static NeededCardMessage Empty() =>
        new()
        {
            Groups = Enumerable.Empty<NeededCardGroup>().ToList()
        };
    }
