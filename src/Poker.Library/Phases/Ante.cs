namespace Poker.Library.Phases;

public record Ante : IPhase
{
    public string Name => "Ante";

    public bool GameCanEndAfter => true;
}
