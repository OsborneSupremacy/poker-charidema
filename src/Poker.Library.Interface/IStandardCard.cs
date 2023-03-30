namespace Poker.Library.Interface;

public interface IStandardCard : ICard
{
    IRank Rank { get; init; }

    ISuit Suit { get; init; }
}
