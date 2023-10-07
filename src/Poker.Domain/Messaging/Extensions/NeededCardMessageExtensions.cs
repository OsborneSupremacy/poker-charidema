namespace Poker.Domain.Extensions;

public static class NeededCardMessageExtensions
{
    public static int TotalNeededCards(this NeededCardMessage neededCardMessage) =>
        neededCardMessage
            .NeededCardGroups
            .Sum(g => g.Count.ToInt());
}

