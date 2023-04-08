namespace Poker.Library.RoundActions;

public record Ante : IRoundAction
{
    public string Name => "Ante";

    public bool GameCanEndAfter => true;
}
