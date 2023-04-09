namespace Poker.Library.Rounds;

public record Ante : IRound
{
    public string Name => "Ante";

    public bool GameCanEndAfter => true;
}
