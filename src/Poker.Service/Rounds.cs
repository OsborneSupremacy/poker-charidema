using Poker.Library;

namespace Poker.Service;

public class Rounds
{
    private readonly Round _hand;

    private readonly List<HandPlayer> _players;

    public Rounds(Round hand, List<HandPlayer> players)
    {
        _hand = hand ?? throw new ArgumentNullException(nameof(hand));
        _players = players ?? throw new ArgumentNullException(nameof(players));
    }

    public void Play()
    {

    }

}
