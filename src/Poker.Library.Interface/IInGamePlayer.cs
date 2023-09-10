namespace Poker.Library.Interface;

public interface IInGamePlayer
{
    IPlayer Player { get; init; }

    List<ICard> Cards { get; init; }

    bool Folded { get; set; }
}
